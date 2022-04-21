using System.Text;

namespace ExtensionMethods_Ex._8._3
{
    public class NumberToText
    {
        public StringBuilder ToText(long number)
        {
            
            if (number == 0)
                return new StringBuilder("zero");

            if (number < 0)
            {
                var builder = new StringBuilder("minus ");
                builder.Append(ToText(Math.Abs(number)));
                return builder;
            }

            var words = new StringBuilder("");
            if ((number / 1000000000000000000) > 0)
            {
                words.Append(ToText(number / 1000000000000000000));
                words.Append(" quintillion "); 
                number %= 1000000000000000000;
            }
            if ((number / 1000000000000000) > 0)
            {
                words.Append(ToText(number / 1000000000000000));
                words.Append(" quadrillion ");
                number %= 1000000000000000;
            }
            if ((number / 1000000000000) > 0)
            {
                words.Append(ToText(number / 1000000000000));
                words.Append(" trillion ");
                number %= 1000000000000;
            }
            if ((number / 1000000000) > 0)
            {
                words.Append(ToText(number / 1000000000));
                words.Append(" billion ");
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words.Append(ToText(number / 1000000));
                words.Append(" million ");
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {

                words.Append(ToText(number / 1000));
                words.Append(" thousand ");
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words.Append(ToText(number / 100));
                words.Append(" hundred ");
                number %= 100;
            }

            if (number > 0)
            {
                if (!words.Equals(""))
                    words.Append("and ");

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words.Append(unitsMap[number]);
                else
                {
                    words.Append(tensMap[number / 10]);
                    if ((number % 10) > 0)
                        words.Append( "-" + unitsMap[number % 10]);
                }
            }

            return words;
        }
    }
    public static class StringExtension
    {
        public static string ToText(this long num)
        {
            var numberText = new NumberToText();
            return numberText.ToText(num).ToString();
        }
    }

   

}
