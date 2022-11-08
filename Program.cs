using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceas_binar
{
    internal class Program
    {
        static void Main()
        {
            int ora1, ora2, min1, min2, sec1, sec2;
            DateTime date = DateTime.Now;

            ora1 = int.Parse(date.ToString("HH")) / 10;
            ora2 = int.Parse(date.ToString("HH")) % 10;
            min1 = int.Parse(date.ToString("mm")) / 10;
            min2 = int.Parse(date.ToString("mm")) % 10;
            sec1 = int.Parse(date.ToString("ss")) / 10;
            sec2 = int.Parse(date.ToString("ss")) % 10;


            int[] h1, h2, m1, m2, s1, s2;
            h1 = new int[2] { 0, 0 };
            h2 = new int[4] { 0, 0, 0, 0 };
            m1 = new int[3] { 0, 0, 0 };
            m2 = new int[4] { 0, 0, 0, 0 };
            s1 = new int[3] { 0, 0, 0 };
            s2 = new int[4] { 0, 0, 0, 0 };

            for (int i = 0; i < 4; i++)
            {
                h2[i] = ora2 % 2;
                ora2 /= 2;
                m2[i] = min2 % 2;
                min2 /= 2;
                s2[i] = sec2 % 2;
                sec2 /= 2;
            }
            for (int i = 0; i < 3; i++)
            {
                m1[i] = min1 % 2;
                min1 /= 2;
                s1[i] = sec1 % 2;
                sec1 /= 2;
            }
            for (int i = 0; i < 2; i++)
            {
                h1[i] = ora1 % 2;
                ora1 /= 2;
            }
            for (int i = 3; i >= 0; i--) 
            {
                if(i < 3)
                {
                    if (i < 2)
                        Console.WriteLine(h1[i] + " " + h2[i] + " | " + m1[i] + " " + m2[i] + " | " + s1[i] + " " + s2[i]);
                    else
                        Console.WriteLine( "  " + h2[i] + " | " + m1[i] + " " + m2[i] + " | " + s1[i] + " " + s2[i]);
                }
                else
                {
                    Console.WriteLine("  " + h2[i] + " | " + "  " + m2[i] + " | " + "  " + s2[i]);
                }
            }
            Console.WriteLine();
            Console.Write(int.Parse(date.ToString("HH")) / 10 + " " + int.Parse(date.ToString("HH")) % 10 + " : ");
            Console.Write(int.Parse(date.ToString("mm")) / 10 + " " + int.Parse(date.ToString("mm")) % 10 + " : ");
            Console.WriteLine(int.Parse(date.ToString("ss")) / 10 + " " + int.Parse(date.ToString("ss")) % 10);
            Console.ReadKey();
            Console.WriteLine();
            Main();
        }
    }
}
