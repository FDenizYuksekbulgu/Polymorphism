
using System;

namespace Polymorphism
{
    public class BaseGeometrikSekil
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public virtual int Alan(int genislik, int yukseklik)
        {
           return genislik * yukseklik;   
        }

    }
    //KARE
    public class Kare:BaseGeometrikSekil
    {
        public override int Alan(int genislik, int yukseklik)
        {
            return genislik * yukseklik; //Karenin alanı hesaplanır.
        }
    }
    //DİKDÖRTGEN
    public class Dikdörtgen  : BaseGeometrikSekil
    {
        public override int Alan(int genislik, int yukseklik)
        {
            return genislik * yukseklik; //Dikdörtgenin alanı hesaplanır.
        }
    }
    //ÜÇGEN
    public class Üçgen : BaseGeometrikSekil
    {
        public override int Alan(int genislik, int yukseklik)
        {
            return (genislik + yukseklik) / 2; //Üçgenin alanı hesaplanır.
        }
    }
}



  

 