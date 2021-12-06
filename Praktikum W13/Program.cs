using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_W13
{
    internal class Program
    {
        class dataorang
        {           
            static void Main(string[] args)
            {
                
                int statusprogram = 0;                              
                while (statusprogram == 0)
                {
                    
                    Console.Write("Berapa data : ");
                    int angka = Convert.ToInt32(Console.ReadLine());
                    string[,] a = new string[angka, 10];
                    for (int i = 0; i < angka; i++)
                    {
                        Console.WriteLine($"data ke - {i + 1} ");
                        Console.Write("NIM : ");
                        a[i, 0] = (Console.ReadLine());
                        Console.Write("NAMA : ");
                        a[i, 1] = (Console.ReadLine());
                        Console.Write("JENIS KELAMIN : ");
                        a[i, 2] = (Console.ReadLine());
                        Console.Write("TAHUN MASUK: ");
                        a[i, 3] = (Console.ReadLine());
                        Console.Write("PROGRAM STUDI : ");
                        a[i, 4] = (Console.ReadLine());
                        Console.Write("KELAS : ");
                        a[i, 5] = (Console.ReadLine());
                    }
                    Console.Write("PRINT HASIL ? (y/n)");
                    string print = Console.ReadLine();
                    Console.WriteLine("{0,-10} {1,-15} {2,-15} {3,-20} {4,-20} {5,-15} {6,-15}", "NO", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS");
                    if (print == "y" || print == "Y")
                    {
                        for (int i = 0; i < angka; i++)
                        {
                            Console.WriteLine("{0,-10} {1,-15} {2,-15} {3,-20} {4,-20} {5,-15} {6,-15}", (i + 1), a[i, 0], a[i, 1], a[i, 2], a[i, 3], a[i, 4], a[i, 5]);
                        }

                    }
                    Console.WriteLine("Nambah data? (y/n)");
                    string z = Console.ReadLine();
                    if (z == "n" || z == "N")
                    {
                        statusprogram = 1;
                    }
                    else if (z == "Y" || z == "y")
                    {
                        statusprogram = 0;
                    }
                }
            }
        }
    }
}
