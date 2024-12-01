using student;

List<Student> students = new List<Student>();

PrintHeader("Student Management System");

while (true)
{
    showMenu();
}

void PrintHeader(string heading)
{
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine($"\n{heading}");
    Console.BackgroundColor = ConsoleColor.Black;
}

void showMenu()
{
    Console.WriteLine(@"
Select from the following options:
    1. Add a New Student
    2. Add Grade
    3. View Average Grade
    4. Display Student Information
    5. Exit
    ");

    try
    {
        int choice = Int32.Parse(Console.ReadLine());

        try
        {
            switch (choice)
            {
                case 1:
                    AddNewStudent();
                    break;
                case 2:
                    AddGrade();
                    break;
                case 3:
                    ViewAllAverageGrades();
                    break;
                case 4:
                    DisplayStudentsInfo();
                    break;
                case 5:
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Error.WriteLine("Error: Invalid input...");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error");
        }
        showMenu();
        Console.ReadLine();
    }
    catch
    {
        Console.Error.WriteLine("Error: Invalid input...");
    }
}

void AddNewStudent()
{
    PrintHeader("Add New Student");

    string name = "";
    int age = 0;

    while (name.Length < 2 || name == null)
    {
        Console.WriteLine("Enter name: ");
        name = Console.ReadLine();
    }

    while (age == 0 || age < 1)
    {
        Console.WriteLine("\nEnter age: ");
        try
        {
            age = Convert.ToInt16(Console.ReadLine());
            if (age == 0 || age < 1) Console.WriteLine("Age must a positive number.");
        }
        catch
        {
            Console.Error.WriteLine("Error: Incorrect value...");
        }

    }

    Student newStudent = new Student(name, age);

    students.Add(newStudent);

    Console.WriteLine("Student added.");
    Console.ReadLine();
}

void AddGrade()
{
    PrintHeader("Add Grade");

    if (students.Count > 0)
    {
        Student currentStudent = GetStudent();

        if (currentStudent != null)
        {
            Console.WriteLine("Enter grade: ");

            int newGrade = Convert.ToInt16(Console.ReadLine());

            if (newGrade > -1)
            {
                currentStudent.AddGrade(newGrade);
            }
            else
            {
                Console.WriteLine("Error: Cannot be a negative value...");
            }
        }
    }
    else
    {
        Console.WriteLine("No students exist...");
    }

}

void ViewAllAverageGrades()
{
    PrintHeader("View Grade Average");

    if (students.Count > 0)
    {
        Student currentStudent = GetStudent();

        if (currentStudent.Grades.Count > 0)
        {
            int total = 0;

            foreach (int grade in currentStudent.Grades)
            {
                total += grade;
            }

            Console.WriteLine($"Average grade: {total / currentStudent.Grades.Count}");
        }
        else
        {
            Console.WriteLine("Error: No grades exist for this student.");
        }
    }
    else
    {
        Console.WriteLine("No students exist...");
    }
}

void DisplayStudentsInfo()
{
    PrintHeader("Display Students Info");

    if (students.Count > 0)
    {
        foreach (Student student in students)
        {
            Console.WriteLine($"Student ID: {student.StudentId}, Name: {student.Name}, Age: {student.Age}");
            if (student.Grades.Count > 0)
            {
                int total = 0;

                foreach (int grade in student.Grades)
                {
                    total += grade;
                }

                Console.WriteLine($"Average grade: {total / student.Grades.Count}");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("No students found.");
    }

}

Student GetStudent()
{
    Console.WriteLine("1. Enter name\n2. Enter ID");
    string inputChoice = Console.ReadLine();

    switch (inputChoice)
    {
        case "1":
            Console.WriteLine("Enter student name: ");

            string studentName = Console.ReadLine();
            Student currentStudent = students.Find(x => x.Name.Equals(studentName, StringComparison.Ordinal));

            if (currentStudent != null)
            {
                return currentStudent;
            }
            else
            {
                Console.WriteLine("Error: Student doesn't exist...");
                return null;
            }
        case "2":
            Console.WriteLine("Enter student ID: ");

            int studentId = Convert.ToInt32(Console.ReadLine());
            return students.Find(x => x.StudentId.Equals(studentId));
        default:
            Console.WriteLine("Invalid input...");
            return null;
    }
}