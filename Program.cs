using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MyBigNumber
    {
        
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First number is " + num1);
            Console.WriteLine("Second number is " + num2);

            if (num2 > num1) Sum(num2, num1);
            else Sum(num1, num2);

        }

        static void Sum(int bigNum, int smallNum)
        {
            int result = 0;
            int carryOver = 0;
            int big = bigNum;
            while (bigNum > 0)
            {
                int sum = smallNum % 10 + bigNum % 10 + carryOver;

                if (sum >= 10)
                {
                    sum = sum % 10;
                    carryOver = 1;
                } 
                else carryOver = 0;

                result = result * 10 + sum;

                smallNum = smallNum/10;
                bigNum = bigNum/10;     

            }
            int finale = reverse(result);

            while (finale.ToString().Length < big.ToString().Length) { 
                finale = finale * 10; 
            }

            Console.WriteLine("Finale result of first number + second number is: " + finale);
        }

        static int reverse(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num%10;
                num = num / 10;
            }
            return result;
        }
    }
}
