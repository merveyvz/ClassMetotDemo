using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Musteri
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public Musteri(int Id, string Name, string Surname)
        { 
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;

        }
        public string MusteriBilgileri(Musteri musteri)
        {
            return "Id: " + musteri.Id + " Adı: " + musteri.Name + " Soyadı: " + musteri.Surname;
        }

    }
}
