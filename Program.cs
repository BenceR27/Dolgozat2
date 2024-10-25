using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat2
{
    internal class Program
    {
        static void jelszoellenorzes()
        {
            string jelszo;

            while (true)
            {
                Console.WriteLine("Kérlek, add meg a jelszót:");
                jelszo = Console.ReadLine();

                if (JoJelszo(jelszo))
                {
                    Console.WriteLine("Jelszó elfogadva!");
                    break;
                }
                else
                {
                    Console.WriteLine("A jelszónak legalább 8 karakter hosszúnak kell lennie, tartalmaznia kell egy nagybetűt és egy számot.");
                }
            }
        }

        static bool JoJelszo(string jelszo)
        {
            if (jelszo.Length < 8) return false;

            bool nagy = false, szam = false;

            foreach (char c in jelszo)
            {
                if (char.IsUpper(c)) nagy = true;
                if (char.IsDigit(c)) szam = true;
            }

            return nagy && szam;
        }

        static void Main(string[] args)
        {
            jelszoellenorzes();
        }
    }
}
