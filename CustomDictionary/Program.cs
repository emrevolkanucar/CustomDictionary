using System;

namespace CustomDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            EvuDict<string, int> plakaKodlari = new EvuDict<string, int>();
            plakaKodlari.Add("İstanbul", 34);
            plakaKodlari.Add("Ankara", 06);
            plakaKodlari.Add("İzmir", 35);

            Console.WriteLine("Şehir: " + plakaKodlari.Keys[0] + " | İl Plaka Kodu: " + plakaKodlari.Values[0]  );
        }
    }
}
