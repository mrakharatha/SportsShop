using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SportsShop.Domain.Models.Banner;
using SportsShop.Domain.Models.Permissions;
using SportsShop.Domain.Models.Products;
using SportsShop.Domain.Models.Stores;

namespace SportsShop.Domain.Models.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "نقش کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int? RoleId { get; set; }


        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]

        public string FullName { get; set; }
        

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]

        public string UserName { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Password { get; set; }
        
      


        [Display(Name = "تاریخ ثبت")]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "تاریخ ویرایش")]
        public DateTime? UpdateDate { get; set; }
        [Display(Name = "تاریخ حذف")]
        public DateTime? DeleteDate { get; set; }





        #region Relations
        public Role  Role { get; set; }
        public ICollection<Office> Offices { get; set; }
        public ICollection<ProductGroup> ProductGroups { get; set; }
        public ICollection<Parameter> Parameters { get; set; }
        public ICollection<ParameterValue> ParameterValues { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Brand> Brands { get; set; }
        public ICollection<Slider> Sliders { get; set; }
        #endregion
    }
}
