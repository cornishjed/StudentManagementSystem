// See https://aka.ms/new-console-template for more information
using student;
using System.Linq.Expressions;

Console.WriteLine("Student Management System");

List<Student> students = new List<Student>();

int choice = 0;

string GetModeChoice()
    {
        Console.WriteLine(@"
Select from the following options:
    1. Add a New Student
    2. Add Grades
    3. View Average Grade
    4. Display Student Information
    5. Exit
    ");

    return Console.ReadLine();
}

void AddNewStudent()
{
    Console.WriteLine("Add New Student");
    Console.WriteLine("Enter name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter age: ");
    string age = Console.ReadLine();

    Student newStudent = new Student(name, age);
    
    students.Add(newStudent);
    
    foreach (Student student in students)
    {
        Console.WriteLine("{0}: {1}", student.Name, student.Age);
    }

    Console.WriteLine("Student added.");
}

void AddGrades()
{
    Console.WriteLine("1. Enter name\n2. Enter ID");
    string inputChoice = Console.ReadLine();

    switch (inputChoice)
    {
        case "1":
            Console.WriteLine("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter grade: ");
            int newGrade = Convert.ToInt16(Console.ReadLine());

            Student currentStudent = students.Find(x => x.Name.Equals(studentName, StringComparison.Ordinal));

            if (currentStudent != null) currentStudent.AddGrade(newGrade);

            break; 
        case "2":
            Console.WriteLine("Enter student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(students.FirstOrDefault(x => x.StudentId.Equals(studentId)).StudentId);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Student {0} does not exist...", studentId);
            }
            
            break;
        default:
            Console.WriteLine("Invalid input...");
            break;
    } 
}

void ViewAverageGrade()
{
    Console.WriteLine("View Average Grades");
}

void DisplayStudentsInfo()
{
    Console.WriteLine("Display Students Info");

    if (students.Count > 0)
    {
        foreach(Student student in students)
        {
                Console.WriteLine($"Student ID: {student.StudentId}, Name: {student.Name}, Age: {student.Age}");
            if (student.Grades != null)
            {
            for (int x = 0; x < student.Grades.Count; x++)
            {
                Console.WriteLine($"Grade {x + 1}: {student.Grades[x]}");
            }
            }
            Console.WriteLine();
            
        }
    }
    else
    {
        Console.WriteLine("No students found.");
    }
    
}


while (choice != 5) {
    try { 
        choice = Int32.Parse(GetModeChoice());

        switch (choice) {
            case 1:
                AddNewStudent();
                break;
            case 2:
                AddGrades();
                break;
            case 3:
                ViewAverageGrade();
                break;
            case 4:
                DisplayStudentsInfo();
                break;
            case 5:
                Console.WriteLine("Goodbye");
                break;
            default:
                Console.WriteLine("Option does not exist...");
                break;
        }
    } catch(FormatException) {
        Console.WriteLine("Error");
    }
    Console.WriteLine("Press any key to continue.");
    Console.ReadLine();
}
    



