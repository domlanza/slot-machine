/* Temple University / CIS 3309 / Slot Machine
 * Class: Scoreboard 
 * Author: Zachary Goncalves & Michael Rodriguez
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SlotMachine.Classes
{
    public class Scoreboard
    {
        // Create a list of tuples
        private List<Tuple<string, int>> scoreboardList = new List<Tuple<string, int>>();

        private string strPlayerInfo;
        private string scoreboardFilePath = "scoreboard.txt";
        StreamReader scoreboardReader;
        StreamWriter scoreboardWriter;

        // Formates each tuple in scoreboardList and concatenates them into a single string.
        // Author: Zachary Goncalves
        public string displayScoreboard()
        {
            string output = "";
            string formattedScore;
            foreach (Tuple<string, int> scoreEntry in scoreboardList)
            {
                formattedScore = "Player Name: " + scoreEntry.Item1 + " Score: " + scoreEntry.Item2;    
                output += formattedScore + "\n";
            }
            return output;
        }

        // Checks and deletes scoreboard file if it exists. Writes all items in scoreboardList to file.
        // Author: Zachary Goncalves
        public void writeFile()
        {
			if (File.Exists(scoreboardFilePath))
			{
			    File.Delete(scoreboardFilePath);
			}
			try
			{
				using (scoreboardWriter = new StreamWriter(scoreboardFilePath, true))
				{
					foreach (Tuple<string, int> scoreEntry in scoreboardList)
					{
						scoreboardWriter.WriteLine(scoreEntry);
					}
				}
			}
			catch
			{
				MessageBox.Show("Scoreboard does not write", "Error");
			}

		}

        // Reads all entries in scoreboard file, sanatizes them, converts them to a tuple, and 
        // adds them to scoreboardList.
        // Authors: Zachary Goncalves & Michael Rodriguez
        public void readFile()
        {
            if (File.Exists(scoreboardFilePath) == false)
            {
                using (scoreboardReader = new StreamReader(scoreboardFilePath, true))
                {
                    while (!scoreboardReader.EndOfStream)
                    {
                        strPlayerInfo = scoreboardReader.ReadLine();


                        string finalplayerlist = strPlayerInfo.TrimEnd(')');
                        finalplayerlist = finalplayerlist.TrimStart('(');
                        finalplayerlist.Trim();

                        string[] inputArray = finalplayerlist.Split(',');

                        string playerName = inputArray[0];
                        int playerScore = Convert.ToInt32(inputArray[1]);

                        Tuple<string, int> fileTuple = Tuple.Create<string, int>(playerName, playerScore);
                        scoreboardList.Add(fileTuple);
                    }
                }
            }
        }

        // Updates scoreboard with value from latest play and from scoreboard. 
        // Deletes any entry above index 10 in list and then writes out scoreboardList to a file.
        // Authors: Zachary Goncalves & Michael Rodriguez
        public void updateScoreboard(string score)
        {
            string[] scoreArray = score.Split(',');
            string playerName = scoreArray[0];
            int playerScore = Convert.ToInt32(scoreArray[1]);
            Tuple<string, int> gameTuple = Tuple.Create<string, int>(playerName, playerScore);

            scoreboardList.Add(gameTuple);
            readFile();

            scoreboardList = scoreboardList.OrderByDescending(y => y.Item2).ToList();
			while(scoreboardList.Count >= 11)
            {
                    scoreboardList.RemoveAt(10);  
            }
            writeFile();
        }


    }
}
