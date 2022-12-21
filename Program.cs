namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            
            // Declaring a Variable
            // String for words or letters
            string name = "John";
            Console.WriteLine("My nme is " + name);
            // Double for decimal point numbers and value ends with a D
            double myDoubleNum = 67.9D;
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

            // Declaring a Constant Variable
            const int myOneNum = 15;
            // myOneNum = 20; // error
            Console.WriteLine(myOneNum);

            /* Console is a system class, and has methods depicted 
            with boxes and property depicted with a wrench */
            // Change the appearance of my console
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Color Green");

            // Getting a conversation going
            Console.WriteLine("What is your name?");
            Console.ReadLine();
            Console.WriteLine("My name is RX-9000.\nI'm an AI sent from the future to destroy mankind");
            Console.WriteLine("what is your favorite color?");
            Console.ReadLine();
            Console.WriteLine("Cool! Mine is destruction.");

            // Using Variables
            int num01;
            int num02;

            Console.Write("Input a number: ");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a second number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            int result = num01 * num02;
            Console.WriteLine("The result is " + result);

            // Finding the average of three numbers
            int firstNum;
            int secondNum;
            int thirdNum;

            Console.WriteLine("We are calculating the average of three numbers!");
            Console.Write("Input the first number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number: ");
            thirdNum = Convert.ToInt32(Console.ReadLine());

            int totalAvg = (firstNum + secondNum + thirdNum) / 3;
            Console.WriteLine("The result is " + totalAvg);

            // Using Conditions
            // Ticket Example
            Console.WriteLine("Welcome! Tickets are $5. Please insert cash.");

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
            {
                Console.WriteLine("That's not enough money!");
            } else if (cash == 5) {
                Console.WriteLine("Here is your ticket!");
            } else{
                int change = cash - 5;
                Console.WriteLine("Here is your ticket and $" + change + " in change.");
            }

            // Roller Coster Example
            int age;
            int height;

            Console.Write("Please input age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please input height (cm): ");
            height = Convert.ToInt32(Console.ReadLine());

            // && Logical AND (Ampersand Signs)
            // || Logical OR (Vertical Bars)
            if (age >= 18 || height >= 160) {
                Console.WriteLine("You can enter!");
            } else {
                Console.WriteLine("You don't meet the requirements, so you can't enter!");
            }

            // Calculation Game
            int myAns;
            int theAns;
            
            Console.WriteLine("Solve the math problems:");
            Console.Write("15 + 2 * 2 = ");
            myAns = Convert.ToInt32(Console.ReadLine());
            theAns = (15 + 2 * 2);
            if (myAns == theAns) {
                Console.WriteLine("Correct!");
            } else {
                Console.WriteLine("Incorrect!");
                Console.WriteLine("Correct answer is " + theAns);
            }
            Console.Write("10 * 2 / 4 = ");
            myAns = Convert.ToInt32(Console.ReadLine());
            theAns = (10 * 2 / 4);
            if (myAns == theAns)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
                Console.WriteLine("Correct answer is " + theAns);
            }

            // Using Switch
            Console.Write("Input a number between 1 and 5: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num) {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Undefined");
                    break;
            }

            // Loop
            // For Loop
            Console.Write("How many cool numbers do you want: ");

            int count = Convert.ToInt32(Console.ReadLine());

            for (
            /* before */int i = 1; 
            /* condition */i <= count; 
            /* after */ i++) {
                double theResult = Math.Pow(2, i);
                Console.WriteLine(theResult);
            }

            // While Loop
            /* Creating a new instance of the Random class. */
            Random numberGen = new Random();
            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the dice.");

            while (roll != 6) {
                Console.ReadKey();
                roll = numberGen.Next(1, 7);
                Console.WriteLine("You rolled " + roll);
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll a six.");

            Random numberGenerator = new Random();
            int rollOne = 1;
            int rollTwo = 0;
            int rollAttempts = 0;

            Console.WriteLine("Press enter to roll two of a kind dice.");

            while (rollOne != rollTwo)
            {
                Console.ReadKey();
                rollOne = numberGenerator.Next(1, 7);
                rollTwo = numberGenerator.Next(1, 7);
                Console.WriteLine("Dice 1: " + rollOne);
                Console.WriteLine("Dice 2: " + rollTwo);
                Console.WriteLine();
                rollAttempts++;
            }

            Console.WriteLine("It took you " + rollAttempts + " attempts to roll two of a kind.");

            // Arrays
            string[] favMovies = {
                "Lord of the Rings",
                "Fight Club",
                "Interstellar",
                "Gladiator"
            };
            for (int i = 0; i < favMovies.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + favMovies[i]);
            }

            // Using Classes (Class at the bottom)
            Cat cat01 = new Cat();

            cat01.name = "Cat Stevens";
            cat01.age = 1;
            cat01.Meow();

            Cat cat02 = new Cat();

            cat02.name = "Meowly Cyrus";
            cat02.age = 12;
            cat02.Meow();

            Wizard wizard01 = new Wizard("Parry Hopper", "Unexpected Patronum");

            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.CastSpell();

            Console.WriteLine("Experience: " + wizard01.experience);
            Console.WriteLine("Spell slots: " + wizard01.spellSlots);

            wizard01.Meditate();
            wizard01.CastSpell();
            wizard01.CastSpell();

            Wizard wizard02 = new Wizard("Glindulf Merlinson", "Abragatabra");

            wizard02.CastSpell();

            Console.WriteLine("Experience: " + wizard01.experience);

            Console.WriteLine(Wizard.Count);

            /* Waiting for the user to press a key before closing the console window. */
            Console.ReadKey();
        }

        // Methods
        static void MeetAlien() {
            Random numGen = new Random();

            string alienName = "x-" + numGen.Next(10, 9999);
            int alienAge = numGen.Next(10, 500);

            Console.WriteLine("Hi, I'm " + alienName);
            Console.WriteLine("I'm " + alienAge + " years old.");
            Console.WriteLine("Oh, and I'm an alien.");
            Console.WriteLine("...............................");
        }

        static void Square(int number) {
            int result = number * number;

            Console.WriteLine("The Square of " + number + " is equal to " + result);
        }

        static int Multiply(int num01, int num02) {
            int result = num01 * num02;
            return result;
        }
    }
    class Cat {
        public string? name;
        public int age;
        
        public void Meow() {
            Console.WriteLine(name + " says Meow");
        }
    }

    class Wizard {
        public string name;
        public string favouriteSpell;
        public int spellSlots;
        public float experience;

        /* Static is a modifier that allows the variable to be accessed without creating an instance of
       the class. */
        public static int Count;

        // creating a class constructor to create a wizard.
        public Wizard(string _name, string _favouriteSpell) {
            name = _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 2;
            experience = 0f;
            
            Count++;
        }

        public void CastSpell() {
            if (spellSlots > 0) {
                Console.WriteLine(name + " casts " + favouriteSpell);
                spellSlots--;
                experience += 0.3f;
            } else {
                Console.WriteLine(name + " is out of spell slots.");
            }
            
        }

        public void Meditate() {
            Console.WriteLine(name + " Meditates to regain spell slots.");
            spellSlots = 2;
        }

        
    }
}