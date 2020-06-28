namespace Constructors
{
    public class EfficientConstructors
    {
        string Name;
        int Age;

        public EfficientConstructors()
        {
            System.Console.WriteLine("In constructor with 0 parameter.");
            System.Console.WriteLine();
        }

        public EfficientConstructors(string name)
        {
            this.Name = name;
            System.Console.WriteLine("Name: " + this.Name);
            System.Console.WriteLine();
        }

        public EfficientConstructors(string name, int age)
            :this(name)
        {
            System.Console.WriteLine("I didn't write code here to read and print name.");
            System.Console.WriteLine();
            this.Age = age;
            System.Console.WriteLine("Age: " + this.Age);
            System.Console.WriteLine();
        }
    }
}