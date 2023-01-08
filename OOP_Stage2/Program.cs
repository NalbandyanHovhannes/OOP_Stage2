namespace OOP_Stage2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello, World!");
            //ChildClass childClass = new ChildClass();
            //childClass.ChildMethod();
            //childClass.ParentMethod();
            //childClass.SomeClassMethod();
            SomeClass someClass4 ;

            SomeClass someClass = new SomeClass();
            someClass.SomeClassMethod();
            someClass.SomeClassMethodInt(89);

            SomeClass someClass1 = new SomeClass(9);
            SomeClass someClass11 = new SomeClass(9,8);



        }
    }
}