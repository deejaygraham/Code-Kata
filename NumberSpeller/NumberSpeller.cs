﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSpeller
{
    public static class NumberSpeller
    {
		public static string Spell(this long value)
		{
			switch (value)
			{
				case 0: return "zero";
				case 1: return "one";
				case 2: return "two";
				case 3: return "three";
				case 4: return "four";
				case 5: return "five";
				case 6: return "six";
				case 7: return "seven";
				case 8: return "eight";
				case 9: return "nine";
			}

			throw new ArgumentException(string.Format("Can't spell \'{0}\'", value));
		}
    }
}
