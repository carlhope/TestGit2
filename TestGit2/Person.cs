using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestGit2
{
    public class Person : IDisposable
    {
        public string Name { get; set; }
        public int Age { get; set; }
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

        private bool _disposedValue;

        // Instantiate a SafeHandle instance.
        private SafeHandle? _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            //Dispose(true);
            //GC.SuppressFinalize(this);
            Count--;
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            //if (!_disposedValue)
            //{
            //    if (disposing)
            //    {
            //        _safeHandle?.Dispose();
            //        _safeHandle = null;
            //    }

            //    _disposedValue = true;
            //}
            //Count--;
        }

        // reduce count by 1 when a person is disposed
        ~Person()
        {
            Count--;
        }
     }
}
