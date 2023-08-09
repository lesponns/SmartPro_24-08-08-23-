using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_24_08_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.Write("Ay:");
            input = int.Parse(Console.ReadLine());

            //1,3,5,7,10,12 31
            //4 6 8 9 11 30
            //2 28

            switch (input) 
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 10:
                case 12:
                    Console.WriteLine("Seçtiniz ayın gün sayısı: 31");
                    break;
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    Console.WriteLine("Seçtiniz ayın gün sayısı: 30");
                    break;
                case 2:
                    Console.WriteLine("Seçtiniz ayın gün sayısı: 28");
                    break;

            }
            Console.ReadKey();
        }
    }
}
