using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_With_Lists
{
    public class SumListEX
    {
        public int SumList(List<int> numbers)
        {
            var summ = 0;
            foreach (var number in numbers)
            { 
                summ += number;
            }
            return summ;
        }

        
    }
}
