using System;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myperson = new Person();
            myperson.Name = "Franz";

            Console.WriteLine("Hello Students!");
            Console.WriteLine(myperson.ToString());
        }
    }
}
