using System.Linq;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Box<int> numBox = new Box<int>();
        numBox.Add(55);
        numBox.Add(33);
        numBox.Add(99);
        numBox.Remove();
        Console.WriteLine(numBox);
    }
}

public class Box<T>
{
    private Stack<T> innerCollcetion;

    public Box()
    {
        this.innerCollcetion = new Stack<T>();
    }

    public int Count
    {
        get
        {
            return this.innerCollcetion.Count;
        }
    }

    public void Add(T element)
    {
        this.innerCollcetion.Push(element);
    }

    public T Remove()
    {
        return this.innerCollcetion.Pop();
    }
}