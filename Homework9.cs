
using System;
using System.Collections.Generic;

public class Student
{
    private int studentID;
    private string studentName;

    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
    }

    public int StudentID
    {
        get { return studentID; }
    }

    public string StudentName
    {
        get { return studentName; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 2: Creating 4 students
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        // Step 3: Creating gradebook dictionary
        Dictionary<int, double> gradebook = new Dictionary<int, double>()
        {
            {s1.StudentID, 4.0},
            {s2.StudentID, 3.6},
            {s3.StudentID, 2.5},
            {s4.StudentID, 1.8}
        };

        // Step 4: Checking/adding "Tom" to gradebook
        if (!gradebook.ContainsKey(555)) // Assuming Tom's student ID is 555
        {
            gradebook.Add(555, 3.3);
        }

        // Step 5: Calculating GPA
        double totalGPA = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"The average GPA is: {averageGPA}");

        
        foreach (var pair in gradebook)
        {
            if (pair.Value > averageGPA)
            {
                // Find student name based on ID
                string studentName = Student.studentList.Find(s => s.StudentID == pair.Key)?.StudentName;
                if (studentName != null)
                {
                    Console.WriteLine($"Student ID: {pair.Key}, Name: {studentName}");
                }
            }
        }
    }
}
