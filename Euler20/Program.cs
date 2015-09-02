using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = new List<int>();
            digits.Add(1);

            for(int i = 2; i <= 100; i++)
            {
                int carry = 0;
                for(int j = 0; j < digits.Count; j++)
                {
                    int next = digits[j] * i + carry;
                    digits[j] = next % 10;
                    carry = next / 10;
                }
                while(carry > 0)
                {
                    digits.Add(carry % 10);
                    carry = carry / 10;
                }
            }

            Console.WriteLine(digits.Sum());
            Console.ReadLine();
        }
    }
}
