using System;

namespace lecture5
{
    class Program
    {
        static void Main(string[] args)
        {
            int testGrade = 77;

            if (testGrade >= 90)
            {
                Console.WriteLine($"You got a {testGrade} on the test, which is an A");
            }

            else
            {
                Console.WriteLine($"You got a {testGrade} on the test, which is a failing grade.");
            }



            for (int k = 0; k <= 100; k += 1)
            {
                if (k >= 90 == k <= 95)
                {
                    Console.WriteLine(k);
                }
            }

            string[] Students = new string[]
            {
                "Samantha", "Carol", "Carrey"
            };

            foreach (string names in Students)
            {
                Console.WriteLine(names);
            }

            //int finalGrade = 92;

            //if (finalGrade >= 90)
            //{
            //    Console.WriteLine($"your grade in the class is {finalGrade}, and is an A");
            //}
            //if (finalGrade < 90)
            //{
            //    Console.WriteLine($"your grade in the class is {finalGrade}, and you do not pass the class.");
            //}
        }
    }
}
