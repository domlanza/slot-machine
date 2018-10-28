﻿/* Temple University / CIS 3309 / Slot Machine
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
            playerBalance = balance;
        }

        public string getPlayerName()
        {
            return playerName;
        }


		public void setScore(int scoreInput)
		{
			score = scoreInput;
		}

        public int getScore()
        {
            return score;
        }

    }
}
