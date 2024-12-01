namespace student;

class Student(string name, int age)
{
    private static int currentId = 0;

    public int StudentId { get; set; } = currentId++;
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public List<int> Grades { get; } = [];

    public void AddGrade(int grade)
    {
        Console.WriteLine($"grade added: {grade}");
        Grades.Add(grade);
    }

    public float getAverageGrade()
    {
        return (float) Grades.Average();
    }
}