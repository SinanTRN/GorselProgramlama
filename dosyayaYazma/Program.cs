using System.Text.Json;
using System.Text;

namespace dosyayaYazma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Yazmak istediğiniz metni giriniz: ");
            //string yazilacak = Console.ReadLine();
            //File.WriteAllText("yazilan.txt", yazilacak, Encoding.UTF8);
            //var cumleler=File.ReadAllText("yazilan.txt").Trim().Split(".");
            //if (cumleler.Last<string>() == "")
            //    Console.WriteLine(cumleler[cumleler.Length - 2]);
            //else
            //    Console.WriteLine(cumleler[cumleler.Length - 1]);
            bool devam = true;
            int secim;
            string yazilacak="";
            while (devam)
            {
                Console.Write("1. dosyaya yaz\n2.Son Satırı getir\n3.bitir\n");
                Console.Write("Lütfen ne yapmak istediğinizi giriniz: ");
                secim=Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.Write("Yazmak istediğiniz metni giriniz: ");
                        yazilacak = yazilacak+"\n"+Console.ReadLine();
                        break;
                    case 2:
                        File.WriteAllText("yazilan.txt", yazilacak, Encoding.UTF8);
                        var cumleler = File.ReadAllText("yazilan.txt").Trim().Split("\n");
                        if (cumleler.Last<string>() == "")
                            Console.WriteLine(cumleler[cumleler.Length - 2]);
                        else
                            Console.WriteLine(cumleler[cumleler.Length - 1]);
                        break;
                    case 3:
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Yanlış sayı girdiniz...");
                        break;

                }
            }

        }
    }
}
