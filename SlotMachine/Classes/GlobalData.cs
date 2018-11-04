/* Temple University / CIS 3309 / Slot Machine
 * Class: InternalSlots 
 * Authors: Zachary Goncalves & Michael Rodriguez
 */

using SlotMachine.Classes;

namespace SlotMachine
{
	public class GlobalData
	{
        // Instantiates objects used globally by all forms. 
		public static RNGen RNG = new RNGen();
		public static InternalSlots internalfrm = new InternalSlots();
		public static Player player = new Player();
        public static Scoreboard scoreboard = new Scoreboard();
    }
}

