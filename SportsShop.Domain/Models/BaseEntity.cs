using System.ComponentModel.DataAnnotations;
using System;
using SportsShop.Domain.Models.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsShop.Domain.Models
{
    public class BaseEntity
    {

        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }






        [ForeignKey(nameof(UserId))]
        public User User { get; set; }



        [Display(Name = "تاریخ ثبت")]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "تاریخ ویرایش")]
        public DateTime? UpdateDate { get; set; }
        [Display(Name = "تاریخ حذف")]
        public DateTime? DeleteDate { get; set; }
    }
}