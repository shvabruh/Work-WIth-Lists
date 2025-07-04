using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Work_With_Lists
{
    public class MergeUniqueEX
    {
        public List<int> MergeUnique(List<int> a, List<int> b)
        {
            List<int> result = new List<int>(a.Capacity + b.Capacity);

            result.AddRange(a);
            result.AddRange(b);

            result = result.Distinct().ToList();

            return result;
        }
    }
}
