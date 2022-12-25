namespace Properties
{
    internal class ClassProperty
    {
        public int MyProperty { get; set; } = 8;

        private int myVar;

        public int MyProperty2
        {
            get { return myVar; }
            set { myVar = 12; }
        }
        public ClassProperty(int u, int ui)
        {
            myVar = u;
            MyProperty = ui;
        }
        public ClassProperty(int u)
        {
            myVar = u;
        }


    }
}
