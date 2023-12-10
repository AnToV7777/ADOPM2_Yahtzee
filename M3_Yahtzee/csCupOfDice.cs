using System;
using System.Collections.Generic;
using System.Linq;
using Helpers;

namespace M3_Yahtzee
{
    //Sprint 2
    /// <summary>
    /// Cup with 1 to 10 dice
    /// </summary>

    //Define the class cs Cup of Dice that implements the interface I Cup of Dice
    class csCupOfDice : ICupOfDice
    {
        //Private field that hold an instance of the csSeedGenerator
        csSeedGenerator _rnd = new csSeedGenerator();

        //Protected field to stare a list of enDiceFaces (enumeration representing dice faces)
        protected List<enDiceFace> _dices;

        //Constructor that takes the number of dices (NrOfDices) as a parametre
        public csCupOfDice(int NrOfDices)
        {
            // Validates the number of dices (it has to be between 1 and 10)
            if (NrOfDices < 1 || NrOfDices > 10)
            {
                //Throw an error if the number of dices are not within the range
                throw new ArgumentOutOfRangeException("NrOfDices must be be between 1 & 10");
            }

            //Initialize the list of dices with random values using LINQ.
            _dices = Enumerable.Range(0, NrOfDices)
                        .Select(_ => (enDiceFace)_rnd.Next(1, 7))
                        .ToList();
        }

        //*** IMPLEMENTATION OF THE INTERFACE ****//

        //property to get the number of dices in the cup
        public int Count => _dices.Count;

        //Indexer to get the value of a specific dice by its index
        public enDiceFace this[int idx] => _dices[idx];

        //Property to get the highest value of a dice in the cup
        public enDiceFace Highest => _dices.Max();

        //The property to get the lowest value of dices in the cup
        public enDiceFace Lowest => _dices.Min();

        //Method to sort the dices in the cup in ascending order
        public ICupOfDice Sort()
        {
            //Uses the method sort from the enum in the interface
            _dices.Sort();
            // Returns the current status of the dices in the cup
            return this;
        }

        //A method to shake the cup to get new random dice faces
        public ICupOfDice Shake()
        {
            //Generates random values for each dice in the cup using LINQ
            _dices = Enumerable.Range(0, Count)
                .Select(_ => (enDiceFace)_rnd.Next(1, 7))
                .ToList();
            //Return the current status of the dices in the cup
            return this;
        }

        //**** STRING REPRESENTATION ****//
        public override string ToString() => string.Join(", ", _dices.Select(dice => dice.ToString()));
    }
    
}
