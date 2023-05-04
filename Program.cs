using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Rock Paper Scissors!";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Welcome to a simple game of Rock, Scissors, Paper. If I, the CPU, get 3 points, I win. But if " +
                "you get 3 points, then you win. Let's start...");
            Console.WriteLine("But first...do you like the background colour? Type your yes/no response below" +
                " and click enter: ");
            string likesColour = Console.ReadLine();

            if (likesColour == "no" || likesColour == "No" || likesColour == "nah" || likesColour == "nope" || likesColour == "Nope" )
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("How's this? Okay, let's move on...");
            }
            else
            {
                Console.WriteLine("Okay let's move on...");
            }
            

            //Start of game


            top:
            Console.ForegroundColor = ConsoleColor.Yellow;
            string UserInput, CPUInput;
            int RandInt;
            string[] answers = { "Rock", "Scissors", "Paper" };
            int UserScore = 0;
            int CPUScore = 0;

            //Invalid input sends back to here
            restart:

            while (UserScore < 3 && CPUScore < 3)
            {


                Console.WriteLine("Choose between Rock, Paper or Scissors: ");
                UserInput = Console.ReadLine();


                Random rnd = new Random();

                RandInt = rnd.Next(0, 4);
                
                if (UserInput == answers[0] || UserInput == answers[1] || UserInput == answers[2])
                {


                    switch (RandInt)
                    {
                        case 1:
                            CPUInput = "Rock";
                            Console.WriteLine("I choose Rock!");
                            if (UserInput == "Scissors")
                            {
                                Console.WriteLine("I win!");
                                CPUScore += 1;
                            }
                            else if (UserInput == "Paper")
                            {
                                Console.WriteLine("Argh, you win!");
                                UserScore += 1;

                            }
                            else if (UserInput == "Rock")
                            {
                                Console.WriteLine("Woops...no one wins...let's try again?");
                            }
                            break;
                        case 2:
                            CPUInput = "Paper";
                            Console.WriteLine("I choose Paper!");
                            if (UserInput == "Rock")
                            {
                                Console.WriteLine("I win!");
                                CPUScore += 1;

                            }
                            else if (UserInput == "Scissors")
                            {
                                Console.WriteLine("Argh, you win!");
                                UserScore += 1;

                            }
                            else if (UserInput == "Paper")
                            {
                                Console.WriteLine("Woops...no one wins...let's try again?");
                            }
                            break;
                        case 3:
                            CPUInput = "Scissors";
                            Console.WriteLine("I choose Scissors!");
                            if (UserInput == "Paper")
                            {
                                Console.WriteLine("I win!");
                                CPUScore += 1;

                            }
                            else if (UserInput == "Rock")
                            {
                                Console.WriteLine("Argh, you win!");
                                UserScore += 1;
                            }
                            else if (UserInput == "Scissors")
                            {
                                Console.WriteLine("Woops...no one wins...let's try again?");
                            }
                            break;


                    }

                }
                else
                {
                    Console.WriteLine("Thats not a right answer! Let's try again...");
                    goto restart;

                }

                
            }

            Console.ForegroundColor = ConsoleColor.White;

            if (UserScore == 3)
            {
                Console.WriteLine("You won! You beat the CPU. Great Job");
            }
            else
            {
                Console.WriteLine("Ouch! You lost the game...Maybe next time...");
            }

             Console.WriteLine("Wanna play again? Reply with true or false: ");

            bool PlayAgain = Convert.ToBoolean(Console.ReadLine());

            if(PlayAgain == true)
            {
                goto top;
            }

            Console.WriteLine("Thanks for playing! See you next time...");
 
            
            Console.ReadLine();

            
        }
    }
}


