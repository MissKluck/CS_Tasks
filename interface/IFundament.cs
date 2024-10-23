public interface IFundament
{
    /// <summary>
    /// Sums two numbers together, in void, we can specify if these numbers are integers, doubles or long
    /// </summary>
    void SumTwoNumbers();

    /// <summary>
    /// sums together two numbers that it recieves as parameter arguments
    /// </summary>
    /// <param name="a">the value of a</param>
    /// <param name="b">the value of b</param>
    /// <returns>a + b</returns>
    double SumTwoNumbersOfGivenType(double a, double b);

    /// <summary>
    /// check whether a number is even (divisible by two) or odd
    /// </summary>
    void CheckOddOrEven(double a);

    /// <summary>
    /// A method that returns a interesting fact, that the user of the program can define as a parameter argument
    /// </summary>
    /// <param name="fact">an interesting fact</param>
    /// <returns>a fact of type: string</returns>
    string GetAnInterestingFact(string fact);
    /// <summary>
    /// A method that implements the Fibonacci sequence
    /// The Fibonacci sequence means that each number is the sum of the two preceding ones
    /// You start at 0 and 1, then add them together which gets you 1, then add 1 and 1 together to get 2 and so on
    /// </summary>
    /// <param name="n">value of n</param>
    void PrintFibonnaciSeries(int n);
    /// <summary>
    /// A method that reverses a string
    /// </summary>
    /// <param name="str">a string of words</param>
    /// <returns>a string that's been reversed</returns>
    string ReverseString(string str);
    /// <summary>
    /// A method that calls itself within itself
    /// It multiplies each iterative number with itself until it reaches zero
    /// Example: n = 5 would be (5*4*3*2*1 = 120)
    /// </summary>
    /// <param name="n">value of n</param>
    /// <returns>n * (n-1)</returns>
    int RecursiveFactorial(int n);
}