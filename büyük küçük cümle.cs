using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Cümleyi Büyültmek için 1e\nKüçültmek için 2ye basınız:");
                byte secim = Convert.ToByte(Console.ReadLine());
                Console.Clear();
                if (secim == 1)
                {
                    Console.Write("büyültmek istediğiniz cümleyi giriniz: ");
                    string properString = Convert.ToString(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(properString.ToUpper());

                }
                else if (secim == 2)
                {
                    Console.Write("küçültmek istediğiniz cümleyi giriniz: ");
                    string properString = Convert.ToString(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(properString.ToLower());

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YANLIŞ SEÇİM!!!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YANLIŞ SEÇİM!!!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("YANLIŞ SEÇİM!!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("YANLIŞ SEÇİM!!!");
                }
            }
        }
    }
}
