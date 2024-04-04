using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsShop.Domain.Models.Products
{
    public class Product : BaseEntity
    {
        [Display(Name = "گروه کالا")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        public int? ProductGroupId { get; set; }


        [Display(Name = "برند کالا")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        public int? BrandId { get; set; }


        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Display(Name = "وضعیت")]
        public bool Status { get; set; }

        [Display(Name = "تصویر محصول")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(300)]
        public string ProductImage { get; set; }


        [Display(Name = "قیمت محصول")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [Range(1, Int32.MaxValue, ErrorMessage = "مقدار {0} باید بین {1} تا {2} باشد")]
        public int? PriceProduct { get; set; }

        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(500)]
        public string BriefDescription{ get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }


        [Display(Name = "اطلاعات بیشتر")]
        public string MoreInformation { get; set; }

        [Display(Name = "ارسال و برگشت")]
        public string SendAndReturn { get; set; }


        #region Relations

        [ForeignKey(nameof(ProductGroupId))]
        public ProductGroup ProductGroup { get; set; }

        [ForeignKey(nameof(BrandId))]
        public Brand Brand { get; set; }
        public ICollection<ProductGallery> ProductGalleries { get; set; }
        #endregion
    }
}