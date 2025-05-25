using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Models
{
    public class Sedan : Arac
    {
        public Sedan()
        {
            AracTuru = "Sedan";
        }

        public override decimal KiraHesapla(int gun)
        {
            return gun * GunlukUcret;
        }
    }


}
