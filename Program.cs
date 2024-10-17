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

        Fundament fundament = new Fundament();
        double a = 29;
        fundament.CheckOddOrEven(a);

        string fact = "Did you know a cow has 4 stomachs?";
        fundament.GetAnInterestingFact(fact);
        Console.WriteLine(fact);

    }
}
