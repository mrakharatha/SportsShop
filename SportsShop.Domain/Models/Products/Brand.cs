using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsShop.Domain.Models.Products
{
    public class Brand : BaseEntity
    {
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(100)]
        public string Name { get; set; }


        #region Relations

        public ICollection<Product> Products { get; set; }        

        #endregion
    }
    
}