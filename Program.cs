using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_With_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() {1,2,4,5,6,7,8,9 };
            //SumListEX listEX = new SumListEX();
            //Console.WriteLine(listEX.SumList(list));

            //List<int> list = new List<int>() { 3, 1, 4, 1, 5, 9, 2, 6 };
            //SecondMaxEX l = new SecondMaxEX();
            //Console.WriteLine(l.SecondMax(list));

            List<int> list1 = new List<int>() { 10, 20, 30, 40,83, 67, 67, 78 };
            List<int> list2 = new List<int>() { 10, 23, 60, 40, 83, 67 };

            MergeUniqueEX merge = new MergeUniqueEX();
            var a = merge.MergeUnique(list1, list2);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
