namespace TestGit2
{
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    internal class Program
    {

        static void Main(string[] args)
        {

            HostApplicationBuilder builder = new HostApplicationBuilder();
            //add services
            
            builder.Services.AddScoped<IFruit, Fruit>();


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
            //investigate dispose and finalize
        }
    }
}
