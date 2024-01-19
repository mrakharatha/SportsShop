using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SportsShop.Domain.Models.Users;
using System;

namespace SportsShop.Domain.Models.Product
{
    public class ProductGroup:BaseEntity
    {

    
        public int? ParentId { get; set; }


        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public bool Status { get; set; }
        public int Priority { get; set; }




       



        [ForeignKey(nameof(ParentId))]
        public ProductGroup ParentGroup { get; set; }

    }
}