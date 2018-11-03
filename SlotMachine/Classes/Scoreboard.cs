using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine.Classes
{
    public class Scoreboard
    {
        private List<String> scoreboardList = new List<String>();
        private string strPlayerInfo;
        private string scoreboardFilePath = "scoreboard.txt";
        StreamReader scoreboardReader;
        StreamWriter scoreboardWriter;

        public string displayScoreboard()
        {
            string output = "";
            string formattedScore;
            string[] outputArray;
            foreach (string score in scoreboardList)
            {
                outputArray = score.Split(',');
                formattedScore = "Player Name: " + outputArray[1] + " Score: " + outputArray[0];    
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
                    foreach (string score in scoreboardList)
                    {
                        scoreboardWriter.WriteLine(score);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Scoreboard does not exist.", "Error");
            }
        }

        public void readFile()
        {
            try
            {
                using (scoreboardReader = new StreamReader(scoreboardFilePath, true))
                {
                    while ((strPlayerInfo = scoreboardReader.ReadLine()) != null)
                    { 
                        scoreboardList.Add(strPlayerInfo);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Scoreboard not found!", "Error");
            }

        }

        public void updateScoreboard(string score)
        {
            scoreboardList.Add(score);
            readFile();

            scoreboardList.Sort();
            if(scoreboardList.Count >= 11)
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
