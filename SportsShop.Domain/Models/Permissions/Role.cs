using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SportsShop.Domain.Models.Users;

namespace SportsShop.Domain.Models.Permissions
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Display(Name = "عنوان نقش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string RoleTitle { get; set; }
        [Display(Name = "توضیحات")]
        [MaxLength(400, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }


        #region Relations

        public List<RolePermission> RolePermissions{ get; set; }
        public  List<User> Users { get; set; }

        #endregion

    }
}
