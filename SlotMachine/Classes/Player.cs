/* Temple University / CIS 3309 / Slot Machine
 * Class: Player 
 * Author: Zachary Goncalves
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    class Player
    {
        private string playerName;
        private int numCoins = 15;
        private int winnings = 0;

        public Player(string name)
        {
            playerName = name; 
        }

        public string getPlayerName()
        {
            return playerName;
        }

        public int removeCoins(int coinCount)
        {
            return numCoins - coinCount; 
        }

        public int addCoints(int coinCount)
        {
            return numCoins + coinCount; 
        }

        public int addToWinnings(int coinCount)
        {
            return winnings + coinCount;
        }

        public int removeFromWinnings(int coinCount)
        {
            int updatedWinnings = winnings - coinCount;
            if(updatedWinnings < 0)
            {
                return winnings = 0;
            } else
            {
                return winnings;
            }
        }

        public int getWinnings()
        {
            return winnings;
        }

    }
}
