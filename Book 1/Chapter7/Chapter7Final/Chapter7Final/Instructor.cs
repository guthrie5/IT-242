using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7Final
{
    class Instructor
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string slackHandle { get; set; }
        private string Cohort { get; set; }
        private string Specialty { get; set; }
        public Instructor(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
        public void Slack(string Handle)
        {
            slackHandle = Handle;
        }
        public void Group(string cohort)
        {
            Cohort = cohort;
        }
        public void Talent(string theSpecialty)
        {
            Specialty = theSpecialty;
        }
        public void assignStudentExercise(Exercise assignment, Student pupil)
        {
            pupil.addExercise(assignment);
        }
    }
}
