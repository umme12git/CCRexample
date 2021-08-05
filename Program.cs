using System;

namespace CCRexample
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = "";

            response = (answer < 9) ? $"{answer} is less then 9" : $"{answer} is more then or equal to 9";

            Console.WriteLine(response);

        }
    }
}
