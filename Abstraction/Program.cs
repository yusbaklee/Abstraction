using System;

/// <summary>
/// A program that uses abstraction meethod to calculate the salary of developer and a data analyst
/// </summary>
abstract class Employee //abstract class
{
    public abstract int GetSalary(); //abstract method
}

class Developer : Employee
{
    private int salary;
    public Developer(int s)
    {
        salary = s;
    }
    public override int GetSalary()
    {
        return salary;
    }
}

class DataAnalyst : Employee
{
    private int salary;
    public DataAnalyst(int s)
    {
        salary = s;
    }
    public override int GetSalary()
    {
        return salary;
    }
}

class Test
{
    static void Main(string[] args)
    {
        Developer d1 = new Developer(5000);
        DataAnalyst d2 = new DataAnalyst(3000);

        int a, b;

        a = d1.GetSalary();
        b = d2.GetSalary();
        Console.WriteLine($"Salary of developer : {a}"); //Printing the salary of the developer.
        Console.WriteLine($"Salary of driver : {b}");    //Printing the salary of the data analyst.
    }
}
