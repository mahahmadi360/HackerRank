using Algorithms.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTest.Implementation
{
    public class SparseArraysTest
    {
        [Fact]
        public void Test()
        {
            var inputs = new List<string> { "3", "def", "de", "fgh", "3" };
            var queries = new List<string> { "de", "lmn", "fgh" };

            var result = SparseArrays.matchingStrings(inputs, queries);
            var expectedResult = new List<int> { 1, 0, 1 };

            Assert.Equal(string.Join(",", expectedResult), string.Join(",", result));
        }
        [Fact]
        public void Test2()
        {
            var inputs = new List<string> { "13",
                "abcde",
                "sdaklfj",
                "asdjf",
                "na",
                "basdn",
                "sdaklfj",
                "asdjf",
                "na",
                "asdjf",
                "na",
                "basdn",
                "sdaklfj",
                "asdjf",
                "5" };
            var queries = new List<string> {"abcde",
                "sdaklfj",
                "asdjf",
                "na",
                "basdn" };

            var result = SparseArrays.matchingStrings(inputs, queries);
            var expectedResult = new List<int> { 1, 3, 4, 3, 2 };

            Assert.Equal(string.Join(",", expectedResult), string.Join(",", result));


        }

        

    }
}
