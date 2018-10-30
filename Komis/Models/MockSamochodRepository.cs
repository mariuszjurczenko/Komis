using System.Collections.Generic;
using System.Linq;

namespace Komis.Models
{
    public class MockSamochodRepository : ISamochodRepository
    {
        private List<Samochod> samochody;

        public MockSamochodRepository()
        {
            if (samochody == null)
            {
                ZaladujSamochody();
            }
        }

        private void ZaladujSamochody()
        {
            samochody = new List<Samochod>
             {
                new Samochod { Id=1, Marka="Ford", Model="Mustang", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc = "4 900 cm3", RodzajPaliwa= "benzyna", Moc = "421 KM", Opis="Mam do sprzedania Mustanga 5.0 GT V8 421KM. Kupiony w Polskim SALONIE FORDA w Opolu jako NOWY w kwietniu 2016", Cena = 160000M, ZdjecieUrl="/images/fordMustang.jpg", MiniaturkaUrl="/images/fordMustang.jpg", JestSamochodemTygodnia = true},
                new Samochod { Id=2, Marka="Audi", Model="S5", RokProdukcji = 2013, Przebieg = "112 000 km", Pojemnosc = "3 000 cm3", RodzajPaliwa= "benzyna", Moc = "280 KM", Opis="Do sprzedania Audi S5 z 2013 roku. Jestem właścicielem tego samochodu od ponad dwóch lat.", Cena = 115000M, ZdjecieUrl="/images/audiS5.jpg", MiniaturkaUrl="/images/audiS5.jpg", JestSamochodemTygodnia = true},
                new Samochod { Id=3, Marka="BMV", Model="X4", RokProdukcji = 2017, Przebieg = "4 300 km", Pojemnosc = "1 995 cm3", RodzajPaliwa= "benzyna", Moc = "190 KM", Opis="BMV X4 20d xDrive. Samochód krajowy. Samochód serwisowany. Wystawiamy fakturę VAT 23%. Samochód bezwypadkowy. I właściciel.", Cena = 194000M, ZdjecieUrl="/images/bmvx4.jpg", MiniaturkaUrl="/images/bmvx4.jpg", JestSamochodemTygodnia = true},
                new Samochod { Id=4, Marka="Chevrolet", Model="Corvette", RokProdukcji = 1972, Przebieg = "28 000 km", Pojemnosc = "5 700 cm3", RodzajPaliwa= "benzyna", Moc = "300 KM", Opis="Corvetta jest w świetnym stanie wizualnym i mechanicznym. Oczywiście jest ZAREJESTROWANA i ubezpieczona w PL.", Cena = 90000M, ZdjecieUrl="/images/chevroletCorvete.jpg", MiniaturkaUrl="/images/chevroletCorvete.jpg", JestSamochodemTygodnia = true},
                new Samochod { Id=5, Marka="Nissan", Model="Skyline", RokProdukcji = 1995, Przebieg = "144 000 km", Pojemnosc = "2 500 cm3", RodzajPaliwa= "benzyna", Moc = "410 KM", Opis="Na sprzedaż trafia moja perełka Nissan Skyline R33.Auto z Japonii sprowadzone do Szwecji, gdzie było przez wiele lat modyfikowane, uczestniczyło w zlotach, zdobywało nagrody, samochód sponsorowany latami przez Sonax Sweden.", Cena = 120000M, ZdjecieUrl="/images/nissan.jpg", MiniaturkaUrl="/images/nissan.jpg", JestSamochodemTygodnia = true},
                new Samochod { Id=6, Marka="Jaguar", Model="ZX", RokProdukcji = 2006, Przebieg = "78000 km", Pojemnosc = "5 000 cm3", RodzajPaliwa= "benzyna", Moc = "510 KM", Opis="Przedstawiam Państwu wyjątkowe auto jakim jest Jaguar XKR, a zwłaszcza ten egzemplarz. Jaguar XKR to ikona światowej i brytyjskiem motoryzacji, a przede wszystkim kontynuator legendarnego już Jaguara E-typa, przez wielu uważany za najpiękniejsze auto w historii motoryzacji.", Cena = 200000M, ZdjecieUrl="/images/jaguar.jpg", MiniaturkaUrl="/images/jaguar.jpg", JestSamochodemTygodnia = true}
            };
        }

        public Samochod PobierzSamochodOId(int samochodId)
        {
            return samochody.FirstOrDefault(s => s.Id == samochodId);
        }

        public IEnumerable<Samochod> PobierzWszystkieSamochody()
        {
            return samochody;
        }

        public void DodajSamochod(Samochod samochod)
        {
            throw new System.NotImplementedException();
        }

        public void EdytujSamochod(Samochod samochod)
        {
            throw new System.NotImplementedException();
        }

        public void UsunSamochod(Samochod samochod)
        {
            throw new System.NotImplementedException();
        }
    }
}
