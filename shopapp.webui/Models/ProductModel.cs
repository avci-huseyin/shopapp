using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        // [Display(Name="Name", Prompt="Enter Product Name")]
        // [Required(ErrorMessage ="Name alani zorunludur.")]
        // [StringLength(60, MinimumLength = 5, ErrorMessage = "Urun ismi 5-60 karakter araliginda olmalidir")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Url alani zorunludur.")]
        public string Url { get; set; }

        // [Required(ErrorMessage ="Price alani zorunludur.")]
        // [Range(1, 10000, ErrorMessage = "Price için 1-10000 arasinda bir deger girilmelidir.")]
        public double? Price { get; set; }

        [Required(ErrorMessage ="Description alani zorunludur.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Urun aciklamasi 5-100 karakter araliginda olmalidir")]
        public string Description { get; set; }

        [Required(ErrorMessage ="ImageUrl alani zorunludur.")]
        public string ImageUrl { get; set; }

        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }

        public List<Category> SelectedCategories { get; set; }
    }
}