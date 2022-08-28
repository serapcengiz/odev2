using System;
namespace koleksiyonsoruları3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Char> cumledekiHarfler=new List<char>();
            Console.WriteLine("Lüten bir cümle giriniz:");
            string cumle=Console.ReadLine().ToLower();

            char[] sesliHarfler={'a','e','ı','i','o','ö','u','ü'};
            
            foreach(var sesli in sesliHarfler)
            {
                if(cumle.Contains(sesli))
                {
                    cumledekiHarfler.Add(sesli);
                }
            }
            cumledekiHarfler.Sort();
            foreach(var item in cumledekiHarfler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
