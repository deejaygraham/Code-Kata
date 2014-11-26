using System;
using Xunit;

namespace NumberSpeller.Tests
{
	public class NumberSpellerTests
	{
		[Fact]
		public void Spelling_Nothing_Returns_Zero()
		{
            AssertSpelling(0, "zero");
		}

        [Fact]
		public void Spelling_1_Returns_One()
		{
            AssertSpelling(1, "one");
		}

        [Fact]
		public void Spelling_2_Returns_Two()
		{
            AssertSpelling(2, "two");
		}

        [Fact]
		public void Spelling_10_Returns_Ten()
		{
            AssertSpelling(10, "ten");
		}

        [Fact]
		public void Spelling_15_Returns_Fifteen()
		{
            AssertSpelling(15, "fifteen");
		}

        [Fact]
        public void Spelling_21_Returns_Twenty_Space_One()
        {
            AssertSpelling(21, "twenty one");
        }

        [Fact]
        public void Spelling_99_Returns_Ninety_Space_Nine()
        {
            AssertSpelling(99, "ninety nine");
        }

        [Fact]
        public void Spelling_300_Returns_Three_Space_Hundred()
        {
            AssertSpelling(300, "three hundred");
        }

        [Fact]
        public void Spelling_310_Returns_Three_Space_Hundred_Space_And_Space_Ten()
        {
            AssertSpelling(310, "three hundred and ten");
        }

        [Fact]
        public void Spelling_1501_Returns_OneThousand_Five_Hundred_And_One()
        {
            AssertSpelling(1501, "one thousand five hundred and one");
        }

        [Fact]
        public void Spelling_12609_Returns_Twelve_Thousand_Six_Hundred_And_Nine()
        {
            AssertSpelling(12609, "twelve thousand six hundred and nine");
        }

        [Fact]
        public void Spelling_512607_Returns_Five_Hundred_And_Twelve_Thousand_Six_Hundred_And_Seven()
        {
            AssertSpelling(512607, "five hundred and twelve thousand six hundred and seven");
        }

        private void AssertSpelling(long value, string text)
        {
            Assert.Equal(text, value.Spell());
        }
	}
}
