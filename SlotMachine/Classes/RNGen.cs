/* Temple University / CIS 3309 / Slot Machine
 * Class: RNGen 
 * Authors: Zachary Goncalves & Michael Rodriguez
 */

using System;

namespace SlotMachine.Classes
{
	//class used to generate random numbers
    public class RNGen
    {
		private int[] valueNum = new int[] { 0, 1, 2, 3, 4 };
        private int result;
        private Random gen;
        
        // Default constructor that instantiates a new Random Number Generator.  
        // Author: Zachary Goncalves
        public RNGen()
        {
            gen = new Random();
        }
        // Selects random number from array valueNum
        // Author: Michael Rodriguez
		public int pickRandomValue()
		{
			return result = gen.Next(0, valueNum.Length);
		}
    }
}
