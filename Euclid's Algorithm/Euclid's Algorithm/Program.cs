// Let's find the greatest common denominator(GCD) of two integers

int greaterNumber = int.Parse(Console.ReadLine());
int smallerNumber = int.Parse(Console.ReadLine());

int result = GCD(greaterNumber, smallerNumber);

Console.WriteLine(result);

static int GCD(int a, int b)
{
    while (b != 0)
    {
        int temp = a;
        a = b;
        b = temp % b;
    }

    return a;
}
