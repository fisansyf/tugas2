using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator Sederhana\n");

            Console.WriteLine("[1]Penjumlahan");
            Console.WriteLine("[2]Pengurangan");
            Console.WriteLine("[3]Perkalian");
            Console.WriteLine("[4]Pembagian");

            double nilai1, nilai2, hasil;
            int angka;
            Console.WriteLine();
            Console.Write("Pilih operasi yang ingin digunakan : ");
            angka = int.Parse(Console.ReadLine());
            Console.WriteLine();


            if (angka > 0 && angka <= 4)
            {
                switch (angka)
                {
                    case 1:

                        Console.WriteLine("Anda masuk ke operasi penjumlahan");
                        Console.Write("Masukkan nilai pertama   : ");
                        nilai1 = double.Parse(Console.ReadLine());

                        Console.Write("Masukkan nilai kedua     : " );
                        nilai2 = double.Parse(Console.ReadLine());

                        hasil = nilai1 + nilai2;
                            Console.WriteLine("Hasil    : " + nilai1 + " + " + nilai2 + " = " + hasil);
                        break;
                    case 2:
                        Console.WriteLine("Anda masuk ke operasi pengurangan");
                        Console.Write("Masukkan nilai pertama   : ");
                        nilai1 = double.Parse(Console.ReadLine());

                        Console.Write("Masukkan nilai kedua     : ");
                        nilai2 = double.Parse(Console.ReadLine());

                        hasil = nilai1 - nilai2;
                        Console.WriteLine("Hasil    : " + nilai1 + " - " + nilai2 + " = " + hasil);
                        break;
                    case 3:
                        Console.WriteLine("Anda masuk ke perasi perkalian");
                        Console.Write("Masukkan nilai pertama   : ");
                        nilai1 = double.Parse(Console.ReadLine());

                        Console.Write("Masukkan nilai kedua     : ");
                        nilai2 = double.Parse(Console.ReadLine());

                        hasil = nilai1 * nilai2;
                        Console.WriteLine("Hasil    : " + nilai1 + " x " + nilai2 + " = " + hasil);
                        break;
                    case 4:
                        Console.WriteLine("Anda masuk ke operasi pembagian");
                        Console.Write("Masukkan nilai pertama   : ");
                        nilai1 = double.Parse(Console.ReadLine());

                        Console.Write("Masukkan nilai kedua     : ");
                        nilai2 = double.Parse(Console.ReadLine());

                        hasil = nilai1 / nilai2;
                        Console.WriteLine("Hasil    : " + nilai1 + " / " + nilai2 + " = " + hasil);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Tidak ada opsi ke " + angka + " pada menu pilihan kami");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }
    }
}
