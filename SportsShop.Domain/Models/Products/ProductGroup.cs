using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsShop.Domain.Models.Products
{
    public class ProductGroup:BaseEntity
    {

        [Display(Name = "سرگروه")]
        public int? ParentId { get; set; }


        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "وضعیت")]
        public bool Status { get; set; }


        [Display(Name = "الویت")]
        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید")]
        [Range(1, 1000, ErrorMessage = "مقدار {0} باید بین {1} تا {2} باشد")]

        public int? Priority { get; set; }




       



        [ForeignKey(nameof(ParentId))]
        public ProductGroup ParentGroup { get; set; }

    }
}