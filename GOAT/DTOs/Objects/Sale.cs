using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Objects
{
    public class Sale :BaseEntity
    {
        [ForeignKey("Product")]
        public required int ProductId { get; set; }
        public required Product Product { get; set; }

        [ForeignKey("Seller")]
        public required int SellerId { get; set; }
        public required Seller Seller { get; set; }


        [ForeignKey("Customer")]
        public required int CustomerId { get; set; }
        public required Customer Customer { get; set; }

        public double? Discount { get; set; }
        public string? DiscountReason { get; set; }
        public required DateTime Date { get; set; }

        public string? Note { get; set; }
        public double? RemainingPayment { get; set; }

    }
}
