using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.logic_lab2
{
    class TemperatureDay
    {
        public int Index { get; set; }   
        public int Value { get; set; }  
    }
    internal class Arrays
    {
        public bool error = false;
        int[] a = new int[10];
        int length = 10;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        // indecsator

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }


        public Arrays()
        {
            a = new int[10];
            Random rand = new Random();
            for (int i = 0; i < length; i++) {
                a[i] = rand.Next(-40, 40);
            }
        }

        public (int, TemperatureDay[]) Sum
        {
            get
            {
                List<TemperatureDay> res = new List<TemperatureDay>();
                int count = 0;
                int index = 1;
                foreach (int temp in a)
                {
                    if (temp < -10)
                    {
                        count++;
                        res.Add(new TemperatureDay { Index = index, Value = temp });
                    }
                    index++;
                }
                return (count, res.ToArray());

            }
        }
    }
}
