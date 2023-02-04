
using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal decimal1, decimal decimal2)
        {
            return decimal1 + decimal2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";
            if(isTrue)
            {
                sum = num1 + num2;

                if (sum == 1)
                    return $"{sum} dollar.";
                else
                {
                    return $"{sum} dollars.";
                }
            }
            return response;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, -4, true));
            Console.WriteLine();
            Console.WriteLine(Add(20, 3, true));
            Console.WriteLine();
            Console.WriteLine(Add(-16, 4, true));
        }
    }
}
