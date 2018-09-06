using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PlayerData

    {
        private static string fileName = @"X:\data\players.txt";
        private static string backupFileName = @"X:\data\backup\players.txt";

        public static bool newPlayerFlag = false;

        public List<Player> getPlayersInList()
        {
            List<Player> playerList = new List<Player>();

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.

                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;

                    // Read and display lines from the file until the end of 
                    // the file is reached.

                    // unstring comma delimited data into a array of strings 

                    while ((line = sr.ReadLine()) != null)
                    {

                        string[] playerFields = new string[4];
                        playerFields = line.Split(',');

                        playerList.Add(new Player() { Nickname = playerFields[0], Surname = playerFields[1], Forename = playerFields[2], Handicap = playerFields[3] });  

                    }
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }

            return playerList;

        }


        public void updatePlayer(bool newPlayerFlag, string Nickname, string Surname, string Forename, string Handicap)
        {

            List<Player> playerList = new List<Player>();

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.

                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;

                    // Read and display lines from the file until the end of 
                    // the file is reached.

                    // unstring comma delimited data into a array of strings 

                    while ((line = sr.ReadLine()) != null)
                    {

                        string[] playerFields = new string[4];
                        playerFields = line.Split(',');

                        if (Nickname == playerFields[0])
                        {
                            playerList.Add(new Player() { Nickname = Nickname, Surname = Surname, Forename = Forename, Handicap = Handicap });
                            Console.WriteLine(Nickname + " ... updated");
                        }
                        else
                        {
                            playerList.Add(new Player() { Nickname = playerFields[0], Surname = playerFields[1], Forename = playerFields[2], Handicap = playerFields[3] });
                        }
                    }
                
                    // at end, add any newplayer
                    if (newPlayerFlag)
                    {
                        playerList.Add(new Player() { Nickname = Nickname, Surname = Surname, Forename = Forename, Handicap = Handicap });
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

            RefreshPlayersList(playerList);
        }

        private void RefreshPlayersList(List<Player> playerList)
        {
            //rename file with current timestamp

            try
            {
                int index = backupFileName.IndexOf(".");
                var newFileName = backupFileName.Substring(0, index) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm_ssfff") + backupFileName.Substring(index);

                File.Move(fileName, newFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be renamed/moved:");
                Console.WriteLine(ex.Message);
            }

            playerList.Sort(delegate(Player x, Player y) 
            {
                return x.Nickname.CompareTo(y.Nickname);
            }
            );

            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    foreach (var Player in playerList)
                    {
                        var playerRec = Player.Nickname + "," + Player.Surname + "," + Player.Forename + "," + Player.Handicap;

                        sw.WriteLine(playerRec);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be refreshed/rewritten:");
                Console.WriteLine(ex.Message);
            }
        }

        //public Player getPlayer(string Nickname)
        //{
        //    var player = "";

        //    return(Player);
        //}
    }
}
