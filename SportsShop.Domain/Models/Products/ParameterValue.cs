using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsShop.Domain.Models.Products
{
    public class ParameterValue:BaseEntity
    {

        public int ParameterId { get; set; }


        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(100)]
        public string Name { get; set; }


        #region Relations

        public Parameter Parameter { get; set; }
        #endregion
    }
}