using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace SlotMachine.Classes
{
    public class InternalSlots
    {
        //our slot machine quantity counter
        private int[] reelResult = { 0, 0, 0, 0, 0 };
        //number of coins bet this round
        private int betNum = 0;
        //first random number
        private int One;
        //second random number;
        private int Two;
        //third random number
        private int Three;
        private int max = 3;

        public void AddCoin(int num)
        {
            if (num == max)
            {
                betNum = 3;
            }
            else
            {
                betNum += num;
            }
        }
        public void ResetCoin()
        {
            betNum = 0;
        }
        public int GetCoins()
        {
            return betNum;
        }

        //we can actually drop the parameters here, and call spinReel within this method
        public int getReelResult()
        {
			int[] reelResult = { 0, 0, 0, 0, 0 };
			reelResult[One]++;
            reelResult[Two]++;
            reelResult[Three]++;
			//Three of the same
			//three red T's
			if (reelResult[0] == 3)
			{
				if (betNum == 3)
					return 600;
				if (betNum <= 2)
					return 400;
				if (betNum == 1)
					return 200;

			}
			//three blue T's
			else if (reelResult[1] == 3)
			{
				if (betNum == 3)
					return 300;
				if (betNum == 2)
					return 200;
				if (betNum == 1)
					return 100;


			}
			//three green T's
			else if (reelResult[2] == 3)
			{
				if (betNum == 3)
					return 180;
				if (betNum == 2)
					return 120;
				if (betNum == 1)
					return 60;


			}
			//3 stella owls
			else if (reelResult[3] == 3)
			{
				if (betNum == 3)
					return 225;
				if (betNum == 2)
					return 150;
				if (betNum == 1)
					return 75;


			}
			//3 drawn owls
			else if (reelResult[4] == 3)
			{
				if (betNum == 3)
					return 150;
				if (betNum == 2)
					return 100;
				if (betNum == 1)
					return 50;
			}
			//Other Combinations
			//Any three temple T's
			else if (reelResult[0] + reelResult[1] + reelResult[2] == 3)
			{
				if (betNum == 3)
					return 90;
				if (betNum == 2)
					return 60;
				if (betNum == 1)
					return 30;


			}
			//A pair of Red T's
			else if (reelResult[0] == 2)
			{
				if (betNum == 3)
					return 45;
				if (betNum == 2)
					return 30;
				if (betNum == 1)
					return 15;
			}
			//Any 3 owls
			else if (reelResult[3] + reelResult[4] == 3)
			{
				if (betNum == 3)
					return 30;
				if (betNum == 2)
					return 20;
				if (betNum == 1)
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
							if (betNum == 3)
								return 15;
							if (betNum == 2)
								return 10;
							if (betNum == 1)
								return 5;
						}
					}
				}
			}
			//one red T
			else if (reelResult[0] == 1)
			{
				{
					if (betNum == 3)
						return 6;
					if (betNum == 2)
						return 4;
					if (betNum == 1)
						return 2;
				}
			}
            //no combos
            return 0;
        }

        //assigns random values to all three 'panels'
        public void spinReel()
        {
            One = GlobalData.RNG.pickRandomValue();
            Two = GlobalData.RNG.pickRandomValue();
            Three = GlobalData.RNG.pickRandomValue();
        }

        // rng test code  
        public int getSpinOne()
        {
            return One;
        }
        public int getSpinTwo()
        {
            return Two;
        }
        public int getSpinThree()
        {
            return Three;
        }
    }
}
