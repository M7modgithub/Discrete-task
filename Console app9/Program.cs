
using System;
public class Exercise28
{
    public static void Main()
    {
        int n, i, sum;
        int N, X;

        Console.WriteLine();
        Console.WriteLine("Find perfect numbers within a given number of range:");
        Console.WriteLine("****************************************************");

        Console.WriteLine();



        Console.Write("Input the starting range of number : "); N = Convert.ToInt32(Console.ReadLine());



        Console.Write("Input the ending range of number : "); X = Convert.ToInt32(Console.ReadLine());


        Console.Write("The Perfect numbers within the given range : ");

        for (n = N; n <= X; n++)
        {
            i = 1;
            sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n)
                Console.Write("{0} ", n);
        }
        Console.WriteLine();
        /*Perfect number is a positive number which sum of all positive divisors excluding*/
        /*that number is equal to that number. For example 6 is perfect number since divisor of 6 are 1, 2 and 3.*/

    }
}
