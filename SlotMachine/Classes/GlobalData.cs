using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlotMachine.Classes;

namespace SlotMachine
{
	public class GlobalData
	{
		public static RNGen RNG = new RNGen();
		public static InternalSlots internalfrm = new InternalSlots();
		public Player player;

	}
}

