using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SlotMachine.Classes
{
    public class Scoreboard
    {
        private List<Tuple<string, int>> scoreboardList = new List<Tuple<string, int>>();

        private string strPlayerInfo;
        private string scoreboardFilePath = "scoreboard.txt";
        StreamReader scoreboardReader;
        StreamWriter scoreboardWriter;

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

        public void readFile()
        {
                using (scoreboardReader = new StreamReader(scoreboardFilePath, true))
                {
                    while (!scoreboardReader.EndOfStream)
                    {
                        strPlayerInfo = scoreboardReader.ReadLine();

						
						string finalplayerlist = strPlayerInfo.TrimEnd(')');
						finalplayerlist = finalplayerlist.TrimStart('(');
						string[] inputArray = finalplayerlist.Split(',');
						
                        string playerName = inputArray[0];
                        int playerScore = Convert.ToInt32(inputArray[1]);

                        Tuple<string, int> fileTuple = Tuple.Create<string, int>(playerName, playerScore);
                        scoreboardList.Add(fileTuple);
                    }
                }
        }

        public void updateScoreboard(string score)
        {
            string[] scoreArray = score.Split(',');
            string playerName = scoreArray[0];
            int playerScore = Convert.ToInt32(scoreArray[1]);
            Tuple<string, int> gameTuple = Tuple.Create<string, int>(playerName, playerScore);

            scoreboardList.Add(gameTuple);
            readFile();

            scoreboardList = scoreboardList.OrderBy(y => y.Item2).ToList();

			if (scoreboardList.Count >= 11)
            {
                for(int i = 1; i <= scoreboardList.Count; i++)
                {
                    scoreboardList.RemoveAt(i);
                }
            }
            writeFile();
        }


    }
}
