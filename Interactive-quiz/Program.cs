using System;

namespace Interactive_quiz
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Welcome to my quiz! Hit 'Enter' to take the quiz or type 'quit' to exit: ");

                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }


                int total = 0;


                try
                {

                    Console.WriteLine("True or false: Jill doesn't know how to ride a bike: ");
                    var entry2 = Console.ReadLine();

                    if (entry2.ToLower() == "true")
                    {
                        total++;
                    }

                    else if (entry2.ToLower() == "false")
                    {

                    }


                    else
                    {
                        Console.WriteLine("That input is invalid.");

                    }

                    Console.WriteLine("True or false: Jill loves Nosferatu: ");
                    var entry3 = Console.ReadLine();

                    if (entry3.ToLower() == "true")
                    {
                        total++;
                    }

                    else if (entry3.ToLower() == "false")
                    {

                    }

                    else
                    {
                        Console.WriteLine("That input is invalid");
                        continue;
                    }

                    Console.WriteLine("True or false: Jill loves Bri: ");
                    var entry4 = Console.ReadLine();

                    if (entry4.ToLower() == "true")
                    {

                    }

                    else if (entry4.ToLower() == "false")
                    {
                        total++;
                    }

                    else
                    {
                        Console.WriteLine("That input is invalid");
                        continue;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid input");
                    continue;
                }

                Console.WriteLine("You got " + total + " right");
            }
        }
    }
}
