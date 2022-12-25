namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ClassProperty classProperty = new ClassProperty(9,44);
            ClassProperty classProperty2 = new ClassProperty(9);
            Console.WriteLine(classProperty.MyProperty);
            Console.WriteLine(classProperty2.MyProperty);
        }

    }
}