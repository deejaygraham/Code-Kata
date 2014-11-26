using System;
using System.Collections.Generic;

namespace NumberSpeller
{
    public static class NumberSpeller
    {
		private static Dictionary<long, string> understoodQuantities = new Dictionary<long, string>();

        const long OneMillion = 1000000;
        const long OneThousand = 1000;
        const long OneHundred = 100;
        const long Twenty = 20;

		static NumberSpeller()
		{
			understoodQuantities.Add( 0, "zero");
			understoodQuantities.Add( 1, "one");
			understoodQuantities.Add( 2, "two");
			understoodQuantities.Add( 3, "three");
			understoodQuantities.Add( 4, "four");
			understoodQuantities.Add( 5, "five");
			understoodQuantities.Add( 6, "six");
			understoodQuantities.Add( 7, "seven");
			understoodQuantities.Add( 8, "eight");
			understoodQuantities.Add( 9, "nine");
			understoodQuantities.Add(10, "ten");
			understoodQuantities.Add(11, "eleven");
			understoodQuantities.Add(12, "twelve");
			understoodQuantities.Add(13, "thirteen");
			understoodQuantities.Add(14, "fourteen");
			understoodQuantities.Add(15, "fifteen");
			understoodQuantities.Add(16, "sixteen");
			understoodQuantities.Add(17, "seventeen");
			understoodQuantities.Add(18, "eighteen");
			understoodQuantities.Add(19, "nineteen");
			understoodQuantities.Add(20, "twenty");
			understoodQuantities.Add(30, "thirty");
			understoodQuantities.Add(40, "forty");
			understoodQuantities.Add(50, "fifty");
			understoodQuantities.Add(60, "sixty");
			understoodQuantities.Add(70, "seventy");
			understoodQuantities.Add(80, "eighty");
			understoodQuantities.Add(90, "ninety");
		}

        public static string Units(this long value)
        {
            if (value >= OneMillion)
                return " million";
            else if (value >= OneThousand)
                return " thousand";
            else if (value >= OneHundred)
                return " hundred";

            return string.Empty;
        }

        public static string RemainderPrefix(this long value)
        {
            return (value >= OneHundred && value < OneThousand) ? " and " : " ";
        }

		public static string Spell(this long value)
		{
            if (understoodQuantities.ContainsKey(value))
                return understoodQuantities[value];

            if (value >= OneHundred)
            {
                long divisor = OneHundred;

                if (value >= OneMillion)
                    divisor = OneMillion;
                else if (value >= OneThousand)
                    divisor = OneThousand;

                long quotient = value / divisor;
                long remainder = value % divisor;

                string quotientInWords = Spell(quotient);
                string remainderInWords = (remainder > 0) ? value.RemainderPrefix() + Spell(remainder) : string.Empty;

                return quotientInWords + value.Units() + remainderInWords;
            }

            if (value > Twenty)
            {
                long units = value % 10;
                long tens = value - units;

                return Spell(tens) + " " + Spell(units);
            }

            throw new ArgumentOutOfRangeException("Can't spell \'" + value.ToString() + "\'");
		}
    }
}
