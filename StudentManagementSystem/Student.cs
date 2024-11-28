namespace student;

class Student(string name, string age)
{
    private static int currentId = 0;

    public int StudentId { get; set; } = currentId++;
    public string Name { get; set; } = name;
    public string Age { get; set; } = age;
    public List<int> Grades { get; } = [];

    public void AddGrade(int grade)
    {
        Console.WriteLine($"grdade added: {grade}");
        Grades.Add(grade);
    }

    public float getAverageGrade()
    {
        return (float) Grades.Average();
    }
}