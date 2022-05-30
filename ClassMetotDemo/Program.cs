
using ClassMetotDemo;

class Program
{
    static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri(1, "Merve", "Yavuz");
        Musteri musteri2 = new Musteri(2, "Nilüfer", "Saklavcı");
        Musteri musteri3 = new Musteri(3, "Betül", "Şentürk");

        MusteriManager musteriManager = new MusteriManager();

        musteriManager.Ekle(musteri1, musteri2, musteri3);

        musteriManager.Sil(musteri1, musteri2);
        musteriManager.Listele();


        
    }
}
