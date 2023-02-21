using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    public static class SparseArrays
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            /*strings.Sort();
            var queryAndIndex = queries.Select((a, i) => new { Value = a, Index = i });

            var querySorted = queryAndIndex.OrderBy(a => a.Value).ToList();
            var queryIndex = 0;

            var result = new int[queries.Count];
            int stringIndex = 0;
            while (stringIndex < strings.Count)
            {
                if (queryIndex == queries.Count)
                    break;

                var currentString = strings[stringIndex];
                if (currentString == querySorted[queryIndex].Value)
                    result[querySorted[queryIndex].Index] += 1;

                if (currentString.CompareTo(querySorted[queryIndex].Value) == 1)
                {
                    queryIndex++;
                    continue;
                }
                stringIndex++;
            }

            return result.ToList();*/
            /*
            var queryDic = queries.ToDictionary(a=> a, a => 0);
            for (int i = 0; i < strings.Count; i++)
            {
                if (queryDic.ContainsKey(strings[i]))
                {
                    queryDic[strings[i]] += 1;
                }
            }

            return queryDic.Select(a => a.Value).ToList();*/

            List<int> res = new List<int>();
            int count = 0;
            for (int i = 0; i < queries.Count; i++)
            {
                count = 0;
                foreach (string s in strings)
                {
                    if (queries[i] == s)
                    {
                        count++;
                    }
                }
                res.Add(count);
            }
            return res;
        }

    }
    }
}
