using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_With_Lists
{
    public class TwoSumEX
    {
        public (int, int) TwoSum(List<int> numbers, int target)
        {
            var answer = (-1,-1);
            for (int i = 0; i < numbers.Capacity; i++)
            {
                for (int j = 0; j < numbers.Capacity; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        if (numbers[i] + numbers[j] == target)
                        {
                            answer = (i, j);
                            break;
                        }
                        else return (-1, -1);
                    }
                }
            }
            return answer;
        }
    }
}
