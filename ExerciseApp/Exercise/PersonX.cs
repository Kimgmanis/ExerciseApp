using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExerciseApp.Exercise
{
    internal class PersonX // Exercise: Implement a class with data validation
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        // Constructor
        public PersonX(string name, int age, string email = null)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public void Validate()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(Name) || Name.Length > 100)
            {
                errors.Add("Name must be between 1 and 100 characters\n");
            }

            if (Age < 0 || Age > 120)
            {
                errors.Add("Age must be between 0 and 120.\n");
            }

            if (Email != null && !Regex.IsMatch(Email, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"))
            {
                errors.Add("Email must be a valid email address format.\n");
            }

            if (errors.Count > 0)
            {
                throw new ArgumentException(string.Join(" ", errors));
            }
        }
    }
}
