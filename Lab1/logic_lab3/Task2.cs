using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.logic_lab3
{
    public class Task2
    {
        int[] numbers;

        public Task2(int a,int b)
        {
            if( a>b)
            {
                throw new ArgumentException("a must be smaller then b");
            }
            numbers = new int[b-a+1];

            for (int i = 0; i < numbers.Length; i++) { 
                numbers[i] = a+i;
            }

        }

        public int FindTargetNumbersCount()
        {
            int count = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0 && item % 3 == 2)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
