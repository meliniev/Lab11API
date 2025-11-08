using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab11API.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; } // PK

        [ForeignKey("Customer")]
        public int CustomerId { get; set; } // FK

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool Activo { get; set; }

        public Customer Customer { get; set; }
    }
}
