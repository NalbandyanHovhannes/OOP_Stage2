namespace GenericsStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonBad Ken = new PersonBad(666, "Ken");
            // PersonBad Blok = new PersonBad("Ken", "Blok");

            int tomId = (int)Ken.Id;
           // string bobId = (string)bob.Id;

            Console.WriteLine(tomId);   // 546
                                        // Console.WriteLine(Blok);   // Ken

            // Boxing int type to Object
            PersonBad tom = new PersonBad(666, "Ken");//public object Id { get; }

            //Unboxing tomid
            tomId = (int)Ken.Id;


            #region
            //-------------------------------
            PersonGoodPractice<int> obj1 = new PersonGoodPractice<int>(666, "Tommy");  // not boxing
            PersonGoodPractice<string> obj2 = new PersonGoodPractice<string>("99999", "Gags");

            int obj1Id = tom.Id;      // not unboxing
            string obj2bobId = obj2.Id;  // not boxing

            Console.WriteLine(tomId);   // 666
            Console.WriteLine(obj2bobId);   // 99999
            #endregion
        }
    }
}