using System;

namespace Set1Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intoduceti un numar: ");
            int numar = int.Parse(Console.ReadLine());

            if(Estepalindrom(numar))
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este palindrom");
            }

        }
        static public bool Estepalindrom(int numar)
        {

            if (numar < 0 || numar % 10 == 0 && numar != 0)
            {
                return false;
            }
            else
            {
                int oglindit = 0;
                while (numar > oglindit)
                {
                    oglindit = oglindit * 10 + numar % 10;
                    numar /= 10;
                }

                return (oglindit == numar) || numar == oglindit / 10;
            }
        }
    }
}
