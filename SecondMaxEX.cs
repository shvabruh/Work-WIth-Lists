using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_With_Lists
{
    public class SecondMaxEX
    {
        public int SecondMax(List<int> numbers)
        {
            var firstMax = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > firstMax)
                { 
                    firstMax = numbers[i];
                }
            }

            numbers.Remove(firstMax);
            var secondMax = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > secondMax)
                {
                    secondMax = numbers[i];
                }
            }
            return secondMax;
        }
    }
}
