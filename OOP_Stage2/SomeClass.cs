namespace OOP_Stage2
{
    public class SomeClass
    {
        public void SomeClassMethod()
        {
            Console.WriteLine("SomeClassMethod In class Running");
        }
        public void SomeClassMethodInt(int u)
        {
            Console.WriteLine("SomeClassMethod In class Running {0}", u);
        }
        public int MyProperty { get; set; }
        int t;

        //Ctor Deafult
        public SomeClass()
        {

        }
        //Ctor params 

        public SomeClass(int o)
        {
            SomeClassMethodInt(o);
        }
        public SomeClass(int o,int u)
        {
            SomeClassMethodInt(o);
        }
    }
}
