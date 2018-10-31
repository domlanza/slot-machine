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
        private string strPlayerInfo = null;
        private string scoreboardFilePath = "scoreboard.txt";
        StreamReader scoreboardReader;
        StreamWriter scoreboardWriter;

        public void readFile()
        {
            try
            {
                using (scoreboardReader = new StreamReader(scoreboardFilePath))
                {
                    while(scoreboardReader.ReadLine() != null )
                    {
                        strPlayerInfo = scoreboardReader.ReadLine();
                        scoreboardList.Add(strPlayerInfo);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Scoreboard not found!", "Error");
            }
            
        }

        public string displayScoreboard()
        {
            updateScoreboard(GlobalData.player.preparePlayerScore());
            string output = "";
            string[] outputArray;
            string formattedScore; 

            foreach(string score in scoreboardList)
            {
                outputArray = score.Split(',');
                formattedScore = "Player Name: " + outputArray[1] + " Score: " + outputArray[0];    
                output += formattedScore + "\n";
            }
            return output;
        }

        public void writeFile()
        {
            try
            {
                using(scoreboardWriter = new StreamWriter(scoreboardFilePath))
                {
                    foreach (string score in scoreboardList)
                    {
                        scoreboardWriter.WriteLine(score + "\n");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Scoreboard not saved.", "Error");
            }
        }

        public void updateScoreboard(string score)
        {
            readFile();
            scoreboardList.Add(score);
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
