namespace Inheritance
{
    internal class InheritClass : BaseClass
    {
        //public Employee(string name): base(name)
        void InheritMethod(string str)
        {
            Console.WriteLine("Inherit Class");
        }
        public InheritClass(int n, string ss) : base(n)
        {

            InheritMethod(ss);
        }
        public InheritClass()
        {

        }

    }

}
