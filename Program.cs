//////////// METHOD 1 ////////////

static void ShowCharacter(string text, int place)
{
    char thecharacter = text[place - 1];
    Console.WriteLine(thecharacter);

}

ShowCharacter("Tennessee", 5);
Console.WriteLine("\n\n");

//////////// METHOD 2 ////////////

Console.Write("Please type the wholesale cost: $");
double wholesale = Convert.ToDouble(Console.ReadLine());

Console.Write("Please type the markup percentage: ");
double markup = Convert.ToDouble(Console.ReadLine());



Console.WriteLine((CalculateRetail(wholesale, markup)).ToString("C"));


static double CalculateRetail(double initialcost, double markup)

{
    var finalcost = initialcost * (markup / 100 + 1);
    return finalcost;
}
Console.WriteLine("\n\n");

//////////// METHOD 3 ////////////

static void Celsius()
{
    for (int i = 80; i <= 100; i++)
    {
        double celsius = 0.55556 * (i - 32);
        Console.WriteLine($"{i} {Math.Round(celsius, 2)}");
    }
}

Celsius();
Console.WriteLine("\n\n");

//////////// METHOD 4 ////////////

Console.Write("Please type a positive number: ");
var prime = IsPrime(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"{prime}");
static bool IsPrime(int inputNumber)
{
    bool isPrime = true;
    if (inputNumber == 2)
    {
        isPrime = true;
        return isPrime;
    }
    else if (inputNumber == 1)
    {
        isPrime = false;
        return isPrime;
    }
    for (int i = 2; i < inputNumber; i++)
    {
        if (inputNumber % i == 0)
        {
            isPrime = false;
            return isPrime;
        }
        else
        {
            isPrime = true;
        }
    }
    return isPrime;
}
