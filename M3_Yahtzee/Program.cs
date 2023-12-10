using System;
using Helpers;

namespace M3_Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            #region sprint 3
            Console.WriteLine("\n\nSprint 3");

            ICupOfDice cup = null;
            Console.WriteLine($"Newly created cup\n{cup}");

            try
            {
                int _nrDice;
                csConsoleInput.TryReadInt32("How many dice?", 1, 10, out _nrDice);

                // Console.WriteLine("How many dice?");
                // string input = Console.ReadLine();
                // _nrDice = int.Parse(input);

                ICupOfDice cup2 = new csCupOfDice(_nrDice);
                Console.WriteLine($"Newly created cup\n{cup2}");

                //Sort the cup and print it
                Console.WriteLine($"\nSorted Cup\n{cup2.Sort()}");

                //Shuffle the cup and print out the shuffled cup
                Console.WriteLine($"\nShaken Cup\n{cup2.Shake()}");

                //Go trough and print the dices with their index.
                for(int i = 0; i < cup2.Count; i++)
                {
                    Console.WriteLine($"Dice[{i}]: {cup2[i]}");
                }

                //Highest and Lowest dice in the cup
                Console.WriteLine($"\nHighest: {cup2.Highest}");
                Console.WriteLine($"Lowest: {cup2.Lowest}");


            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error running the program, pls try again");
                Console.WriteLine($"Error: {ex.Message}");
            }
            #endregion

            #region sprint 4
            Console.WriteLine("\n\nSprint 4");

            //Create an instance of the csCupDoubleDice
            ICupDoubleDice doubleDice = new csCupDoubleDice(2);

            //Print out the dice in the cup
            Console.WriteLine($"Cup of double dices\n{doubleDice}");

            //Continue with your code
            //Print out the result of IsPair
            Console.WriteLine($"IsPair: {doubleDice.IsPair}");
            #endregion

            #region sprint 5
            Console.WriteLine("\n\nSprint 5");
            
            //Test the YahtzeeDices
            ICupYahtzeeDice yahtzeeDice = null;
            Console.WriteLine($"Cup of Yahtzee dices\n{yahtzeeDice}");

            #endregion

            //Continue with your code
            Console.WriteLine("\n\nThank you for playing");
        }
    }
}
