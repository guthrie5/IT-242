using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        /*
                  Create a dictionary with key value pairs to
                  represent words (key) and its definition (value)
          */
        Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>(){
                {"bitcoin", "magic internet money"},
                {"shitcoins", "non magic scam money"},
                {"satoshi", "me muhahaha  ;)"}
            };

        // Add several more words and their definitions
        wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
        wordsAndDefinitions.Add("C#", "An object oriented programming language(OOP");
        wordsAndDefinitions.Add("4 Pillars of OOP", "abstraction, encapsulation, inheritance, and polymorphism");




        /*
            Use square bracket lookup to get the definition two
            words and output them to the console
        */

        // you can use nameOfDictionary[key] to search your dictionary and grab the value of the key, here 'bitcoin' is the key and 'magic internet money is the value'
        //first make a title so you can easily keep track of values you are printing to the console.
        Console.WriteLine("Returns the value(defintion) of the key specified, ex: nameOfDictionary[key]");
        Console.WriteLine(wordsAndDefinitions["bitcoin"]);
        Console.WriteLine(wordsAndDefinitions["satoshi"]);

        /*
            Loop over dictionary to get the following output:
                The definition of [WORD] is [DEFINITION]
                The definition of [WORD] is [DEFINITION]
                The definition of [WORD] is [DEFINITION]
        */
        foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
        {
            Console.WriteLine($" -{word.Key}- Definition: {word.Value}");
        }







        //List in C# is similar to an array, 
        //This is a dictionary that is of type 'string' and type 'List', the key is the 'string' and the value is a 'List" of type 'strings'
        //ex: "Penny" = idioms[0].key
        Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
        idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
        idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
        idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
        idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
        idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
        idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
        idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
        idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
        idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
        idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });


        //This is how you access and loop through a single item in the dictionary 'idioms' 
        //will pirint every word(value) in list with key of "Moon"
        foreach (string value in idioms["Moon"])
        {
            Console.WriteLine(value);
        }


        //this is to put a space between the words so the sentence is readable
        string emptySpace = " ";

        //Loop through the Dictionary with foreach and use .Join() to combine all the words in the 
        foreach (string key in idioms.Keys)

        {
            string results = String.Join(emptySpace, idioms[key]);
            Console.WriteLine($"{key}: {results} ");
        }




        /*
                    Create a dictionary with key value pairs to
                    represent words (key) and its definition (value)
            */
        Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>(){
                {"bitcoin", "magic internet money"},
                {"shitcoins", "non magic scam money"},
                {"satoshi", "me muhahaha  ;)"}
            };

        // Add several more words and their definitions
        wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
        wordsAndDefinitions.Add("C#", "An object oriented programming language(OOP");
        wordsAndDefinitions.Add("4 Pillars of OOP", "abstraction, encapsulation, inheritance, and polymorphism");




        /*
            Use square bracket lookup to get the definition two
            words and output them to the console
        */

        // you can use nameOfDictionary[key] to search your dictionary and grab the value of the key, here 'bitcoin' is the key and 'magic internet money is the value'
        //first make a title so you can easily keep track of values you are printing to the console.
        Console.WriteLine("Returns the value(defintion) of the key specified, ex: nameOfDictionary[key]");
        Console.WriteLine(wordsAndDefinitions["bitcoin"]);
        Console.WriteLine(wordsAndDefinitions["satoshi"]);

        /*
            Loop over dictionary to get the following output:
                The definition of [WORD] is [DEFINITION]
                The definition of [WORD] is [DEFINITION]
                The definition of [WORD] is [DEFINITION]
        */
        foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
        {
            Console.WriteLine($" -{word.Key}- Definition: {word.Value}");
        }
    }
}