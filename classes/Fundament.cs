using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} is even!");
        }
        else
        {
            Console.WriteLine($"{a} is odd!");
        }
    }

    public string GetAnInterestingFact(string fact)
    {
        return "here is a fact " + fact;
    }

    public void SumTwoNumbers()
    {
        long firstNumber = 148395839;
        long secondNumber = 289244385;
        Console.WriteLine(firstNumber + secondNumber);

    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        return a + b;
    }


    // Extra challenges

    public void PrintFibonnaciSeries(int n)
    {
        // TODO: Implement the Fibonacci sequence
        int a = 0;
        int b = 1;
        int c;

        /* 
        c = a + b
        a = b
        b = c
        */
        for (int i = 0; i<n; i++)
        {
            c = a + b;
            Console.WriteLine($"{c} ");
            a = b;
            b = c;
        }
    }

    public string ReverseString(string str)
    {
        // TODO: reverse the given string
        /* 
        * found the solution at stackoverflow(https://stackoverflow.com/questions/228038/best-way-to-reverse-a-string), 
        * verified with fellow student that they had created the same code to reverse the string
        * this function changes the string to an array(a list) of characters
        * then it reverses the order of the array and when it is converted to a string the word has been reversed
        */ 
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        return n * RecursiveFactorial(n - 1);
    }
}