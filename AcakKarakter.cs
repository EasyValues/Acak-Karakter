using System;
using System.Diagnostics;
using System.Text;

namespace Undefined
{
    class AcakKarakter
    {
        static string acakKarakter(int panjang, string values = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890")
        {
            StringBuilder psw = new StringBuilder();
            Random acak = new Random();
            while (0 < panjang--)
            {
                psw.Append(values[acak.Next(values.Length)]);
            }
            return psw.ToString();
        }
        static void Main(string[] args)
        {
            Console.Title = "Acak Karakter | By EasyValues";
            Console.Write("\n Karakter yang ingin kamu masukan: ");
            string values = Console.ReadLine();
            Console.Write("\n Panjang karakter kamu: ");
            int panjang = int.Parse(Console.ReadLine());
            int pjg = panjang; 
            Console.Write("\n Ulangi sebanyak: ");
            int jumlah = int.Parse(Console.ReadLine());
            string teracak;
            Console.WriteLine();
            for (int e = 0; e < jumlah; e++)
            {
                teracak = acakKarakter(panjang, values);
                Console.WriteLine(teracak);
            }
            Debug.WriteLine($"Karakter [{values}], sepanjang {pjg} karakter, sebanyak {jumlah} kali telah dibuat.");
            Console.ReadKey();
        }
    }
}