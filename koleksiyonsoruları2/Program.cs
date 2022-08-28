using System;
namespace koleksiyonsoruları2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar=new int[20];
            
            for(int i=0;i<20;i++)
            {
                sayilar[i]=int.Parse(Console.ReadLine());
            }
            Array.Sort(sayilar);
            foreach(var sayi in sayilar)
            {
                Console.Write(sayi+" ");
            }
            int [] ucBuyukler={sayilar[19],sayilar[18],sayilar[17]};
            int [] ucKucukler={sayilar[0],sayilar[1],sayilar[2]};
            int ucBuyukToplamı=0;
            int ucKucukToplamı=0;
            foreach(var buyukler in ucBuyukler)
            {
                ucBuyukToplamı+=buyukler;
            }
            Console.WriteLine();
            Console.WriteLine("UcBuyukler Ortalaması:"+(ucBuyukToplamı/3));
            foreach(var kucukler in ucKucukler)
            {
                ucKucukToplamı+=kucukler;
            }
            Console.WriteLine("UcKucukler Ortalaması:"+(ucKucukToplamı/3));

        }
    }
}
