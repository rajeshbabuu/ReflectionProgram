using ReflectionDemoProject;

namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to reflection Demo");

            ReflectionOnCustomer.ReflectionTest();
            Console.ReadKey();
        }
    }
}