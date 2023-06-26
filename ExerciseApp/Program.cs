using ExerciseApp.Exercise;

//Exercise: Implement a struct to represent a date
//Create a C# struct called Date that represents a date with a year, month, and day component. Working
//DateRep dateRep = new DateRep();



// Exercise: Implement a method that modifies a value type using ref, in, and out. Working

//ModifyValueT modifyValueT = new ModifyValueT();



// Exercise: Implement a method with named and optional parameters. Working

// SendM sendM = new SendM();



// Exercise: Implement a method that deconstructs an object into tuple values. Working

/*var person = new Person
{
    Name = "John",
    Age = 30,
    Occupation = "Software Engineer",
    Salary = 75000.00m
};

var (name, age, occupation, salary) = person.GetPersonInfo();

Console.WriteLine($"{name} is {age} years old and works as a {occupation}, earning {salary:C} per year.");*/



// Exercise: Implement a class with data validation. Working

/*var person1 = new PersonX("John", 30, "john@example.com");
person1.Validate(); // no exception

var person2 = new PersonX(null, 150);
try
{
    person2.Validate();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message); // "Name must be between 1 and 100 characters."
}

var person3 = new PersonX("Jane", -10, "jane@example.com");
try
{
    person3.Validate();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message); // "Age must be between 0 and 120."
}

var person4 = new PersonX("Bob", 40, "invalid-email");
try
{
    person4.Validate();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message); // "Email must be a valid email address format."
}*/


