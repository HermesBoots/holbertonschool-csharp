static class Number
{
    public static int PrintLastDigit(this int number)
    {
        int digit;
        digit = System.Math.Abs(number % 10);
        System.Console.Write(digit);
        return digit;
    }
}
