using System;

    class AgeCalculator
    {
        static void Main(string[] args)
        {
            int intAge;
            Console.WriteLine("Input age: ");
            string inputAge=Console.ReadLine();
            if (int.TryParse(inputAge, out intAge))
            {
                Console.WriteLine("Your age in 10 years would be {0}",intAge + 10);
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }
            
        }
    }

