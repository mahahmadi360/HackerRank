using Algorithms.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTest.Implementation
{
    public class ArrayManipulationTest
    {
        [Fact]
        public void Test3()
        {
            int n = 10;
            var queries = new List<List<int>>
            {
                new List<int>{2 ,6, 8 },
                new List<int>{3 ,5, 7},
                new List<int>{1 ,8, 1},
                new List<int>{5 ,9, 15}
            };

            var result = ArrayManipulation.arrayManipulation(n, queries);
            Assert.Equal(31, result);
        }
    }
}
