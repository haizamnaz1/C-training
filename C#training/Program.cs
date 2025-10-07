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


            //variables
            int myNum = 15; //integer (whole number)
            bool myBool = true; //boolean (true or false)
            char myChar = 'D'; //character (single character)
            double myDouble = 19.99; //double (floating point number)
            string myText = "Hello"; //string (text)

            Console.WriteLine(myNum); //prints the variable value
            Console.WriteLine(myBool);
            Console.WriteLine(myChar);
            Console.WriteLine(myDouble);
            Console.WriteLine(myText);

            int Mynum = 20;
            Mynum = 25; //Now the value has been updated to 25
            Console.WriteLine(Mynum);

            //constants
            //if you dont want otehrs to change your variable value, then we can add const before the vraible type
            const int myConstNumber = 10; //we do have to assign a value when we declare a constant
            Console.WriteLine("this is the example of const method: " + myConstNumber);


            //display variables
            string firstName = "Jhon";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("This is how the full Name will be printed: " + fullName);

            int x = 5;
            int y = 6;
            int z = x * y;
            Console.WriteLine("The result of x * y is: " + z);

            //declare multiple variables
            int a = 2, b = 10, c = 13;
            Console.WriteLine(a + b + c); //printsx the sum of all integers

            int q, m, d;
            m = q = d = 50;
            Console.WriteLine(q + m + d); //prints the sum of all integers

            //indentifyers
            int l = 60; //l really doesnt specifiy what it is
            int hoursPerMinute = 60; //this is a better identifier because it specifies what the variable is
            Console.WriteLine("The value of l is: " + l);

            //data types

            //numbers
            int M = 40;
            long N = 1500000000L; //long is used for larger numbers and we add L at the end
            float O = 5.75F; //float is used for decimal numbers and we add F at the end
            double P = 19.66D; //double is also used for decimal numbers and we add D at the end
            Console.WriteLine("The value of M is: " +   M + N + O + P);
            //text
            char myGrade = 'a'; //char is used for single characters and we use single quotes
            string myname = "jony boy doe"; //string is used for text and we use double quotes
            Console.WriteLine("My name is " + myname + " and i scored " + myGrade);

            //true or false
            bool isCsharpFun = true; //boolean is used for true or false values
            bool isFishTasty = false;
            Console.WriteLine("person A: is C# fun bruh? " + "person B: " + isCsharpFun + "is fish tasty?" + " " + isFishTasty);

            if (isCsharpFun == true) //tried something new here, didnt look up at things just did it myself 
            { //== what is does is it compares the given statements and if the given statement matches
                Console.WriteLine("C# is fun");// then it will print this
            }
            else
            {
                Console.WriteLine("C# is not fun");//if the given statement doesnt match then it will print this
            }


        }
    }

    
}