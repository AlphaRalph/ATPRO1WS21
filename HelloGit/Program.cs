using System;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myperson = new Person();
            myperson.Birthdate = new DateTime();

            Console.WriteLine("Hello Git!");
            Console.WriteLine(myperson.ToString());
        }
    }
}
