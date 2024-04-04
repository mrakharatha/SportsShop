using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsShop.Domain.Models.Products
{
    public class Brand : BaseEntity
    {
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(100)]
        public string Name { get; set; }


        [Display(Name = "لگو برند")]
        [MaxLength(300)]

        public string BrandImage { get; set; }


        [Display(Name = "لگو برند")]
        [NotMapped]
        public IFormFile Image { get; set; }

        #region Relations

        public ICollection<Product> Products { get; set; }        

        #endregion
    }
    
}