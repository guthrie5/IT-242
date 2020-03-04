using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7Final
{
    class Student
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string slackHandle { get; set; }
        private string Cohort { get; set; }
        private List<Exercise> Exercises { get; set; }
        public Student(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
            Exercises = new List<Exercise>();
        }
        public void Slack(string Handle)
        {
            slackHandle = Handle;
        }
        public void Group(string cohort)
        {
            Cohort = cohort;
        }
        public void addExercise(Exercise theExercise)
        {
            Exercises.Add(theExercise);
        }
        public void printInformation()
        {
            Console.WriteLine($"Name: {firstName} {lastName}\r");
            Console.WriteLine($"Slack: {slackHandle}\r");
            Console.WriteLine($"Group: {Cohort}\r");
            foreach (Exercise assignment in Exercises)
            {
                Console.WriteLine($"Task: {assignment.getName()}, {assignment.getLanguage()}\r");
            }
            Console.WriteLine("\r");
        }
    }
}
