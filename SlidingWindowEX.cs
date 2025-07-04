using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_With_Lists
{
    public class SlidingWindowEX
    {
        public List<int> SlidingWindow(List<int> numbers, int k)
        {
            List<int> answer = new List<int>();
            int index = 0;

            for (int i = 0; i < numbers.Capacity; i+=k)
            {
                int localMax = -1;
                for (int j = 0; j < index; j++)
                { 
                   if (numbers[i] > localMax) localMax = numbers[i];
                }
                answer.Add(localMax);
                index += i;
            }
            return answer;

        }
    }
}
