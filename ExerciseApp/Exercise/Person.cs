using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseApp.Exercise
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public decimal Salary { get; set; }

        public (string, int, string, decimal) GetPersonInfo()
        {
            return (Name, Age, Occupation, Salary);
        }
    }
}
