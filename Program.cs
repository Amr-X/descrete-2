using System;
public class Exercise28
{
    public static void Main()
    {
        int n, i, sum;
        int min, max;

        
        Console.Write("Find perfect numbers within a given number of range:\n");
        Console.Write("------------------------------------------------------");
        Console.WriteLine("      ");

        Console.Write("Input the starting range number : ");
        min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the ending range of number : ");
        max = Convert.ToInt32(Console.ReadLine());
        Console.Write("The Perfect numbers within the given range : ");
        for (n = min; n <= max; n++)
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
        Console.Write("\n");
    }
}
