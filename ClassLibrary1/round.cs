using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Round

        // singleton?

        // dateplayed could be id surely?
        // courseId ... 1st cut ... "ohariu" plus blue of white based on odd/even day od dateplayed

    {
        private static string roundFileName = "round.txt";
        private static string fullRoundFileName = Globals.fileDirectory + roundFileName;
        private static string scoresFileName = "scores.txt";

        public string roundId { get; set; }
        public string datePlayed { get; set; }  // julian date??
        public string courseId { get; set; }
        public int firstHole { get; set; }

        // constructor reads existing round from it's file - kosher?

        public Round()
        {
            try
            {
                using (StreamReader sr = new StreamReader(fullRoundFileName))
                {
                    string line = sr.ReadLine();

                    if (string.IsNullOrEmpty(line))
                    {
                        this.roundId = "0";
                        this.datePlayed = "0000000";
                        this.courseId = "";
                        this.firstHole = 0;
                    }
                    else
                    {
                        string[] roundFields = new string[4];
                        roundFields = line.Split(',');

                        this.roundId = roundFields[0];
                        this.datePlayed = roundFields[1];
                        this.courseId = roundFields[2];
                        this.firstHole = Int32.Parse(roundFields[3]);
                    };
                                               
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.

                Console.WriteLine(roundFileName + " ... the file could not be read:");
                Console.WriteLine(ex.Message);
            }

            Globals.CourseId = this.courseId;
        }

        public void newRound(string todaysDate)
        {
            this.datePlayed = todaysDate;
            this.roundId = (Int32.Parse(this.roundId) + 1).ToString();

            string ddTodayString = DateTime.Now.ToString("dd");
            int ddTodayInt = Int32.Parse(ddTodayString);
            if ((ddTodayInt % 2) == 0)
            {
                this.courseId = "ohariu/white";
            }
            else
            {
                this.courseId = "ohariu/blue";
            };

            Course todaysCourse = new Course(this.courseId);

            this.firstHole = todaysCourse.FirstHole;

            //rename round & scores files with current timestamp

            FileHandler.BackupFile(scoresFileName);

            FileHandler.BackupFile(roundFileName);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullRoundFileName))
                {
                    var roundRec = this.roundId + "," + this.datePlayed + "," + this.courseId + "," +this.firstHole;
                    sw.WriteLine(roundRec);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(roundFileName +  "... the file could not be refreshed/rewritten:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
