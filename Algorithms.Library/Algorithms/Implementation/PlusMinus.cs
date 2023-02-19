using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    public static class PlusMinus
    {
        public static List<string> Calc(List<int> arr)
        {
            var positives = 0d;
            var negatives = 0d;
            var zros = 0d;
            int i = 0;
            for (i = 0; i < arr.Count; i++)
            {
                var val = arr[i];
                if (val > 0)
                    positives++;
                else if (val < 0)
                    negatives++;
                else
                    zros++;
            }

            positives = positives / i;
            negatives = negatives / i;
            zros = zros / i;

            return new List<string>
            {
                positives.ToString("f6"),
                negatives.ToString("f6"),
                zros.ToString("f6")
            };

        }
    }
}
