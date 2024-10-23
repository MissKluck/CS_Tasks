namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();

        // Create a new instance of the Fundament class aka implement it into main
        Fundament fundament = new Fundament();
        double a = 29;
        fundament.CheckOddOrEven(a);

        string fact = "Did you know that a cow has 4 stomachs?";
        Console.WriteLine(fundament.GetAnInterestingFact(fact));

        fundament.SumTwoNumbers();

        // Extra challenges
        fundament.PrintFibonnaciSeries(7);


        Console.WriteLine(fundament.ReverseString("Hello there"));

        Console.WriteLine(fundament.RecursiveFactorial(5));



    }
}
