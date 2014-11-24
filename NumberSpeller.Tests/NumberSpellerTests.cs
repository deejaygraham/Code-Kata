using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberSpeller.Tests
{
	[TestClass]
	public class NumberSpellerTests
	{
		[TestMethod]
		public void Spelling_Nothing_Returns_Zero()
		{
			long zero = 0;

			Assert.AreEqual("zero", zero.Spell());
		}

		[TestMethod]
		public void Spelling_1_Returns_One()
		{
			long one = 1;

			Assert.AreEqual("one", one.Spell());
		}

		[TestMethod]
		public void Spelling_2_Returns_Two()
		{
			long two = 2;

			Assert.AreEqual("two", two.Spell());
		}

	}

}
