using System;
using System.Text.RegularExpressions;

namespace DesignPatternsExam1.ConsoleApp
{
    public static class ProcesadorRomano
    {
        public static int Convierte(string numerito)
        {
            var rgx = new Regex("III+|L+|D+|XXX+|CCC+");

            if (rgx.IsMatch(numerito.ToUpper()))
                throw new Exception();
            
            numerito.ToUpper().ToCharArray();
            if (string.IsNullOrEmpty(numerito))
                return 0;
            var num = GetValueOfString(numerito);
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
    }
}
