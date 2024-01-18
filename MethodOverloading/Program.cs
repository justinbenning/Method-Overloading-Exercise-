using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 15;
            var b = 13;

            var answerIn = Add(a, b);

            var answerDecimal = Add(a, b);

            var answerBool = Add(a, b, true);
            Console.WriteLine(answerBool.ToString());
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool dollar)
        {
            int sum = a + b;
            if (dollar = true && sum == 1)
            {
                return $"{sum} dollar";

            }
            else if (dollar = true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (dollar = true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
