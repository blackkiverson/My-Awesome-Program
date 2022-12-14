namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            
            // Declaring a Variable
            string name = "John";
            Console.WriteLine("My nme is" + " " + name);
            // Double for decimal point numbers and value ends with a D
            double myDoubleNum = 67.9D;
            myDoubleNum = 09028570136D;
            Console.WriteLine(myDoubleNum);
            // Int for whole numbers
            int myNum = 5;
            Console.WriteLine(myNum);
            // Char for Single characters
            char myLetter = 'D';
            Console.WriteLine(myLetter);
            // Bool for true or false value
            bool myBool = true;
            Console.WriteLine(myBool);

            /* Waiting for the user to press a key before closing the console window. */
            Console.ReadKey();
        }
    }
}