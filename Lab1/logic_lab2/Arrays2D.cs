using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.logic_lab2
{
    internal class Arrays2D
    {
        public bool error = false;
        int x_length = 5;
        int y_length = 5;
        private int[,] a;

        public int X_length
        { get {  return x_length; } set { x_length = value; } }

        public int Y_length 
        { 
        get { return y_length; } set { y_length = value; }
        }

        public int this[int i, int j]
        {
            get
            {
                if(0 <= i && i < x_length && i < y_length && 0<=j)
                {
                    return a[i, j];
                }else
                {
                    error = true;
                    return -1;
                }
            }
        }

        public Arrays2D()
        {
            a = new int[x_length,y_length];
            Random random = new Random();
            for (int i = 0; i < X_length; i++)
            {
                for (int j = 0; j < Y_length; j++)
                {
                    a[i, j] = random.Next(0, 100);
                }
            }
        }

        public Arrays2D(int a_length, int b_length)
        {
            X_length = a_length;
            Y_length = b_length;
            a = new int [X_length, Y_length];
            Random random = new Random();
            for (int i = 0; i < X_length; i++)
            {
                for (int j = 0; j < Y_length; j++)
                {
                    a[i, j] = random.Next(0, 100);
                }
            }
        }

        public (int,int,int,string) PositionInfo
        {
            get
            {
                int minVal = a[0, 0];
                int minI = 0, minJ = 0;

                for (int i = 0; i < X_length; i++)
                {
                    for (int j = 0; j < Y_length; j++)
                    {
                        if (a[i, j] < minVal)
                        {
                            minVal = a[i, j];
                            minI = i;
                            minJ = j;
                        }
                    }
                }

                string position;

                if (minI + minJ < Y_length - 1)
                    position = "Елемент знаходиться ВИЩЕ правої діагоналі.";
                else if (minI + minJ > Y_length - 1)
                    position = "Елемент знаходиться НИЖЧЕ правої діагоналі.";
                else
                    position = "Елемент знаходиться НА правій діагоналі.";

                return (minVal,minI, minJ, position);
            }
        }
    }
}
