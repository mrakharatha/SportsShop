using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsShop.Domain.ViewModels.User
{
    public class CreateUserViewModel
    {
        [Display(Name = "سطح دسترسی")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
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
        [DataType(DataType.Password)]

        public string Password { get; set; }




        [Display(Name = "تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        public string RePassword { get; set; }


        public List<int> UserRoles { get; set; }
    }


    public class EditUserViewModel
    {


        public int UserId { get; set; }

        [Display(Name = "سطح دسترسی")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        public int? RoleId { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]

        public string FullName { get; set; }

        [Display(Name = "کلمه عبور")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        [DataType(DataType.Password)]

        public string Password { get; set; }



        [Display(Name = "تکرار رمز عبور")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        public string RePassword { get; set; }


    }

}
