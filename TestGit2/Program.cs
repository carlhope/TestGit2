namespace TestGit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("testing");
            string test = "test";
            string[] testarray = new string[] { "ab", "bb", "cb" };
            string test2 = String.Join("",testarray);
            Console.WriteLine(test2);
            //hello
            Person person = new Person("John", 30);
            Person.PrintPerson(person);
            //string tes2 = test.Join("", testarray);
            Person Jane = new Person("Jane", 25);
            Person.PrintPerson(Jane);
            Console.WriteLine(Person.Count);
            Jane.Dispose();
            Console.WriteLine(Person.Count);
        }
    }
}
