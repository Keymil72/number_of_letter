using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_of_letter
{
    internal class translator
    {
        List<string> finalList = new List<string>();
        List<string> supportList; 

        internal string init(string s)
        {
            splitter(s);
            translate();
            return connector();
        }

        internal void splitter(string s)
        {
            s = s.Replace(" ", ".-.").Replace("-", ".-.");
            supportList = new List<string>(s.Split('.').ToList());

        }
        internal void translate()
        {
            foreach (var x in supportList)
            {
                switch (x)
                {
                    case "-":
                        finalList.Add(" ");
                        break;
                    case "1":
                        finalList.Add("a");
                        break;
                    case "2":
                        finalList.Add("ą");
                        break;
                    case "3":
                        finalList.Add("b");
                        break;
                    case "4":
                        finalList.Add("c");
                        break;
                    case "5":
                        finalList.Add("ć");
                        break;
                    case "6":
                        finalList.Add("d");
                        break;
                    case "7":
                        finalList.Add("e");
                        break;
                    case "8":
                        finalList.Add("ę");
                        break;
                    case "9":
                        finalList.Add("f");
                        break;
                    case "10":
                        finalList.Add("g");
                        break;
                    case "11":
                        finalList.Add("h");
                        break;
                    case "12":
                        finalList.Add("i");
                        break;
                    case "13":
                        finalList.Add("j");
                        break;
                    case "14":
                        finalList.Add("k");
                        break;
                    case "15":
                        finalList.Add("l");
                        break;
                    case "16":
                        finalList.Add("ł");
                        break;
                    case "17":
                        finalList.Add("m");
                        break;
                    case "18":
                        finalList.Add("n");
                        break;
                    case "19":
                        finalList.Add("ń");
                        break;
                    case "20":
                        finalList.Add("o");
                        break;
                    case "21":
                        finalList.Add("ó");
                        break;
                    case "22":
                        finalList.Add("p");
                        break;
                    case "23":
                        finalList.Add("r");
                        break;
                    case "24":
                        finalList.Add("s");
                        break;
                    case "25":
                        finalList.Add("ś");
                        break;
                    case "26":
                        finalList.Add("t");
                        break;
                    case "27":
                        finalList.Add("u");
                        break;
                    case "28":
                        finalList.Add("w");
                        break;
                    case "29":
                        finalList.Add("y");
                        break;
                    case "30":
                        finalList.Add("z");
                        break;
                    case "31":
                        finalList.Add("ź");
                        break;
                    case "32":
                        finalList.Add("ź");
                        break;
                default:
                        finalList.Add("?");
                        break;

                }
            }
        }

        internal string connector()
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
