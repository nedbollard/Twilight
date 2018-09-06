using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PlayerScore
    {
        private static string fileName = "scores.txt";
        private static string fullFileName = Globals.fileDirectory + fileName;

        public string RoundId { get; set; }
        public string Nickname { get; set; }

        public int scoreTotal { get; set; }
        public int scoreHole1 { get; set; }
        public int scoreHole2 { get; set; }
        public int scoreHole3 { get; set; }
        public int scoreHole4 { get; set; }
        public int scoreHole5 { get; set; }
        public int scoreHole6 { get; set; }
        public int scoreHole7 { get; set; }
        public int scoreHole8 { get; set; }
        public int scoreHole9 { get; set; }

        public int sfpTotal { get; set; }
        public int sfpHole1 { get; set; }
        public int sfpHole2 { get; set; }
        public int sfpHole3 { get; set; }
        public int sfpHole4 { get; set; }
        public int sfpHole5 { get; set; }
        public int sfpHole6 { get; set; }
        public int sfpHole7 { get; set; }
        public int sfpHole8 { get; set; }
        public int sfpHole9 { get; set; }

        // only default constructor

        public bool getPlayerScore(string RoundId, string Nickname)
        {
            if (File.Exists(fullFileName))
            {
                bool scoreExists = false;

                try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.

                    using (StreamReader sr = new StreamReader(fullFileName))
                    {
                        string line;

                        // Read and display lines from the file until the end of 
                        // the file is reached.

                        // unstring comma delimited data into a array of strings 

                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] scoreFields = new string[22];
                            scoreFields = line.Split(',');

                            if ((RoundId == scoreFields[0]) && (Nickname == scoreFields[1]))
                            {
                                scoreExists = true;

                                this.RoundId = scoreFields[0];
                                this.Nickname = scoreFields[1];
                                this.scoreTotal = Int32.Parse(scoreFields[2]);
                                this.scoreHole1 = Int32.Parse(scoreFields[3]);
                                this.scoreHole2 = Int32.Parse(scoreFields[4]);
                                this.scoreHole3 = Int32.Parse(scoreFields[5]);
                                this.scoreHole4 = Int32.Parse(scoreFields[6]);
                                this.scoreHole5 = Int32.Parse(scoreFields[7]);
                                this.scoreHole6 = Int32.Parse(scoreFields[8]);
                                this.scoreHole7 = Int32.Parse(scoreFields[9]);
                                this.scoreHole8 = Int32.Parse(scoreFields[10]);
                                this.scoreHole9 = Int32.Parse(scoreFields[11]);
                                this.sfpTotal = Int32.Parse(scoreFields[12]);
                                this.sfpHole1 = Int32.Parse(scoreFields[13]);
                                this.sfpHole2 = Int32.Parse(scoreFields[14]);
                                this.sfpHole3 = Int32.Parse(scoreFields[15]);
                                this.sfpHole4 = Int32.Parse(scoreFields[16]);
                                this.sfpHole5 = Int32.Parse(scoreFields[17]);
                                this.sfpHole6 = Int32.Parse(scoreFields[18]);
                                this.sfpHole7 = Int32.Parse(scoreFields[19]);
                                this.sfpHole8 = Int32.Parse(scoreFields[20]);
                                this.sfpHole9 = Int32.Parse(scoreFields[21]);
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Let the user know what went wrong.

                    Console.WriteLine(fileName + " ... file could not be read:");
                    Console.WriteLine(ex.Message);
                }

                return (scoreExists);
            }
            else
            {
                return (false);
            };
        }

        public void CalculatePoints()
        {

            PlayerData playerData = new PlayerData();
            var playerList = playerData.getPlayersInList();
            Player player = playerList.Find(x => x.Nickname == this.Nickname);
            int handicap = Int32.Parse(player.Handicap);

            Course todaysCourse = new Course(Globals.CourseId);

            this.sfpHole1 = CalculatePointsForHole(this.scoreHole1, todaysCourse.Par[0], todaysCourse.Stroke[0], handicap);
            this.sfpHole2 = CalculatePointsForHole(this.scoreHole2, todaysCourse.Par[1], todaysCourse.Stroke[1], handicap);
            this.sfpHole3 = CalculatePointsForHole(this.scoreHole3, todaysCourse.Par[2], todaysCourse.Stroke[2], handicap);
            this.sfpHole4 = CalculatePointsForHole(this.scoreHole4, todaysCourse.Par[3], todaysCourse.Stroke[3], handicap);
            this.sfpHole5 = CalculatePointsForHole(this.scoreHole5, todaysCourse.Par[4], todaysCourse.Stroke[4], handicap);
            this.sfpHole6 = CalculatePointsForHole(this.scoreHole6, todaysCourse.Par[5], todaysCourse.Stroke[5], handicap);
            this.sfpHole7 = CalculatePointsForHole(this.scoreHole7, todaysCourse.Par[6], todaysCourse.Stroke[6], handicap);
            this.sfpHole8 = CalculatePointsForHole(this.scoreHole8, todaysCourse.Par[7], todaysCourse.Stroke[7], handicap);
            this.sfpHole9 = CalculatePointsForHole(this.scoreHole9, todaysCourse.Par[8], todaysCourse.Stroke[8], handicap);

        }

        public int CalculatePointsForHole(int score, int par, int stroke , int handicap)
        {
            int points = 0;
            int shots = 0;

            if (handicap > 36)
            {
                if ((handicap - 36) >= stroke)
                { shots = 3; }
                else
                { shots = 2; };
            }
            else if (handicap > 18)
            {
                if ((handicap - 18) >= stroke)
                { shots = 3; }
                else
                { shots = 2; };
            }
            else
            {
                shots = 1;
            };

            points = Math.Max((shots + 2 + par - score),0);
  
            return (points);
        }

        public void CalculateTotals()
        {
           this.scoreTotal =  this.scoreHole1 +
                              this.scoreHole2 +
                              this.scoreHole3 +
                              this.scoreHole4 +
                              this.scoreHole5 +
                              this.scoreHole6 +
                              this.scoreHole7 +
                              this.scoreHole8 +
                              this.scoreHole9;

            this.sfpTotal = this.sfpHole1 +
                            this.sfpHole2 +
                            this.sfpHole3 +
                            this.sfpHole4 +
                            this.sfpHole5 +
                            this.sfpHole6 +
                            this.sfpHole7 +
                            this.sfpHole8 +
                            this.sfpHole9;

        }

        public void updatePlayerScore()
        {
            List<PlayerScore> playerScoreList = new List<PlayerScore>();

            bool scoreExists = false;

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.

                using (StreamReader sr = new StreamReader(fullFileName))
                {
                    string line;

                    // Read and display lines from the file until the end of 
                    // the file is reached.

                    // unstring comma delimited data into a array of strings 

                    while ((line = sr.ReadLine()) != null)
                    {

                        string[] scoreFields = new string[22];
                        scoreFields = line.Split(',');

                        if ((this.RoundId == scoreFields[0]) && (this.Nickname == scoreFields[1]))
                        {
                            scoreExists = true;

                            playerScoreList.Add(new PlayerScore()
                            {
                                RoundId = this.RoundId,
                                Nickname = this.Nickname,
                                scoreTotal = this.scoreTotal,
                                scoreHole1 = this.scoreHole1,
                                scoreHole2 = this.scoreHole2,
                                scoreHole3 = this.scoreHole3,
                                scoreHole4 = this.scoreHole4,
                                scoreHole5 = this.scoreHole5,
                                scoreHole6 = this.scoreHole6,
                                scoreHole7 = this.scoreHole7,
                                scoreHole8 = this.scoreHole8,
                                scoreHole9 = this.scoreHole9,
                                sfpTotal = this.sfpTotal,
                                sfpHole1 = this.sfpHole1,
                                sfpHole2 = this.sfpHole2,
                                sfpHole3 = this.sfpHole3,
                                sfpHole4 = this.sfpHole4,
                                sfpHole5 = this.sfpHole5,
                                sfpHole6 = this.sfpHole6,
                                sfpHole7 = this.sfpHole7,
                                sfpHole8 = this.sfpHole8,
                                sfpHole9 = this.sfpHole9
                            }
                            );

                            Console.WriteLine(RoundId + "/" + Nickname + " ... updated");
                        }
                        else
                        {
                            playerScoreList.Add(new PlayerScore()
                            {
                                RoundId = scoreFields[0],
                                Nickname = scoreFields[1],
                                scoreTotal = Int32.Parse(scoreFields[2]),
                                scoreHole1 = Int32.Parse(scoreFields[3]),
                                scoreHole2 = Int32.Parse(scoreFields[4]),
                                scoreHole3 = Int32.Parse(scoreFields[5]),
                                scoreHole4 = Int32.Parse(scoreFields[6]),
                                scoreHole5 = Int32.Parse(scoreFields[7]),
                                scoreHole6 = Int32.Parse(scoreFields[8]),
                                scoreHole7 = Int32.Parse(scoreFields[9]),
                                scoreHole8 = Int32.Parse(scoreFields[10]),
                                scoreHole9 = Int32.Parse(scoreFields[11]),
                                sfpTotal = Int32.Parse(scoreFields[12]),
                                sfpHole1 = Int32.Parse(scoreFields[13]),
                                sfpHole2 = Int32.Parse(scoreFields[14]),
                                sfpHole3 = Int32.Parse(scoreFields[15]),
                                sfpHole4 = Int32.Parse(scoreFields[16]),
                                sfpHole5 = Int32.Parse(scoreFields[17]),
                                sfpHole6 = Int32.Parse(scoreFields[18]),
                                sfpHole7 = Int32.Parse(scoreFields[19]),
                                sfpHole8 = Int32.Parse(scoreFields[20]),
                                sfpHole9 = Int32.Parse(scoreFields[21])
                            }
                                );
                        };
        
                    }

                    // at end, add any new score
                    if (scoreExists)
                    {; }
                    else
                    {
                        playerScoreList.Add(new PlayerScore()
                        {
                            RoundId = this.RoundId,
                            Nickname = this.Nickname,
                            scoreTotal = this.scoreTotal,
                            scoreHole1 = this.scoreHole1,
                            scoreHole2 = this.scoreHole2,
                            scoreHole3 = this.scoreHole3,
                            scoreHole4 = this.scoreHole4,
                            scoreHole5 = this.scoreHole5,
                            scoreHole6 = this.scoreHole6,
                            scoreHole7 = this.scoreHole7,
                            scoreHole8 = this.scoreHole8,
                            scoreHole9 = this.scoreHole9,
                            sfpTotal = this.sfpTotal,
                            sfpHole1 = this.sfpHole1,
                            sfpHole2 = this.sfpHole2,
                            sfpHole3 = this.sfpHole3,
                            sfpHole4 = this.sfpHole4,
                            sfpHole5 = this.sfpHole5,
                            sfpHole6 = this.sfpHole6,
                            sfpHole7 = this.sfpHole7,
                            sfpHole8 = this.sfpHole8,
                            sfpHole9 = this.sfpHole9

                        });
                        Console.WriteLine(Nickname + " ... added");
                    }

                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }

            RefreshPlayerScores(playerScoreList);
        }


        private void RefreshPlayerScores(List<PlayerScore> playerScoreList)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fullFileName))
                {
                    foreach (var PlayerScore in playerScoreList)
                    {
                        var playerRec =
                                PlayerScore.RoundId + "," +
                                PlayerScore.Nickname + "," +
                                PlayerScore.scoreTotal.ToString() + "," +
                                PlayerScore.scoreHole1.ToString() + "," +
                                PlayerScore.scoreHole2.ToString() + "," +
                                PlayerScore.scoreHole3.ToString() + "," +
                                PlayerScore.scoreHole4.ToString() + "," +
                                PlayerScore.scoreHole5.ToString() + "," +
                                PlayerScore.scoreHole6.ToString() + "," +
                                PlayerScore.scoreHole7.ToString() + "," +
                                PlayerScore.scoreHole8.ToString() + "," +
                                PlayerScore.scoreHole9.ToString() + "," +
                                PlayerScore.sfpTotal.ToString() + "," +
                                PlayerScore.sfpHole1.ToString() + "," +
                                PlayerScore.sfpHole2.ToString() + "," +
                                PlayerScore.sfpHole3.ToString() + "," +
                                PlayerScore.sfpHole4.ToString() + "," +
                                PlayerScore.sfpHole5.ToString() + "," +
                                PlayerScore.sfpHole6.ToString() + "," +
                                PlayerScore.sfpHole7.ToString() + "," +
                                PlayerScore.sfpHole8.ToString() + "," +
                                PlayerScore.sfpHole9.ToString()

                                ;

                        sw.WriteLine(playerRec);
                        Console.WriteLine("score written for " + PlayerScore.RoundId.ToString() + "//" + PlayerScore.Nickname.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be refreshed/rewritten:");
                Console.WriteLine(ex.Message);
            }
        }

        public List<PlayerScore> getPlayerScoreList()
        {
            List<PlayerScore> playerScoreList = new List<PlayerScore>();

            try
            {
                using (StreamReader sr = new StreamReader(fullFileName))
                {
                    string line;

                    // Read and display lines from the file until the end of 
                    // the file is reached.

                    // unstring comma delimited data into a array of strings 

                    while ((line = sr.ReadLine()) != null)
                    {

                        string[] scoreFields = new string[22];
                        scoreFields = line.Split(',');

                        playerScoreList.Add(new PlayerScore()
                        {
                            RoundId = scoreFields[0],
                            Nickname = scoreFields[1],
                            scoreTotal = Int32.Parse(scoreFields[2]),
                            scoreHole1 = Int32.Parse(scoreFields[3]),
                            scoreHole2 = Int32.Parse(scoreFields[4]),
                            scoreHole3 = Int32.Parse(scoreFields[5]),
                            scoreHole4 = Int32.Parse(scoreFields[6]),
                            scoreHole5 = Int32.Parse(scoreFields[7]),
                            scoreHole6 = Int32.Parse(scoreFields[8]),
                            scoreHole7 = Int32.Parse(scoreFields[9]),
                            scoreHole8 = Int32.Parse(scoreFields[10]),
                            scoreHole9 = Int32.Parse(scoreFields[11]),
                            sfpTotal = Int32.Parse(scoreFields[12]),
                            sfpHole1 = Int32.Parse(scoreFields[13]),
                            sfpHole2 = Int32.Parse(scoreFields[14]),
                            sfpHole3 = Int32.Parse(scoreFields[15]),
                            sfpHole4 = Int32.Parse(scoreFields[16]),
                            sfpHole5 = Int32.Parse(scoreFields[17]),
                            sfpHole6 = Int32.Parse(scoreFields[18]),
                            sfpHole7 = Int32.Parse(scoreFields[19]),
                            sfpHole8 = Int32.Parse(scoreFields[20]),
                            sfpHole9 = Int32.Parse(scoreFields[21])

                    });

                    }
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            return playerScoreList;
        }

        public List<PlayerResult> getResultsList()
        {
            List<PlayerResult> resultsList = new List<PlayerResult>();

            PlayerData playerData = new PlayerData();
            var playerList = playerData.getPlayersInList();

            try
            {
                using (StreamReader sr = new StreamReader(fullFileName))
                {
                    string line;

                    // Read and display lines from the file until the end of 
                    // the file is reached.

                    // unstring comma delimited data into a array of strings 

                    while ((line = sr.ReadLine()) != null)
                    {

                        string[] scoreFields = new string[22];
                        scoreFields = line.Split(',');

                        Player player = playerList.Find(x => x.Nickname == scoreFields[1]);
                        int handicap = Int32.Parse(player.Handicap);

                        resultsList.Add(new PlayerResult()
                        {
                            Nickname = scoreFields[1],
                            scoreTotal = Int32.Parse(scoreFields[2]),
                            sfpTotal = Int32.Parse(scoreFields[12]),
                            Handicap = handicap
                        });

                    }
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            return resultsList;
        }
    }
}
 
