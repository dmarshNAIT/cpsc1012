namespace ReferenceVsValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            ChangeAge( age);
            // int is passed by value
            // we are passing a COPY of the value "25"

            Console.WriteLine(age); // age is still 25

            //ChangeAge(ref age);
            //Console.WriteLine(age); // age is now 100

        }

        static void ChangeAge( int age)
        {
            age = 100;
            // this only changes the COPY of the value, not the original variable
        }

        //static void ChangeAge (ref int age)
        //{
        //    age = 100;
        //    // this is now a REFERENCE type: we are accessing the actual object in memory
        //}
    }
}
