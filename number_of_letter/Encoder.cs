using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_of_letter
{
    internal class Encoder
    {
        List<char> supportList = new List<char>();
        List<string> finalList = new List<string>();
        internal string init(string s)
        {
            splitter(s);
            encode();
            return connector();
        }

        void splitter(string s)
        {
            supportList.AddRange(s);
        }

        void encode() 
        {
            foreach (var x in supportList)
            {
                switch (x)
                {
                    case ' ':
                        finalList.Add("-");
                        break;
                    case 'a':
                        finalList.Add("1.");
                        break;
                    case 'ą':
                        finalList.Add("2.");
                        break;
                    case 'b':
                        finalList.Add("3.");
                        break;
                    case 'c':
                        finalList.Add("4.");
                        break;
                    case 'ć':
                        finalList.Add("5.");
                        break;
                    case 'd':
                        finalList.Add("6.");
                        break;
                    case 'e':
                        finalList.Add("7.");
                        break;
                    case 'ę':
                        finalList.Add("8.");
                        break;
                    case 'f':
                        finalList.Add("9.");
                        break;
                    case 'g':
                        finalList.Add("10.");
                        break;
                    case 'h':
                        finalList.Add("11.");
                        break;
                    case 'i':
                        finalList.Add("12.");
                        break;
                    case 'j':
                        finalList.Add("13.");
                        break;
                    case 'k':
                        finalList.Add("14.");
                        break;
                    case 'l':
                        finalList.Add("15.");
                        break;
                    case 'ł':
                        finalList.Add("16.");
                        break;
                    case 'm':
                        finalList.Add("17.");
                        break;
                    case 'n':
                        finalList.Add("18.");
                        break;
                    case 'ń':
                        finalList.Add("19.");
                        break;
                    case 'o':
                        finalList.Add("20.");
                        break;
                    case 'ó':
                        finalList.Add("21.");
                        break;
                    case 'p':
                        finalList.Add("22.");
                        break;
                    case 'r':
                        finalList.Add("23.");
                        break;
                    case 's':
                        finalList.Add("24.");
                        break;
                    case 'ś':
                        finalList.Add("25.");
                        break;
                    case 't':
                        finalList.Add("26.");
                        break;
                    case 'u':
                        finalList.Add("27.");
                        break;
                    case 'w':
                        finalList.Add("28.");
                        break;
                    case 'y':
                        finalList.Add("29.");
                        break;
                    case 'z':
                        finalList.Add("30.");
                        break;
                    case 'ź':
                        finalList.Add("31.");
                        break;
                    case 'ż':
                        finalList.Add("32.");
                        break;
                    default:
                        finalList.Add(x.ToString());
                        break;

                }
            }
        }

        string connector()
        {
            string finalString = "";
            foreach (var x in finalList)
            {
                finalString += x;
            }
            return finalString;
        }
    }
}
