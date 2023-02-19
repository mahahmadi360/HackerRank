using Algorithms.Implementation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTest.Implementation
{
    public class PlusMinusTest
    {
        public PlusMinusTest()
        {
            var culture =(CultureInfo) System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
        }

        [Fact]
        public void Test1()
        {
            var result = PlusMinus.Calc(new List<int> { 1, 1, 0, -1, -1 });

            Assert.Equal("0.400000", result[0]);
            Assert.Equal("0.400000", result[1]);
            Assert.Equal("0.200000", result[2]);
        }

        [Fact]
        public void Test2()
        {
            var result = PlusMinus.Calc(new List<int> { -4, 3, -9, 0, 4, 1 });

            Assert.Equal("0.500000", result[0]);
            Assert.Equal("0.333333", result[1]);
            Assert.Equal("0.166667", result[2]);
        }
    }
}
