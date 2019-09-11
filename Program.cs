using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many years experience do you have in professional programming");
            int yearsinsales = 0;
            yearsinsales = int.Parse(Console.ReadLine());
            for (int i = 0; i < yearsinsales; i++)
            {
                Console.WriteLine("you have {0} years of experience", +yearsinsales);
            }



        }
    }
}
