using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DesignPatternsExam1.ConsoleApp
{
    public static class ProcesadorRomano
    {
        public static int Convierte(string numerito)
        {
            if (!IsValidString(numerito))
                return 0;

            var num = GetValue(numerito);
            return num;
        }

        private static int GetValueOfString(string numerito)
        {
            switch (numerito)
            {
                case "I":
                    return 1;
                case "II":
                    return 2;
                case "III":
                    return 3;
                case "V":
                    return 5;
                case "X":
                    return 10;
                case "L":
                    return 50;
                case "C":
                    return 100;
                case "D":
                    return 500;
                case "M":
                    return 1000;
            }
            return 0;
        }

        private static bool IsValidString(string numerito)
        {
            var rgx = new Regex("III+|L+|D+|XXX+|CCC+");

            if (rgx.IsMatch(numerito.ToUpper()))
                throw new Exception();
            return !string.IsNullOrEmpty(numerito);
        }

        private static int GetValue(string numerito)
        {
            var letters = numerito.ToCharArray();
            var accountLetters = letters.Length;
            var listOfValues = new List<int>();

            for (var i = 0; i < accountLetters; i++)
            {
                var cantToSend = 1;

                if (GetValueOfString(numerito.Substring(i, cantToSend)) == 1 && i + 1 < accountLetters)
                {
                    cantToSend++;
                    GetValueOfString(numerito.Substring(i, cantToSend));
                    if (GetValueOfString(numerito.Substring(i, cantToSend)) == 1 && i + 1 < accountLetters)
                    {
                        cantToSend++;
                    }
                }
                var value = GetValueOfString(numerito.Substring(i, cantToSend));
                var badLocation = listOfValues.FirstOrDefault(x => x > value);
                if (badLocation != 0)
                    throw new Exception();
                listOfValues.Add(value);
            }

            return listOfValues.Sum();
        }
    }
}
