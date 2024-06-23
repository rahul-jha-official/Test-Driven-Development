using System.Text;

namespace Calculator;

public class Operations : IOperations
{
    private bool IsValidArgument(params string[] nums)
    {
        foreach (var n in nums)
        {
            if (n.Length <= 0 || n.Length > 100) return false;
            if (!n.Equals("0") && !n.TrimStart('0').Equals(n)) return false;
        }
        return true;
    }
    public string Add(string num1, string num2)
    {
        if (!IsValidArgument(num1,num2))
        {
            throw new ArgumentException("Arguments Provided Are Not Valid.");
        }
        int max = Math.Max(num1.Length, num2.Length);
        int index = 1;
        int remainder = 0;
        var result = new StringBuilder();
        for (int i = 0; i < max; i++)
        {
            //Calculations
            var sum = (num1.Length - index) >= 0 ? num1[num1.Length - index] - '0' : 0;
            sum += (num2.Length - index) >= 0 ? num2[num2.Length - index] - '0' : 0;
            sum += remainder;
            //Adding Result
            result.Insert(0, sum % 10);
            //Carry
            remainder = sum / 10;
            index++;
        }
        //If carry is not 0
        if (remainder > 0)
        {
            result.Insert(0, remainder);
        }
        return result.ToString();
    }

    public string Divide(string num1, string num2)
    {
        throw new NotImplementedException();
    }

    public string Multiply(string num1, string num2)
    {
        throw new NotImplementedException();
    }

    public string Subtract(string num1, string num2)
    {
        throw new NotImplementedException();
    }
}
