using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace SportsShop.Domain.Models.Products
{
    public class ProductGallery:BaseEntity
    {
        public int ProductId { get; set; }

        [Display(Name = "تصویر محصول")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(300)]
        public string ProductImage { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }


        #region Relations


        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        #endregion
    }
}