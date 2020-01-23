using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Michael";

            int grade = 99;

            double gradePlus = 99.12;

            char gradeLetter = 'A';

            Console.WriteLine($"{firstName} got a {grade} on his test. That puts his overall grade to {gradePlus} or he has an {gradeLetter} in the class.");
        }
    }
}
