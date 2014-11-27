﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStats
{
    public class NumberStats
    {
        public int Minimum { get; private set; }

        public int Maximum { get; private set; }

        public int Count { get; private set; }

        public double Average  { get; private set; }

        public void Calculate(string delimitedText)
        {
            Calculate(delimitedText.Split(','));
        }

        public void Calculate(IEnumerable<string> values)
        {
            var intValues = new List<int>();

            foreach (string value in values)
            {
                intValues.Add(Convert.ToInt32(value, 10);
            }

            Calculate(intValues);
        }

        public void Calculate(IEnumerable<int> values)
        {
            this.Count = values.Count();
            this.Minimum = this.FindMinimum(values);
            this.Maximum = this.FindMaximum(values);
            this.Average = this.CalculateAverage(values);
        }

        private double CalculateAverage(IEnumerable<int> values)
        {
            double sum = 0;

            foreach (int value in values)
            {
                sum += value;
            }

            // or values.Average();
            return sum / values.Count();
        }

        private int FindMinimum(IEnumerable<int> values)
        {
            int minValue = Int32.MaxValue;

            foreach (int value in values)
            {
                minValue = Math.Min(minValue, value);
            }

            // or minValue = values.Min();

            return minValue;
        }

        private int FindMaximum(IEnumerable<int> values)
        {
            int maxValue = Int32.MinValue;
                        
            foreach(int value in values)
            {
                maxValue = Math.Max(maxValue, value);
            }

            // or maxValue = values.Max();

            return maxValue;
        }

    }
}
