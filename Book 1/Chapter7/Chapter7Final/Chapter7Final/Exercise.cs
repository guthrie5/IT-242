using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7Final
{
    class Exercise
    {
        private string v1;
        private string v2;

        public Exercise(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        class Assignment
        {
            private string Name { get; set; }
            private string Language { get; set; }
            public Assignment(string name, string language)
            {
                Name = name;
                Language = language;
            }
            public string getName() { return Name; }
            public string getLanguage() { return Language; }
        }
    }
}
