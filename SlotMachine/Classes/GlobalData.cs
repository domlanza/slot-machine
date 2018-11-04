/* Temple University / CIS 3309 / Slot Machine
 * Class: InternalSlots 
 * Authors: Zachary Goncalves & Michael Rodriguez
 */

using SlotMachine.Classes;

namespace SlotMachine
{
	// Instantiates objects used globally by all forms. 
	public class GlobalData
	{
		public static RNGen RNG = new RNGen();
		public static InternalSlots internalfrm = new InternalSlots();
		public static Player player = new Player();
        public static Scoreboard scoreboard = new Scoreboard();
    }
}

