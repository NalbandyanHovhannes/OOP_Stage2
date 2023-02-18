namespace GenericsStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonBad obj1 = new PersonBad(666, "Ken");
            // PersonBad Blok = new PersonBad("Ken", "Blok");

            int tomId = obj1.Id;
           // string bobId = (string)bob.Id;

            Console.WriteLine(tomId);   // 546
                                        // Console.WriteLine(Blok);   // Ken

            // Boxing int type to Object
            PersonBad tom = new PersonBad(666, "Ken");//public object Id { get; }

            //Unboxing tomid
            tomId = (int)obj1.Id;


            #region
            //-------------------------------
            PersonGoodPractice<int> obj11= new PersonGoodPractice<int>(666, "Tommy");  // not boxing
            PersonGoodPractice<string> obj2 = new PersonGoodPractice<string>("99999", "Gags");
            //PersonGoodPractice obj3 = new PersonGoodPractice();

            int obj1Id = obj11.Id;      // not unboxing
            string obj2bobId = obj2.Id;  // not boxing

            Console.WriteLine(tomId);   // 666
            Console.WriteLine(obj2bobId);   // 99999
            #endregion
        }
    }
}