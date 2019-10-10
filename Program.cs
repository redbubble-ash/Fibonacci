using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("The fibonacci result for index of 6 is " + Recursion(6));
            
        }

        static int Recursion(int i)
        {
            if(i >0 )
            {
                if (i == 0 || i == 1)
                {
                    return i;
                }
                else
                {
                    return Recursion(i - 1) + Recursion(i - 2);
                }
            }
            else
            {
                return  0;
            }
        }
    }
}
