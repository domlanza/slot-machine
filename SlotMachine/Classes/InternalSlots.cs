using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    class InternalSlots
    {
        private int coinNum = 0;
        private int reelResult = 0;

        public int getReelResult(int reelOneResult, int reelTwoResult, int realThreeResult)
        {
            return reelResult = Convert.ToInt32(reelOneResult.ToString() + reelTwoResult.ToString() + realThreeResult.ToString());
        }

        public int spinReel()
        {
            // Are we using one RNG or multiple? How are we keeping track? 
            return 0;
        }

    }
}
