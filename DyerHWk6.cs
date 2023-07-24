class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Console.WriteLine("Students List");
        foreach (Student stu in Student.studentList)
        {
            stu.PrintInfo();
        }

        Console.WriteLine();
        Console.WriteLine($"Student GPA");
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        // Check if "Tom" exists in the gradebook, if not, add him with a GPA of 3.3
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        double totalGPA = 0.0;
        foreach (var gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;

        Console.WriteLine();
        foreach (var entry in gradebook)
        {
            Console.WriteLine($"Student Name: {entry.Key}, GPA: {entry.Value}");
        }

        Console.WriteLine($"\nAverage GPA: {averageGPA}");

        // Print out information about students whose GPA is greater than the average GPA
        Console.WriteLine("\nStudents with GPA Greater Than Average");
        foreach (var entry in gradebook)
        {
            if (entry.Value > averageGPA)
            {
                Console.WriteLine($"Student Name: {entry.Key}, GPA: {entry.Value}");
            }
        }
    }
}
//chatgpt July 24, correct errors. Corrected If and ForEach entries to make them run correctly