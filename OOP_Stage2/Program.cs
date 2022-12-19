namespace OOP_Stage2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ChildClass childClass = new ChildClass();
            childClass.ChildMethod();
            childClass.ParentMethod();
            childClass.SomeClassMethod();


        }
    }
}