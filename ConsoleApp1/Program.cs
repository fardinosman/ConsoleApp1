﻿using System;
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
            Console.WriteLine("dsds");

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
                        if (userChoice2 == "scissor")
                        {
                            Console.WriteLine(player2.name+" wins");
                        }
                        else if (userChoice2 == "paper")
                        {
                            Console.WriteLine("No one wins");
                        }
                        else if (userChoice2 == "rock")
                        {
                            Console.WriteLine(player1.name + " wins");
                        }
                      
                        break;
                    case "scissor":
                        if (userChoice2 == "scissor")
                        {
                            Console.WriteLine("No one wins");
                            
                        }
                        else if (userChoice2 == "paper")
                        {
                            Console.WriteLine(player1.name + " wins");
                        }
                        else if (userChoice2 == "rock")
                        {
                            Console.WriteLine(player2.name + " wins");
                        }
                        break;

                    case "rock":
                        if (userChoice2 == "scissor")
                        {
                            Console.WriteLine(player1.name + " wins");
                        }
                        else if (userChoice2 == "paper")
                        {
                            Console.WriteLine(player2.name + " wins");
                        }
                        else if (userChoice2 == "rock")
                        {
                            Console.WriteLine("No one wins");
                        }
                        break;
                        
                    default:
                        Console.WriteLine(" try again ");
                        break;
                }

                Console.WriteLine("Play again? Y/N");
                if (Console.ReadLine() == "N")
                    input = 0;

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
