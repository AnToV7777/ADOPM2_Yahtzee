using System.Collections;

namespace M3_Yahtzee
{
    
    class csCupYahtzeeDice : csCupOfDice, ICupYahtzeeDice
    {
        //Implementing the IsLargeStraight property
        public bool IsLargeStraight
        {
            get
            {
                //sort the dices
                Sort();

                //Checking for the presence of large straight
                for(int i = 0; i < Count - 1; i++)
                {
                    if (this[i] + 1 != this[i + 1])
                        return false;
                }
                return true;
            }
        }

        //Implementing IsYahtzee property
       public bool IsYahtzee
        {
            get
            {
                //check if all dice faces are the same
                enDiceFace firstFace = this[0];
                return this.Distinct().Count() == 1;
            }
        }
    }
    
}
