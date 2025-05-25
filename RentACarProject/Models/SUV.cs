using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Models
{
    public class SUV: Arac
    {
        public SUV()
        {
            AracTuru = "SUV";
        }

        public override decimal KiraHesapla(int gun)
        {
            return gun * GunlukUcret * 1.2m;
        }
    }

}
