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
    public class Player
    {
        private string playerName;
        private int winnings = 0;
        private int playerBalance = 0;

        public Player(string name, int balance)
        {
            playerName = name;
            playerBalance = balance;
        }

        public string getPlayerName()
        {
            return playerName;
        }


        public int addToWinnings(int amountWon)
        {
            return winnings += amountWon;
        }

        public int removeFromWinnings(int amountLost)
        {
            return winnings -= amountLost;
        }

        public int getWinnings()
        {
            return winnings;
        }

    }
}
