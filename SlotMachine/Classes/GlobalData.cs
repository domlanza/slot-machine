using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
	class GlobalData
	{
		public RNGen RNGOne = new RNGen();
        public RNGen RNGTwo = new RNGen();
        public RNGen RNGThree = new RNGen();
        public Player player;

	}
}
