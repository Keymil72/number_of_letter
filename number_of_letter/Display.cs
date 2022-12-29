using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_of_letter
{
    internal class Display
    {
        Decoder decoder = new Decoder();
        Encoder encoder = new Encoder();
        Input input = new Input();

        internal void welcomeScreen()
        {
            Console.WriteLine("*** Program kodujący i dekodujący numerami odpowiednich liter alfabetu polskiego ***");
            Console.WriteLine();
            Console.WriteLine("Kliknij enter aby rozpocząć działanie programu");
            Console.ReadLine();
            choiceModeScreen();
        }
        internal void choiceModeScreen()
        {
            Console.Clear();
            Console.WriteLine("Kliknij numer odpowiadającej opcji: ");
            Console.WriteLine("1. 13.1.14-13.1 --> Jak Ja");
            Console.WriteLine();
            Console.WriteLine("2. Jak Ja --> 13.1.14-13.1");
            var choice = Console.ReadLine();
            if (choice == "1")
            {
                insertNumScreen();
            }
            else if (choice == "2")
            {
                insertTextScreen();
            }
            else
            {
                choiceModeScreen();
            }

        }
        internal void insertNumScreen()
        {
            Console.Clear();
            Console.WriteLine("Podaj skłowo w formacie: 13.1.14-13.1 (Jak Ja)");
            Console.WriteLine(". oznacza odzelenie znaku");
            Console.WriteLine("- lub spacja oznacza odstęp między słowami");
            string numText = Console.ReadLine();
            if (numText != null)
            {
                Console.WriteLine("Tekst został wczytany");
                finalDecodeScreen(numText, decoder.init(numText));
            }
            else
            {
                insertNumScreen();
            }
        }

        internal void insertTextScreen()
        {
            Console.Clear();
            Console.WriteLine("Podaj tekst do zakodowania");
            string toEncode = Console.ReadLine();
            finalEncodeScreen(toEncode, encoder.init(toEncode));

        }

        internal void finalDecodeScreen(string s, string f)
        {
            Console.Write("*** ");
            Console.Write(s);
            Console.Write(" ***");
            Console.WriteLine();
            Console.WriteLine("Po przetłumaczeniu na polskie znaki (32)");
            Console.WriteLine();
            Console.WriteLine(f);
        }

        internal void finalEncodeScreen(string s, string f)
        {
            Console.Clear();
            Console.Write("*** ");
            Console.Write(s);
            Console.Write(" ***");
            Console.WriteLine();
            Console.WriteLine("Po zakodowaniu");
            Console.WriteLine();
            Console.WriteLine(f);
        }
    }
}
