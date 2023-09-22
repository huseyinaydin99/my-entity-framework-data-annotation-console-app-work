using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAnnotationConsoleApp.DAL.DTOs
{
    [ComplexType] //Bu bir entity değildir sakın bu sınıfı RDBMS DB'lerdeki tablolara eşleme demiş olduk. Yani böyle bir dipnot bıraktık yapmasın diye.
    public class MusteriSiparisDTO
    {
        public string CustomerId { get; set; }
        public int OrderId { get; set; }
    }
}