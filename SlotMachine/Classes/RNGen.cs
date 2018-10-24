/* Temple University / CIS 3309 / Slot Machine
 * Class: RNGen 
 * Author: Zachary Goncalves
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    class RNGen
    {
        private int[] pictureNum = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		private int[] valueNum = new int[] { 0, 1, 2, 3, 4 };
        private int result;
        private Random gen;

        public RNGen()
        {
            gen = new Random();
        }

        public int pickRandomImage()
        {
            return result = gen.Next(0, pictureNum.Length);        
        }
		public int pickRandomValue()
		{
			return result = gen.Next(0, valueNum.Length);
		}
    }
}
