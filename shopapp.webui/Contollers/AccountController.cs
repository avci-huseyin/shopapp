using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.webui.EmailServices;
using shopapp.webui.Extensions;
using shopapp.webui.Identity;
using shopapp.webui.Models;

namespace shopapp.webui.Contollers
{
    // csrf
    [AutoValidateAntiforgeryToken] 
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        private ICartService _cartService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender, ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _cartService = cartService;
        }

        public IActionResult Login(string ReturnUrl=null)
        {
            return View(new LoginModel
            {
                ReturnUrl = ReturnUrl
            });
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if(user == null)
            {
                ModelState.AddModelError("", "Bu kullanici adi ile daha once hesap olusturulmamis.");
                return View(model); 
            }

            if(!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Lutfen email hesabiniza gelen link ile uyeliginizi onaylayiniz.");
                return View(model); 
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);

            if(result.Succeeded)
            {
                return Redirect(model.ReturnUrl??"~/");
            }

            ModelState.AddModelError("", "Girilen kullanici adi veya parola yanlis.");
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if(result.Succeeded)
            {
                // generate token
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new {
                    userId = user.Id,
                    token = code
                });
                Console.WriteLine(url);

                await _emailSender.SenEmailAsync(model.Email, "Hesabinizi Onaylayiniz", $"Lutfen email hesabinizi onaylamak icin linke <a href='https://localhost:5001{url}'>tiklayiniz</a>");

                return RedirectToAction("Login", "Account");
            }

            ModelState.AddModelError("Password", "Sifre alaninda buyuk/kucuk/alfanumerik ve numerik max 6 karakter kullaniniz.");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            TempData.Put("message", new AlertMessage(){
                Title = "Oturum Kapatildi",
                Message = "Hesabiniz guvenli bir sekilde kapatilmistir.",
                AlertType = "warning"

            });

            return Redirect("~/");
        }
    
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if(userId == null || token == null)
            {
                TempData.Put("message", new AlertMessage(){
                    Title = "Geçersiz Token",
                    Message = "Geçersiz Token",
                    AlertType = "danger"

                });
                return View();
            }

            var user = await _userManager.FindByIdAsync(userId);
            if(user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if(result.Succeeded)
                {
                    // initialize cart
                    _cartService.InitializeCart(user.Id);

                    TempData.Put("message", new AlertMessage(){
                        Title = "Hesabiniz Onaylandi!",
                        Message = "Artık Uygulamaya Giriş Yapabilirsiniz!",
                        AlertType = "success"

                    });
                    return View();
                }
            }

            TempData.Put("message", new AlertMessage(){
                Title = "Hesabiniz Onaylanmadi!",
                Message = "Hesabiniz Onaylanmadi!",
                AlertType = "warning"

            });

            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if(string.IsNullOrEmpty(Email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);

            if(user == null)
            {
                return View();
            }

            // generate token
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new {
                userId = user.Id,
                token = code
            });
            Console.WriteLine(url);

            await _emailSender.SenEmailAsync(Email, "Reset Password", $"Lutfen parolanizi yenilemek icin linke <a href='https://localhost:5001{url}'>tiklayiniz</a>");

            return View();
        }

        public IActionResult ResetPassword(string userId, string token)
        {
            if(userId == null || token == null)
            {
                return RedirectToAction("Home", "Index");
            }

            var model = new ResetPasswordModel {Token = token};

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if(user == null)
            {
                return RedirectToAction("Home", "Index");
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);

            if(result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            
            return View(model);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}