# Rent A Car Otomasyon Sistemi

Bu proje, Nesne Tabanlı Programlama dersi kapsamında geliştirilmiş bir "Araç Kiralama Otomasyon Sistemidir".

##  Proje Özeti

- Kullanıcı; araç ekleyebilir, müşterileri kaydedebilir, araç kiralayabilir ve raporlama alabilir.
- WinForms ile arayüz tasarımı yapılmıştır.
- Veriler geçici olarak bellek (List<T>) içinde tutulmuştur.

##  Uygulanan OOP Kavramları

###  Kalıtım (Inheritance)
- `Arac` adında soyut bir sınıf oluşturulmuş; `Sedan`, `SUV`, `Kamyonet` sınıfları bu sınıftan türetilmiştir.

###  Polimorfizm
- `KiraHesapla(int gun)` metodu `Arac` sınıfında tanımlanmış ve alt sınıflarda override edilmiştir.
- Araç türüne göre kiralama bedeli farklı hesaplanır.

###  Arayüzler (Interfaces)
- `IKiralik`: Kira hesaplaması yapılabilen tüm sınıflara ortak davranış kazandırır.
- `IAracOzellikleri`: Araçlara ait temel özellikleri (Plaka, Marka, Model...) zorunlu kılar.

##  Modüller

- **Araç Yönetimi**: Araç ekle/sil/güncelle, listele
- **Müşteri Kaydı**: Müşteri bilgilerini girme ve görüntüleme
- **Kiralama**: Araç ve müşteri seçerek kiralama işlemi ve ücret hesaplama
- **Raporlama**: Toplam kiralama sayısı, ciro ve en çok kiralanan araç bilgileri

##  Kullanılan Teknolojiler
- C# (.NET Framework 4.x)
- WinForms
- Nesne Tabanlı Programlama (OOP)

##  Geliştirici
Emirhan Efe Gözpınar  
Bilgisayar Mühendisliği Öğrencisi  
220260038
Fırat Üniversitesi (2022–2026)

