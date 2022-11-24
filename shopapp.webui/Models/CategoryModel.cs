using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Kategori adi zorunludur.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Kategori adi 5-100 karakter araliginda olmalidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Url zorunludur.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Url 5-100 karakter araliginda olmalidir.")]
        public string Url { get; set; }

        public List<Product> Products { get; set; }
    }
}