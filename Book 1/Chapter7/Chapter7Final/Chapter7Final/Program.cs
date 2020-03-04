using System;

namespace Chapter7Final
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise ex01 = new Exercise("Assignment #01", "C#");
            Exercise ex02 = new Exercise("Assignment #02", "C++");
            Exercise ex03 = new Exercise("Assignment #03", "JavaScript");
            Exercise ex04 = new Exercise("Assignment #04", "Python");

            // Create 3, or more, cohorts.
            Cohort gp01 = new Cohort("Group 1");
            Cohort gp02 = new Cohort("Group 2");
            Cohort gp03 = new Cohort("Group 3");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student st01 = new Student("John", "Smith");
            st01.Slack("@JohnnySmith");
            Student st02 = new Student("Darrell", "Fish");
            st02.Slack("@DFish");
            Student st03 = new Student("Greg", "Miller");
            st03.Slack("@GMills");
            Student st04 = new Student("Alex", "Houston");
            st04.Slack("@HoustonA");
            gp01.addStudent(st01);
            gp02.addStudent(st02);
            gp03.addStudent(st03);
            gp01.addStudent(st04);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor in01 = new Instructor("Gal", "Summers");
            in01.Slack("@GSummers1980");
            in01.Talent("Tacos");
            Instructor in02 = new Instructor("Herman", "Granger");
            in02.Slack("@HGranger");
            in02.Talent("Challenging the mind");
            Instructor in03 = new Instructor("Buddy", "Joseph");
            in03.Slack("@Ihavetwofirstnames");
            in03.Talent("Physics");
            gp01.addInstructor(in01);
            gp02.addInstructor(in02);
            gp03.addInstructor(in03);

            // Have each instructor assign 2 exercises to each of the students.
            in01.assignStudentExercise(ex01, st01);
            in01.assignStudentExercise(ex02, st04);

            in02.assignStudentExercise(ex03, st02);
            in02.assignStudentExercise(ex04, st02);

            in03.assignStudentExercise(ex01, st03);
            in03.assignStudentExercise(ex04, st03);

            // Generate a report that displays which students are working on which exercises.
            st01.printInformation();
            st02.printInformation();
            st03.printInformation();
            st04.printInformation();
        }
    }
}
