using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi World");

            int scissor = 1;
            int rock = 2;
            int paper = 3;
            
            Console.WriteLine("Player 1, What is your name? ");
            string name1 = Console.ReadLine();
            Player player1 = new Player(name1);
            Console.WriteLine("Player 2, What is your name? ");
            string name2 = Console.ReadLine();
            Player player2 = new Player(name2);
            Console.WriteLine("Begin game of Rock, Paper & scissor? Y/N");

            int input = 0;
            if (Console.ReadLine() == "Y")
            {
                input = 1;
            }
            else if (Console.ReadLine() == "N")
            {
                input = 0;
                
            }

            do
            {
                Console.WriteLine("Player 1, What will you use? Paper/Scissor/Rock ");
                string userChoice1 = Console.ReadLine();
                Console.WriteLine("Player 2, What will you use? Paper/Scissor/Rock ");
                string userChoice2 = Console.ReadLine();

                switch (userChoice1)
                {
                    case "paper":
                        if (userChoice1== "paper" && userChoice2 == "scissor")
                        {
                            Console.WriteLine("Player2  win" + " " + player2.name);
                        }
                        else if (userChoice1 == "paper" && userChoice2 == "paper")
                        {
                            Console.WriteLine("no one wine");
                        }
                      
                        break;
                    case "scissor":
                         if (userChoice1 == "scissor" && userChoice2 == "paper")
                        {
                            Console.WriteLine("Player1 {0} Win" + "" + player1.name);
                        }
                        else if (userChoice1 == "scissor" && userChoice2 == "scissor")
                        {
                            Console.WriteLine();
                        }
                        break;

                    case "rock":
                         if (userChoice1 == "Rock" && userChoice2 == "scissor")
                        {
                            Console.WriteLine("Player1 win" + " " + player1.name);
                        }

                        break;
                        
                    default:
                        Console.WriteLine(" try again ");
                        break;
                }


            }
            while (input == 1);

           {

           }   

        }
        public static string userChoice(string input1, string input2)
        {

        }
    }
}
