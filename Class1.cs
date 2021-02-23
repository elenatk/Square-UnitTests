using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    class Calculator

    {
        public static int Square(int n)
        {
            if (n > 46340 || n < (-46340))
                throw new ArgumentException();

            return n*n;
            
        }
    }
}
