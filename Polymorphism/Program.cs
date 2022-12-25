namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VirtualClasses virtualClasses = new VirtualClasses();
            virtualClasses.AnimalVoice(8);
            Console.WriteLine("--------------------");


            ParentClass parentClass = new ParentClass();
            parentClass.AnimalVoice(9);
            parentClass.AnimalFight(99);

            //int a = 8;
            //string t = "585";
            //int o = int.Parse(t);
            //int u=Convert.ToInt32(t);
            //int y;
            //bool yy = int.TryParse(t,out y);
        }
    }
}