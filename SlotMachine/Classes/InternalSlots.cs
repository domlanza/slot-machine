using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    class InternalSlots
    {
		//our slot machine quantity counter
		private int[] reelResult = { 0, 0, 0, 0, 0 };
		//number of coins bet this round
        private int coinNum = 0;
		//first random number
		private int One;
		//second random number;
		private int Two;
		//third random number
		private int Three;

		//accepts 3 integer parameters and returns correct score
		//we can actually drop the parameters here, and call spinReel within this method
        public int getReelResult()
        {
			//call for random numbers
			spinReel();

			reelResult[One]++;
			reelResult[Two]++;
			reelResult[Three]++;
			//Three of the same
			//three red T's
			if (reelResult[0] == 3)
			{
				if (coinNum == 3)
					return 600;
				if (coinNum <= 2)
					return 400;
				if (coinNum == 1)
					return 200;
				
			}
			//three blue T's
			else if (reelResult[1] == 3)
			{
				if (coinNum == 3)
					return 300;
				if (coinNum == 2)
					return 200;
				if (coinNum == 1)
					return 100;
				
				
			}
			//three green T's
			else if (reelResult[2] == 3)
			{
				if (coinNum == 3)
					return 180;
				if (coinNum == 2)
					return 120;
				if (coinNum == 1)
					return 60;
				
				
			}
			//3 stella owls
			else if (reelResult[3] == 3)
			{
				if (coinNum == 3)
					return 150;
				if (coinNum == 2)
					return 100;
				if (coinNum == 1)
					return 50;
				
				
			}
			//3 drawn owls
			else if (reelResult[4] == 3)
			{
				if (coinNum == 3)
					return 90;
				if (coinNum == 2)
					return 60;
				if (coinNum == 1)
					return 30;				
			}
			//Other Combinations
			//Any three temple T's
			else if (reelResult[0] + reelResult[1] + reelResult[2] == 3)
			{
				if (coinNum == 3)
					return 225;
				if (coinNum == 2)
					return 150;
				if (coinNum == 1)
					return 75;
				
				
			}
			//Any 3 owls
			else if (reelResult[3] + reelResult[4] == 3)
			{
				if (coinNum == 3)
					return 30;
				if (coinNum == 2)
					return 20;
				if (coinNum == 1)
					return 10;
				
				
			}
			//any pair with a red T
			else if (reelResult[0] == 1)
			{
				for (int i = 0; i < 4; i++)
				{
					if (reelResult[i] == 2)
					{
						{
							if (coinNum == 3)
								return 15;
							if (coinNum == 2)
								return 10;
							if (coinNum == 1)
								return 5;			
						}
					}
				}
			}
			//one red T
			else if (reelResult[0] == 1)
			{
				{
					if (coinNum == 3)
						return 6;
					if (coinNum == 2)
						return 4;
					if (coinNum == 1)
						return 2;					
				}
			}
			//no combos
			return 0;
		}

		//resets the array
		public void resetReelResult()
		{
			int[] reelResult = { 0,0,0,0,0};
		}

		//assigns random values to all three 'panels'
		public void spinReel()
        {
			int One = GlobalData.RNG.pickRandomValue();
			int Two = GlobalData.RNG.pickRandomValue();
			int Three = GlobalData.RNG.pickRandomValue();
		}

    }
}
