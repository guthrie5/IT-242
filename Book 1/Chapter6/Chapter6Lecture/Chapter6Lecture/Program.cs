using System;



public class Program
{
    //this is a class, a blueprint for an object	
    public class Writer
    {
        public Writer(string prefix)
        {
            Prefix = prefix;
        }

        public string Prefix { get; set; }

        public void Write(string message)
        {
            Console.WriteLine(Prefix + message);
        }
    }










    public static void Main()
    {
        // The output variable's type is `string` -- a built in type
        string output = "Nashville Software School";

        // The author variable's type is Writer -- a custom type you defined
        Writer author = new Writer("I do declare: ");
        author.Write(output);

        author.Prefix = "That's right, I said: ";
        author.Write(output);


        //For automobile example -- lecture code -- defined the class below, outside of Program Class
        Automobile generic_auto = new Automobile();
        Console.WriteLine($"Automobiles go {generic_auto.Accelerate()}");

        Car stella = new Car();
        Console.WriteLine($"Cars go {stella.Accelerate()}");

    }
}


//defining a second class outside of the program class
// Base class
public class Automobile { public string Accelerate() { return "zoom!"; } }

// Derived class
public class Car : Automobile { }

