using System;

class Program
{

    static void Main(string[] args)
    {
        Teacher teacher = new()
        {
            Name = "Emre",
            LastName = "TERKAN",
            Salary = 5000
        };
        teacher.Info();
        Student student = new()
        {
            Name = "Can",
            LastName = "TERKAN",
            studentNumber = 10
        };
        student.Info();

    }

}
abstract class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    abstract public void Info();

}

class Student : Person
{
    public int studentNumber { get; set; }

    public override void Info()
    {
        Console.WriteLine($"Öğrencinin:\nAdı : {Name}\nSoyadı : {LastName}\nÖğrenci Numarası : {studentNumber}");
    }
}

class Teacher : Person
{
    public decimal Salary { get; set; }
    public override void Info()
    {
        Console.WriteLine($"Öğretmenin:\nAdı : {Name}\nSoyadı : {LastName}\nMaaş Bilgisi : {Salary}");
    }
}