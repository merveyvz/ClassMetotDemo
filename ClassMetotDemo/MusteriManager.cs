using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        List<Musteri> musteriList = new List<Musteri> { };

        public void Ekle(params Musteri[] musteriler)
        {
            
            foreach (Musteri musteri in musteriler)
            {
                musteriList.Add(musteri);
                Console.WriteLine(musteri.Name + " " + musteri.Surname+ " Eklendi\n");
            }
            

        }

        public void Sil(params Musteri[] musteriler)
        {
            foreach(Musteri musteri in musteriler)
            {
                if (musteriList.Contains(musteri)) {
                    musteriList.Remove(musteri);
                    Console.WriteLine(musteri.Name + " " + musteri.Surname + " Silindi\n");
                }
                else
                    Console.WriteLine("Müşteri bulunamadı\n");
            }
            
            
        }

        public void Listele()
        {
            if (musteriList.Count != 0)
            {
                Console.WriteLine("Müşteri Listesi\n-----------------");
                foreach (Musteri musteri in musteriList)
                    Console.WriteLine(musteri.MusteriBilgileri(musteri));
            }
            else
                Console.WriteLine("Müşteri Listesi Boş\n");
                

        }
    }
}
