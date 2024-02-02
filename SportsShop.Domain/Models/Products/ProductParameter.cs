using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsShop.Domain.Models.Products
{
    public class ProductParameter
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ParameterId { get; set; }

        #region Relations


        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        [ForeignKey(nameof(ParameterId))]
        public Parameter Parameter { get; set; }


        #endregion
    }
}