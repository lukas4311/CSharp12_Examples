// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;

PrimaryConstructorClass primaryConstructorInstance = new PrimaryConstructorClass(1, "John", "Doe");

Console.WriteLine("Hello, World!");

primaryConstructorInstance.SayHello();


var director = new Director(10, "B101");
// director.Salary; Error: Salary is not accesible, it is not a member of class


// Basic example of primary constructor class
// Primary constructor parameters aren't members of the class
// Primary constructor parameter named param can't be accessed as this.param
// Primary constructor parameters don't become properties, except in record types
internal class PrimaryConstructorClass(int Id, string FirstName, string LastName)
{
    public void SayHello()
    {
        Console.WriteLine($"Hi, my name is {FirstName} {LastName}");
    }
}



// Example of inheritance
internal class BaseWorker(int Salary)
{
    public override string ToString() => $"My job salary is {Salary}";
}

internal class Director(int Salary, string Office) : BaseWorker(Salary)
{
    public override string ToString() => base.ToString() + $" and my office is {Office}";
}

internal class Director_Explicit_Ctor : BaseWorker
{
    private readonly string office;

    public Director_Explicit_Ctor(int Salary, string Office) : base(Salary)
    {
        office = Office;
    }

    public override string ToString() => base.ToString() + $" and my office is {office}";
}
