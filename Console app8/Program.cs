using System;
public class Exercise34
{
    public static void Main()
    {
        int num, i, M, S, E;

        Console.WriteLine();


        Console.WriteLine("Find the prime numbers within a range of numbers:");


        Console.Write("*************************************************");


        Console.WriteLine();


        Console.Write("Input starting number of range: ");                S = Convert.ToInt32(Console.ReadLine());


        Console.Write("Input ending number of range : ");                 E = Convert.ToInt32(Console.ReadLine());


        Console.Write("The prime numbers between {0} and {1} are : \n", S, E);


        for (num = S; num <= E; num++)
        {
            M = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    M++;
                    break;
                }
            }

            if (M == 0 && num != 1)
                Console.Write("{0} ", num);
        }
        Console.Write("\n");
    }
}