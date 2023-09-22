using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAnnotationConsoleApp.DAL.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Column("OrderId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //zaten vermezsek default olarak Identity'dir yani otomatik artan sayıdır.
        public int Code { get; set; }

        [Column("CustomerId")]
        public string CustomerCode { get; set; }

        [ForeignKey("CustomerCode")]
        public Customer Customer { get; set; }
    }
}
