using System;
using System.Collections;
namespace koeleksiyonsoruları1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalOlan = new ArrayList();
            ArrayList asalDegil = new ArrayList();
            int asalToplam=0;
            int asalOlmayanToplam=0;
            int sayi=0;
            for(int i=0;i<20;i++)
            {
                sayi=int.Parse(Console.ReadLine());
                if(sayi<0)
                {
                    Console.WriteLine("Lütfen pozitif bir tam sayı giriniz");
                    sayi=int.Parse(Console.ReadLine());
                }
                int sonuc = AsalMi(sayi);
                if (sonuc == 0)
                {
                    asalDegil.Add(sayi);
                    asalToplam+=sayi;
                }
                else
                {
                    asalOlan.Add(sayi);
                    asalOlmayanToplam+=sayi;
                }
            }
            Console.WriteLine("Asal Sayılar:");
            foreach(var asal in asalOlan)
            {
                Console.Write(asal+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Asal Olmayan Sayılar:");
            foreach(var asalolmayan in asalDegil)
            {
                Console.Write(asalolmayan+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Asal Olan Sayıların Büyükten Küçüğe sıralanması:");
            asalOlan.Sort();
            asalOlan.Reverse();
            foreach(var asal in asalOlan)
            {
                Console.Write(asal+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Asal Olmayan Sayıların Büyükten Küçüğe sıralanması:");
            asalDegil.Sort();
            asalDegil.Reverse();
            foreach(var asalolmayan in asalDegil)
            {
                Console.Write(asalolmayan+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Asal Olan Sayıların Sayısı:"+asalOlan.Count);
            Console.WriteLine("Asal Olan Sayıların Ortalaması:"+asalToplam/asalOlan.Count);
            Console.WriteLine("Asal Olmayan Sayıların Sayısı:"+asalDegil.Count);
            Console.WriteLine("Asal Olmayan Sayıların Ortalaması:"+asalOlmayanToplam/asalDegil.Count);


            
        }
        public static int AsalMi(int sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    return 0;
                }
            }
            if (i == sayi)
            {
                return 1;
            }
            return 0;

        }
    }
}
