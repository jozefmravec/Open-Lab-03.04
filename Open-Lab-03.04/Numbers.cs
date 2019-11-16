using System;

namespace Open_Lab_03._04
{
    public class Numbers
    {
        public string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
        public void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(EvenOrOdd(146));
        }

    }
}
