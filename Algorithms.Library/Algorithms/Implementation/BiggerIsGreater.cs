using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    public static class BiggerIsGreater
    {
        public static string biggerIsGreater(string word)
        {
            int i;
            var w = word.ToArray();
            for (i = w.Length - 1; i > 0; i--)
            {
                if (w[i].CompareTo(w[i - 1]) > 0)
                    break;
            }

            if (i == 0)
                return "no answer";

            var replacement = w[i - 1];

            var replaceValueInd = i;
            for (int j = i; j < w.Length; j++)
            {
                if (w[j].CompareTo(w[replaceValueInd]) < 0
                    && w[j].CompareTo(replacement) > 0)
                    replaceValueInd = j;
            }

            w[i - 1] = w[replaceValueInd];
            w[replaceValueInd] = replacement;

            Array.Sort(w, i, w.Length - i, new Comparer());
            //w = w.Take(i).Concat(w.Skip(i).Order()).ToArray();
            return string.Join("", w);
        }
        public class Comparer : IComparer<char>
        {
            public int Compare(char x, char y)
            {
                return x.CompareTo(y);
            }
        }
    }
}
