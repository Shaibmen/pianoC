using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PianoC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Переключение между октавами: F3, F6");
            ConsoleKeyInfo usersKey = Console.ReadKey();


            Zvuk(octava(usersKey));


        }

        public static int[] octava(ConsoleKeyInfo usersKey)
        {
            
            int[] Noresult = new int[0];
            
            if (usersKey.Key == ConsoleKey.F3)
            {
                int[] ThreeOct = new int[12] { 220, 233, 247, 131, 139, 147, 157, 165, 175, 185, 196, 208 };
                int[] massiveOct = ThreeOct.Where(item => item != 1).ToArray();
                return massiveOct;
            }
            
            if (usersKey.Key == ConsoleKey.F6)
            {
                int[] SixOct = new int[12] { 1760, 1865, 1976, 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661 };
                int[] massiveOct = SixOct.Where(item => item != 1).ToArray();
                return massiveOct;
            }
            
            return Noresult;
        }

        public static void Zvuk(int[] massiveOct)
        {
            bool IsDone = true;
            while (IsDone != false)
            {


 

                ConsoleKeyInfo usersKey = Console.ReadKey();

                if (usersKey.Key == ConsoleKey.F3)
                {
                    Zvuk(octava(usersKey));
                    Console.WriteLine("3 октава");
                }


                if (usersKey.Key == ConsoleKey.F6)
                {
                    Zvuk(octava(usersKey));
                    Console.WriteLine("6 октава");
                }

                if (usersKey.Key == ConsoleKey.A)
                {
                    Console.Beep(massiveOct[0], 100);
                    Console.Clear();
                }

                if (usersKey.Key == ConsoleKey.W)
                {
                    Console.Beep(massiveOct[1], 100);
                    Console.Clear();
                }

                if (usersKey.Key == ConsoleKey.S)
                {
                    Console.Beep(massiveOct[2], 100);
                    Console.Clear();
                }

                if (usersKey.Key == ConsoleKey.D)
                {
                    Console.Beep(massiveOct[3], 100);
                    Console.Clear();
                }

                if (usersKey.Key == ConsoleKey.E)
                {
                    Console.Beep(massiveOct[4], 100);
                    Console.Clear();
                }

                if (usersKey.Key == ConsoleKey.F)
                {
                    Console.Beep(massiveOct[5], 100);
                    Console.Clear();
                }

                if (usersKey.Key == ConsoleKey.R)
                {
                    Console.Beep(massiveOct[6], 100);
                    Console.Clear();
                }

                if (usersKey.Key == ConsoleKey.G)
                {
                    Console.Beep(massiveOct[7], 100);
                    Console.Clear();
                }

                if (usersKey.Key == ConsoleKey.H)
                {
                    Console.Beep(massiveOct[8], 100);
                    Console.Clear();
                }

                if (usersKey.Key == ConsoleKey.Y)
                {
                    Console.Beep(massiveOct[9], 100);
                    Console.Clear();
                }

                if (usersKey.Key == ConsoleKey.J)
                {
                    Console.Beep(massiveOct[10], 10);
                    Console.Clear();
                }

                if (usersKey.Key == ConsoleKey.U)
                {
                    Console.Beep(massiveOct[11], 10);
                    Console.Clear();
                }



               

                if (usersKey.Key == ConsoleKey.Escape)
                {
                    IsDone = false;
                    break;
                }
            }
        }

    }
}
