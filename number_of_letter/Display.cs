using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_of_letter
{
    internal class Display
    {
        translator translator = new translator();
        internal void WelcomeScreen()
        {
            Console.WriteLine("Podaj skłowo w formacie: 13.1.14-13.1 (Jak Ja)");
            Console.WriteLine(". oznacza odzelenie znaku");
            Console.WriteLine("- lub spacja oznacza odstęp między słowami");
            string numText = Console.ReadLine();
            Console.WriteLine("Tekst został wczytany");
            finalScreen(numText, translator.init(numText));
        }

        internal void finalScreen(string s, string f)
        {
            Console.Write("*** ");
            Console.Write(s);
            Console.Write(" ***");
            Console.WriteLine();
            Console.WriteLine("Po przetłumaczeniu na polskie znaki (32)");
            Console.WriteLine();
            Console.WriteLine(f);
        }
    }
}
