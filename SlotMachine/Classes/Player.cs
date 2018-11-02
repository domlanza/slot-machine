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
        private int score = 0;
        private int playerBalance=0;

        public void setPlayer(string name, int balance)
        {
            playerName = name;
            playerBalance = Math.Abs(balance);
        }

        public string getPlayerName()
        {
            return playerName;
        }

		public void setScore(int scoreInput)
		{
			score = scoreInput;
		}
		public int getBalance()
		{
			return playerBalance;
		}

        public int getScore()
        {
            return score;
        }

        public int calculateScore()
        {
            return score = score - playerBalance;
        }

        public void resetPlayer()
        {
            score = 0;
            playerBalance = 0;
            playerName = "";
        }
        public string preparePlayerScore()
        {
            string finalScore = score + ", " + playerName;
            return finalScore; 
        }


    }
}
