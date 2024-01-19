using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SportsShop.Domain.Models.Users;

namespace SportsShop.Domain.Models.Stores
{

	public class Office
	{
		[Key]
		public int Id { get; set; }

		public int UserId { get; set; }
		[Display(Name = "نام فروشگاه")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string Name { get; set; }


		[Display(Name = "نام سایت")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string SiteName { get; set; }

		[Display(Name = "آدرس")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string Address { get; set; }
		[Display(Name = "شماره تماس")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string PhoneNumber { get; set; }
		[Display(Name = "ایمیل")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string Email { get; set; }

		[Display(Name = "روزکاری عادی")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string NormalDayWorkingTitle { get; set; }
		[Display(Name = "ساعت کاری روز عادی")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string NormalDayWorkingHours { get; set; }
		

		[Display(Name = "روز کاری تعطیل")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string HolidayWorkingTitle { get; set; }


		[Display(Name = "ساعت کاری تعطیل")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string HolidayWorkingHours{ get; set; }

		[Display(Name = "لگو")]
		public string Logo { get; set; }

		[Display(Name = "عکس فروشگاه")]
		public string Image { get; set; }

		[Display(Name = "توضیحات")]
		public string Description { get; set; }

		[Display(Name = "Facebook")]
		public string Facebook { get; set; }

		[Display(Name = "Threads")]
		public string Threads { get; set; }

		[Display(Name = "Instagram")]
		public string Instagram { get; set; }

		[Display(Name = "YouTube")]
		public string YouTube { get; set; }

		[Display(Name = "Telegram")]
		public string Telegram { get; set; }

		[Display(Name = "WhatsApp")]
		public string WhatsApp { get; set; }

		[Display(Name = "عرض جغرافیایی")]
		[MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]

		public string Longitude { get; set; }
		[Display(Name = "طول جغرافیایی")]
		[MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]

		public string Latitude { get; set; }






		[Display(Name = "تاریخ ثبت")]
		public DateTime CreateDate { get; set; } = DateTime.Now;
		[Display(Name = "تاریخ ویرایش")]
		public DateTime? UpdateDate { get; set; }



		#region Relations

		public User User { get; set; }

		#endregion
	}


}