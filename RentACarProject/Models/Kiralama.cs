using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Models
{
    public class Kiralama

    {
        public string MusteriAdi { get; set; }
        public string AracBilgisi { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public decimal Ucret { get; set; }
    }
}
