using System.Globalization;

namespace Class4Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MySpace.Class1 MyClass = new MySpace.Class1();
            Console.Write(MyClass.students.Length);
            Console.Write("\n");
            MyClass.students[0] = "Molly";
            Console.Write("The #1 student is " + MyClass.students[0]);
        }
    }
}