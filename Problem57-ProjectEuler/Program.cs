using System.Numerics;
BigInteger numerator = 3;
BigInteger denominator = 2;
double answer = 0;

for(int i = 1; i <= 1000; i++)
{
    if (numerator.ToString().Length > denominator.ToString().Length)
        answer++;
    BigInteger oldDenominator = denominator;
    denominator = numerator + denominator;
    numerator = oldDenominator + denominator;
}

Console.WriteLine("In the first one-thousand expansions, there are {0} fractions contain a " +
    "numerator with more digits than the denominator",answer);