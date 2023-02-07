using Ex._01.DefineAClassPerson;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person();
        Person person1 = new Person("Name", 99);
        Person person2 = new Person()
        {
            Name = "Name",
            Age = 99
        };
    }
}