using System;

namespace DynamicToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("firstName", "lastName", "address", 0);

            Console.WriteLine(p);
        }
    }
}
