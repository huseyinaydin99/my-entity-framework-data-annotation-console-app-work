using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAnnotationConsoleApp.DAL.Entities
{
    [Table("Customers")] //tablo adı verir. yemin ederim Hibernate'den çalıntı. Microsoft .NET'i Java'dan kopyaladı.
    public class Customer
    {
        [Key] //
        [Column("CustomerId")] //kolon adı vermece. Kolon adı Code.
        [MaxLength(5)]
        public string Code { get; set; }

        [Required]
        [Column("NameSurname")]
        [MaxLength(50)]
        [ConcurrencyCheck]
        public string NameSurname { get; set; }

        [Required]
        [Column("Company")]
        [MaxLength(50)]
        public string Company { get; set; }

        [Column("City")]
        [MaxLength(50)]
        public string City { get; set; }

        [Column("Counrty")]
        [NotMapped]
        public string Counrty { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        public List<Order> Orders { get; set; }
    }
}
