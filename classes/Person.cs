public class Person
{
    public string Name { get; protected set; }
    public string JobPosition { get; protected set; }

    public Person(string name, string jobPosition)
    {
        Name = name;
        JobPosition = jobPosition;
    }
}