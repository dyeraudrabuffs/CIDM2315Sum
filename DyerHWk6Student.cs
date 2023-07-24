using System;
using System.Collections.Generic;

class Student
{
    private int studentID { get; set; }
    private string studentName { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public static List<Student> studentList = new List<Student>();

    public Student(int inputID, string inputName)
    {
        studentID = inputID;
        studentName = inputName;
        studentList.Add(this);
    }
}

