namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestGenClass<int> testGenClass = new TestGenClass<int>();
            //testGenClass.TestGenMeth<int>();

            TestGenClass<string> name = new TestGenClass<string>();
            name.value = "TestNalbandyan";

            // instance of float type
            TestGenClass<float> version = new TestGenClass<float>();
            version.value = 5.0F;

            // display Nalbandyan
            Console.WriteLine(name.value);

            // display 5
            Console.WriteLine(version.value);

            TestGenClass<int> testGenClass2 = new TestGenClass<int>();

            // calling Generics method
            testGenClass2.Display<int>("Integer", 122);
            testGenClass2.Display<char>("Character", 'H');
            testGenClass2.Display<double>("Decimal", 255.67);           

        }
    }
}