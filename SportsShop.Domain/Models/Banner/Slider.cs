using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsShop.Domain.Models.Banner
{
    public class Slider:BaseEntity
    {


        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Display(Name = "عنوان دوم")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(100)]
        public string SubTitle { get; set; }


        [Display(Name = "نمایش کلید")]
        public bool ActiveButton { get; set; }

        [Display(Name = "عنوان نمایشی کلید")]
        [MaxLength(100)]
        public string NameButton { get; set; }

        [Display(Name = "آدرس نمایش کلید")]
        [MaxLength(100)]
        public string UrlButton { get; set; }

        [Display(Name = "عکس اسلابدر")]
        [MaxLength(300)]

        public string SliderImage { get; set; }


        [Display(Name = "عکس اسلابدر")]
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}