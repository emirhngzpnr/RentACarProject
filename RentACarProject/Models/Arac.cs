using RentACarProject.Models;

public abstract class Arac: IKiralik, IAracOzellikler
{
    public string AracTuru { get; set; }  // "Sedan", "SUV", "Kamyonet"
    public string Plaka { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Yil { get; set; }
    public decimal GunlukUcret { get; set; }

    public string OzluBilgi => $"{Marka}- {Model}- ({Yil})";

    public abstract decimal KiraHesapla(int gun);
}
