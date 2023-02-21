using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    public static class ArrayManipulation
    {
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            var result = new long[n];

            for (var i = 0; i < queries.Count; i++)
            {
                result[queries[i][0] - 1] += queries[i][2];
                if (queries[i][1] < n)
                    result[queries[i][1]] -= queries[i][2];
            }

            var sum = 0l;
            var greatestValue = 0l;
            for (var i = 0; i < n; i++)
            {
                sum += result[i];
                if (sum > greatestValue)
                    greatestValue = sum;
            }
            return greatestValue;
        }
    }
}
