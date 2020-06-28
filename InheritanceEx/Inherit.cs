namespace InheritanceEx
{
    public class A
    {
        public A()
        {
            System.Console.WriteLine("In parent class - A.");
        }

        public void msg()
        {
            System.Console.WriteLine("msg method in A.");
        }
    }

    public class B : A
    {
        public B()
        {
            System.Console.WriteLine("In child class - B.");
        }
    }

    public class C : A
    {
        public C()
        {
            System.Console.WriteLine("In class C.");
        }
        public void msg()
        {
            System.Console.WriteLine("msg method in C.");
            System.Console.WriteLine("Implementing Overriding.");
            base.msg();
            //alternative
            //new A().msg();
        }
    }
}