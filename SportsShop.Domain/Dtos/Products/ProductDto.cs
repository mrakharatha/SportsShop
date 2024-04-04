using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace SportsShop.Domain.Dtos.Products
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        [Display(Name = "گروه کالا")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        public int? ProductGroupId { get; set; }


        [Display(Name = "برند کالا")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        public int? BrandId { get; set; }




        public int UserId { get; set; }


        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Display(Name = "وضعیت")]
        public bool Status { get; set; }


        [Display(Name = "تصویر محصول")]
        public IFormFile ProductImage { get; set; }

        public string PathImage { get; set; }

        [Display(Name = "قیمت محصول")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [Range(1, Int32.MaxValue, ErrorMessage = "مقدار {0} باید بین {1} تا {2} باشد")]
        public int? PriceProduct { get; set; }



        [Display(Name = "قیمت محصول")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        public string Number { get; set; }



        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(500)]
        public string BriefDescription { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }


        [Display(Name = "اطلاعات بیشتر")]
        public string MoreInformation { get; set; }

        [Display(Name = "ارسال و برگشت")]
        public string SendAndReturn { get; set; }
    }
}