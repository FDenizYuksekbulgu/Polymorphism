using Polymorphism;
class Program
{
    public static void Main(string[] args)
    {

    //KARE ÖRNEĞİ
     BaseGeometrikSekil kare = new Kare { Genislik = 4, Yukseklik = 4 };
    Console.WriteLine($"Karenin alanı: {kare.Alan(kare.Genislik, kare.Yukseklik)}");

    //DİKDÖRTGEN ÖRNEĞİ
            BaseGeometrikSekil dikdortgen = new Dikdörtgen { Genislik = 5, Yukseklik = 10 };
    Console.WriteLine($"Dikdörtgenin alanı: {dikdortgen.Alan(dikdortgen.Genislik, dikdortgen.Yukseklik)}");


    //ÜÇGEN ÖRNEĞİ
            BaseGeometrikSekil ucgen = new Üçgen { Genislik = 6, Yukseklik = 8 };
    Console.WriteLine($"Üçgenin alanı: {ucgen.Alan(ucgen.Genislik, ucgen.Yukseklik)}");
        }

}



