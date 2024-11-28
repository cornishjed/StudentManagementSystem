namespace vehicle;

class Vehicle
{
    public string Make { get; set}
    string model;
    int year;
    int speed = 0;

    public virtual void Accelerate()
    {
        speed += 10;
    }

    public void Brake()
    {
        if (speed > 0) speed--;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{make}: {model}");
    }
}