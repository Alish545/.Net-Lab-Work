using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Define two different objects
        List<Student> students = new List<Student>()
        {
            new Student { ID = 1, Name = "Alish" },
            new Student { ID = 2, Name = "Arbin" }
        };

        List<Grade> grades = new List<Grade>()
        {
            new Grade { StudentID = 1, Course = "Math", Score = 90 },
            new Grade { StudentID = 2, Course = "Math", Score = 85 }
        };

        // Join the two objects based on a common property (StudentID)
        var joinedData = from student in students
                         join grade in grades on student.ID equals grade.StudentID
                         select new
                         {
                             student.ID,
                             student.Name,
                             grade.Course,
                             grade.Score
                         };

        // Display the joined data
        foreach (var data in joinedData)
        {
            Console.WriteLine($"ID: {data.ID}, Name: {data.Name}, Course: {data.Course}, Score: {data.Score}");
        }
    }
    
}

// Define two different classes
class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
}

class Grade
{
    public int StudentID { get; set; }
    public string Course { get; set; }
    public int Score { get; set; }
}
