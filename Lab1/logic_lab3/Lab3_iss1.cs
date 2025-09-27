using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.logic_lab3
{
    public class Lab3_iss1
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }


       public Lab3_iss1(int a,int b,int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public int calculateNumbers()
        {
            int count = 0;

            if (this.A % 27 == 0) count++;
            if (this.B % 27 == 0) count++;
            if (this.C % 27 == 0) count++;

            return count;
        }

    }
}
