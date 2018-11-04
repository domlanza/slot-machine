/* Temple University / CIS 3309 / Slot Machine
 * Class: RNGen 
 * Authors: Zachary Goncalves & Michael Rodriguez
 */

using System;

namespace SlotMachine.Classes
{
    public class RNGen
    {
        private int[] pictureNum = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
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
