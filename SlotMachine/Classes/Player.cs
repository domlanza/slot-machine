/* Temple University / CIS 3309 / Slot Machine
 * Class: Player 
 * Authors: Zachary Goncalves & Michael Rodriguez
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
	//class used to save an individuals score, balance and name
    public class Player
    {
        private string playerName;
        private int score = 0;
        private int playerBalance=0;
        
        // Constructor that sets player name and balance.
        // Author: Michael Rodriguez
        public void setPlayer(string name, int balance)
        {
            playerName = name;
            playerBalance = Math.Abs(balance);
        }
        // Gets and returns player name.
        // Author: Zachary Goncalves
        public string getPlayerName()
        {
            return playerName;
        }
        // Sets player score.
        // Author: Zachary Goncalves
        public void setScore(int scoreInput)
		{
			score = scoreInput;
		}
        // Gets and returns player balance.
        // Author: Zachary Goncalves
        public int getBalance()
		{
			return playerBalance;
		}
        // Gets and returns player score.
        // Author: Zachary Goncalves
        public int getScore()
        {
            return score;
        }
        // Caclculates score from score and player balance.
        // Author: Michael Rodriguez
        public int calculateScore()
        {
            return score = score - playerBalance;
        }
        // Resets player attributes.
        // Author: Zachary Goncalves
        public void resetPlayer()
        {
            score = 0;
            playerBalance = 0;
            playerName = "";
        }
        // Formats player name and score into string.
        // Author: Zachary Goncalves
        public string preparePlayerScore()
        {
            string finalScore = playerName + ", " + score;
            return finalScore; 
        }


    }
}
