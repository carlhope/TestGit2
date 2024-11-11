using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestGit2
{
    public class Person
    {
        public string Name { get; set; }
        private int Age { get; set; }//cant directly access age as it is private
        public static int Count { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Count++;
        }
        public static void PrintPerson(Person person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age} Count: {Count}" );
            
        }

     }
}
