using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Models
{
    public interface IAracOzellikler
    {
        string Plaka { get; set; }
        string Marka { get; set; }
        string Model { get; set; }
        int Yil { get; set; }
        decimal GunlukUcret { get; set; }
    }
}
