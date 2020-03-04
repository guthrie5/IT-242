using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7Final
{
    class Cohort
    {
        private string Name { get; set; }
        private List<Student> Students { get; set; }
        private List<Instructor> Instructors { get; set; }
        public Cohort(string groupName)
        {
            Name = groupName;
            Students = new List<Student>();
            Instructors = new List<Instructor>();
        }
        public void addStudent(Student theStudent)
        {
            theStudent.Group(Name);
            Students.Add(theStudent);
        }
        public void addInstructor(Instructor theInstructor)
        {
            theInstructor.Group(Name);
            Instructors.Add(theInstructor);
        }
    }
}
