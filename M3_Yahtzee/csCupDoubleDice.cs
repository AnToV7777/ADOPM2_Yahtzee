using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Yahtzee
{
    
    class csCupDoubleDice : csCupOfDice, ICupDoubleDice
    {
        public csCupDoubleDice(int nrOfDices) : base(nrOfDices)
        {

        }

        //Implement IsPair Property
        public bool IsPair => Count == 2 && this[0] == this[1];
    }
    
}
