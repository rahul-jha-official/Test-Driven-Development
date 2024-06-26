namespace IntroToReflection;

public class NumberTheory
{
    public bool IsEvenPalindrome(int x)
    {
        return x % 2 == 0 && IsPalindrome(x);
    }

    private bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        int digits = 0;
        for (int i = x; i > 0; i /= 10)
        {
            digits++;
        }
        int c = 1;
        while (c <= (digits / 2))
        {
            int first = (int)(x / Math.Pow(10, digits - c)) % 10;
            int last = (int)(x / Math.Pow(10, c - 1)) % 10;
            if (first != last) return false;
            c++;
        }
        return true;
    }
}
