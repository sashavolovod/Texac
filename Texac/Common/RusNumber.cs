using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.Common
{
    public static class RusNumber
    {
        public enum Gender { Masculine, Feminine, Neuter };

        private static readonly string[] _frac20Masculine =
            new[]
            {
                "", "один", "два", "три", "четыре", "пять", "шесть",
                "семь", "восемь", "девять", "десять", "одиннадцать",
                "двенадцать", "тринадцать", "четырнадцать", "пятнадцать",
                "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"
            };

        private static readonly string[] _frac20Feminine =
            new[]
            {
                "", "одна", "две", "три", "четыре", "пять", "шесть",
                "семь", "восемь", "девять", "десять", "одиннадцать",
                "двенадцать", "тринадцать", "четырнадцать", "пятнадцать",
                "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"
            };

        private static readonly string[] _frac20Neuter =
            new[]
            {
                "", "одно", "два", "три", "четыре", "пять", "шесть",
                "семь", "восемь", "девять", "десять", "одиннадцать",
                "двенадцать", "тринадцать", "четырнадцать", "пятнадцать",
                "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"
            };

        private static readonly string[] _hunds =
            {
                "", "сто", "двести", "триста", "четыреста",
                "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот"
            };

        private static readonly string[] _tens =
            {
                "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят",
                "шестьдесят", "семьдесят", "восемьдесят", "девяносто"
            };

        public static string RusSpelledOut(
            this decimal value,
            Gender gender)
        {
            if (value >= 1000000000000000)
                throw new ArgumentOutOfRangeException("value");

            var str = new StringBuilder();

            if (value < 0)
            {
                str.Append("минус");
                value = -value;
            }

            value = value
                .AppendPeriod(1000000000000, str, "триллион", "триллиона", "триллионов", RusNumber.Gender.Masculine)
                .AppendPeriod(1000000000, str, "миллиард", "миллиарда", "миллиардов", RusNumber.Gender.Masculine)
                .AppendPeriod(1000000, str, "миллион", "миллиона", "миллионов", RusNumber.Gender.Masculine)
                .AppendPeriod(1000, str, "тысяча", "тысячи", "тысяч", RusNumber.Gender.Feminine);

            var hundreds = (int)(value / 100);
            if (hundreds != 0)
                str.AppendWithSpace(_hunds[hundreds]);

            var less100 = (int)(value % 100);
            string[] frac20;

            switch (gender)
            {
                case Gender.Masculine:
                    frac20 = _frac20Masculine;
                    break;
                case Gender.Feminine:
                    frac20 = _frac20Feminine;
                    break;
                default:
                    frac20 = _frac20Neuter;
                    break;
            }


            if (less100 < 20)
                str.AppendWithSpace(frac20[less100]);
            else
            {
                var tens = less100 / 10;
                str.AppendWithSpace(_tens[tens]);
                var less10 = less100 % 10;
                if (less10 != 0)
                    str.Append(" " + frac20[less100 % 10]);
            }

            return str.ToString();
        }

        private static void AppendWithSpace(this StringBuilder stringBuilder, string str)
        {
            if (stringBuilder.Length > 0)
                stringBuilder.Append(" ");
            stringBuilder.Append(str);
        }

        private static decimal AppendPeriod(
            this decimal value,
            long power,
            StringBuilder str,
            string declension1,
            string declension2,
            string declension5,
            Gender gender)
        {
            var thousands = (int)(value / power);
            if (thousands > 0)
            {
                str.AppendWithSpace(
                    ((decimal)thousands).RusSpelledOut(gender, declension1, declension2, declension5));
                return value % power;
            }
            return value;
        }

        public static string RusSpelledOut(
            this decimal value,
            Gender gender,
            string valueDeclensionFor1,
            string valueDeclensionFor2,
            string valueDeclensionFor5)
        {
            return
                RusSpelledOut(value, gender)
                    + " "
                    + ((int)(value % 10)).GetDeclension(valueDeclensionFor1, valueDeclensionFor2, valueDeclensionFor5);
        }

        public static string GetDeclension(this int val, string one, string two, string five)
        {
            var t = (val % 100 > 20) ? val % 10 : val % 20;

            switch (t)
            {
                case 1:
                    return one;
                case 2:
                case 3:
                case 4:
                    return two;
                default:
                    return five;
            }
        }
    }
}
