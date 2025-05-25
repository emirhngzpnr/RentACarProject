using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Models
{
    public class Kamyonet:Arac
    {
        public Kamyonet() {
            AracTuru = "Kamyonet";
        }

        public override decimal KiraHesapla(int gun)
        {
            return gun * GunlukUcret * 1.5m;
        }
    }
}
