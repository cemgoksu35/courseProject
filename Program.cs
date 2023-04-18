using System;

namespace Method2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           

            Console.WriteLine("Öğrencinin Adını Giriniz");
            string isim = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Öğrencinin Soyadını Giriniz");
            string soyisim = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Öğrencinin Numarasını Giriniz");
            string numara = Convert.ToString(Console.ReadLine());

            

            double vize1, vize2, final;
            Console.WriteLine("Lütfen 1. vize notunu giriniz");
            vize1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen 2. vize notunu giriniz");
            vize2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen Final notunu giriniz");
            final = Convert.ToDouble(Console.ReadLine());
            double Sonuc = GectiMi(vize1,vize2,final);



            BilgiGetir(isim, soyisim, numara);
            if (Sonuc<60)
            {
                Console.WriteLine($"{Sonuc} Sınıfta Kaldı");

            }
            else
            {
                Console.WriteLine($"{Sonuc} Geçti");
            }


        }
        static double GectiMi(double vize1, double vize2, double final)
        {
            double sonuc = (vize1 * 0.2) + (vize2 * 0.2) + (final * 0.6);
            return sonuc;
        }



        static void BilgiGetir(string Isim, string Soyisim, string Numara)
        {

            string metin = "Öğrencimizin Adı :" + Isim + "Soyadı :" + Soyisim + "Numarası :" + Numara ;
            Console.WriteLine(metin);
            
        }
    }
}
