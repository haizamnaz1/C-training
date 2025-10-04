using System; //this measns we are using the System namespace

namespace HelloWorld //used to organize my code and its like a container for classes and other namespaces
{
    class Program //this is a class named Program and every code must be written inside a class.
    {
        static void Main(string[] args) //this is the main method, the entry point of the program
        {
            Console.WriteLine("Hello World!"); //console is a class in the System namespace and Writeline is a method that prints text to the console.
            Console.WriteLine("Im Learning C# yayayay");
            Console.WriteLine("Im excited to learn more about C#");
            //we cam also add numbers in teh console writeline
            Console.WriteLine(5 + 10);
            Console.WriteLine(5 * 10);

            //thers a new method called write and the difference is it doesnt add a new line after printing
            Console.Write("Hello ");
            Console.Write("World!");

        }
    }
}