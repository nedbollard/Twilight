using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace TwilightForm
{

    public partial class Twilight : Form
    {
        public bool newPlayerFlag = false;

        public Twilight()
        {
            InitializeComponent();
        }

        private void Twilight_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form Closing Ok");
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            var index = tabPlayer.SelectedIndex;

            // 0 = intro, 1 = player, 2 = scores !!!

            switch (index)
            {
                case 0:
                    break;
                case 1:
                    refreshNicknameListBox();
                    break;
                case 2:
                    refreshScoringTab();
                    break;
                case 3:
                    displayResultsTab();                      
                    break;

                default:
                    MessageBox.Show("You are in the Control.TabIndexChanged event. Index = " + index.ToString());
                    break;
            }

        }

        private void Twilight_Load(object sender, EventArgs e)
        {
            // load globals (settings) from a file?
        }

        private void LstBoxNickName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstBoxNickName.SelectedIndex !=-1)
            {
                //LstBoxNickName.Text = LstBoxNickName.SelectedValue.ToString();

                //MessageBox.Show(this.LstBoxNickName.Text);

                newPlayerFlag = false;

                // TEMP DUPLICATION !!!

                var playerData = new PlayerData();

                var playerList = playerData.getPlayersInList();

                // list entry is a player object ...

                var playerSelected = new Player();
                playerSelected = playerList.Find(x => x.Nickname.EndsWith(this.LstBoxNickName.Text));

                // this event is apparently being triggered @ setup ... the test value is "Classlibrary1.Player"
                // this value is displayed in the list box entries when the Messagebox is in play
                // bust is overwritten and invisible when it is not.

                if (playerSelected == null)
                {; }                                     // Null statement.  
                else
                {

                    this.lblNickname.Visible = true;
                    this.lblSurname.Visible = true;
                    this.lblForename.Visible = true;
                    this.lblHandicap.Visible = true;

                    this.txtNickname.Visible = true;
                    this.txtNickname.Enabled = false;
                    this.txtSurname.Visible = true;
                    this.txtForename.Visible = true;
                    this.txtHandicap.Visible = true;

                    this.txtNickname.Text = LstBoxNickName.Text;

                    this.txtSurname.Text = playerSelected.Surname;
                    this.txtForename.Text = playerSelected.Forename;
                    this.txtHandicap.Text = playerSelected.Handicap;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            short handicap = 0;
            if (Int16.TryParse(txtHandicap.Text, out handicap))
            {
                if ((handicap > 0) && (handicap < 40)) 
                {;}
                else
                { MessageBox.Show("Handicaps must be reasonable!"); };
            }
            else
            { MessageBox.Show("Handicaps must be integers!"); };

            var playerData = new PlayerData();
            playerData.updatePlayer(newPlayerFlag, txtNickname.Text, txtSurname.Text, txtForename.Text, txtHandicap.Text);

            // how to refresh listbox ??

            refreshNicknameListBox();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
 
            newPlayerFlag = true;

            this.txtNickname.Enabled = true;

            this.lblNickname.Visible = true;
            this.lblSurname.Visible = true;
            this.lblForename.Visible = true;
            this.lblHandicap.Visible = true;

            this.txtNickname.Visible = true;
            this.txtSurname.Visible = true;
            this.txtForename.Visible = true;
            this.txtHandicap.Visible = true;

            this.txtNickname.Text = "";
            this.txtSurname.Text = "";
            this.txtForename.Text = "";
            this.txtHandicap.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            refreshNicknameListBox();
        }


        private void grpPlayer_Leave(object sender, EventArgs e)
        {
            refreshNicknameListBox();
        }

        private void refreshNicknameListBox()
        {
            var playerData = new PlayerData();
            var playerList = playerData.getPlayersInList();

            LstBoxNickName.DataSource = playerList;

            LstBoxNickName.DisplayMember = "NickName";
            LstBoxNickName.ValueMember = "NickName";
        }

        private void refreshScoringTab()
        {

            /* when selected ..
            find round; save id; compare date with current; change => new round
            new round: increment id; determine course from date; move existing round to backup; save new round
            (may want manual override for back entry?)
            */
            string todaysDate = JulianDateConversion.ConverttoYYYYDDD(DateTime.Now);

            Round todaysRound = new Round();
            string todaysRoundDate = todaysRound.datePlayed;

            Course todaysCourse = new Course(todaysRound.courseId);

            if (todaysRoundDate == todaysDate)
            { ; }
            else
            {
                todaysRound.newRound(todaysDate);

                MessageBox.Show("New round created");
            };

            this.txtCourse.Text = todaysRound.courseId;
            this.txtDate.Text = todaysRound.datePlayed;
            this.txtRound.Text = todaysRound.roundId;

            // for now

            var playerData = new PlayerData();
            var playerList = playerData.getPlayersInList();

            LstBoxNickNameCS.DataSource = playerList;

            LstBoxNickNameCS.DisplayMember = "NickName";
            LstBoxNickNameCS.ValueMember = "NickName";


        }
        private void LstBoxNickNameCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstBoxNickNameCS.SelectedIndex != -1)
            {
                // more TEMP DUPLICATION !!!

                var playerData = new PlayerData();

                var playerList = playerData.getPlayersInList();

                // list entry is a player object ...

                var playerSelected = new Player();
                playerSelected = playerList.Find(x => x.Nickname.EndsWith(this.LstBoxNickNameCS.Text));

                // this event is apparently being triggered @ setup ... the test value is "Classlibrary1.Player"
                // this value is displayed in the list box entries when the Messagebox is in play
                // bust is overwritten and invisible when it is not.

                if (playerSelected == null)
                {; }                                     // Null statement.  
                else
                {

                    this.txtSurnameCS.Text = playerSelected.Surname;
                    this.txtForenameCS.Text = playerSelected.Forename;
                    this.txtHandicapCS.Text = playerSelected.Handicap;

                    Round todaysRound = new Round();
                    PlayerScore playerScore = new PlayerScore();

                    bool scoreExists = playerScore.getPlayerScore(todaysRound.roundId, this.LstBoxNickNameCS.Text);

                    int hole = todaysRound.firstHole;
                    string s = "";

                    for (int i = 1; i < 10; i++)
                    {
                        s = hole.ToString();

                        switch (i)
                        {
                            case 1:
                                lblHole1.Text = s;
                                break;
                            case 2:
                                lblHole2.Text = s;
                                break;
                            case 3:
                                lblHole3.Text = s;
                                break;
                            case 4:
                                lblHole4.Text = s;
                                break;
                            case 5:
                                lblHole5.Text = s;
                                break;
                            case 6:
                                lblHole6.Text = s;
                                break;
                            case 7:
                                lblHole7.Text = s;
                                break;
                            case 8:
                                lblHole8.Text = s;
                                break;
                            case 9:
                                lblHole9.Text = s;
                                break;
                            default:
                                break;

                        }

                        hole++;
                        
                    }
                    if (scoreExists)
                    {
                        scoreHole1.Text = playerScore.scoreHole1.ToString();   
                        scoreHole2.Text = playerScore.scoreHole2.ToString();
                        scoreHole3.Text = playerScore.scoreHole3.ToString();
                        scoreHole4.Text = playerScore.scoreHole4.ToString();
                        scoreHole5.Text = playerScore.scoreHole5.ToString();
                        scoreHole6.Text = playerScore.scoreHole6.ToString();
                        scoreHole7.Text = playerScore.scoreHole7.ToString();
                        scoreHole8.Text = playerScore.scoreHole8.ToString();
                        scoreHole9.Text = playerScore.scoreHole9.ToString();
                        scoreTotal.Text = playerScore.scoreTotal.ToString();
                        sfpHole1.Text = playerScore.sfpHole1.ToString();
                        sfpHole2.Text = playerScore.sfpHole2.ToString();
                        sfpHole3.Text = playerScore.sfpHole3.ToString();
                        sfpHole4.Text = playerScore.sfpHole4.ToString();
                        sfpHole5.Text = playerScore.sfpHole5.ToString();
                        sfpHole6.Text = playerScore.sfpHole6.ToString();
                        sfpHole7.Text = playerScore.sfpHole7.ToString();
                        sfpHole8.Text = playerScore.sfpHole8.ToString();
                        sfpHole9.Text = playerScore.sfpHole9.ToString();
                        sfpTotal.Text = playerScore.sfpTotal.ToString();

                    }
                    else
                    {
                        scoreHole1.Text = " ";
                        scoreHole2.Text = " ";
                        scoreHole3.Text = " ";
                        scoreHole4.Text = " ";
                        scoreHole5.Text = " ";
                        scoreHole6.Text = " ";
                        scoreHole7.Text = " ";
                        scoreHole8.Text = " ";
                        scoreHole9.Text = " ";
                        scoreTotal.Text = " ";
                        sfpTotal.Text = " ";
                        sfpHole1.Text = " ";
                        sfpHole2.Text = " ";
                        sfpHole3.Text = " ";
                        sfpHole4.Text = " ";
                        sfpHole5.Text = " ";
                        sfpHole6.Text = " ";
                        sfpHole7.Text = " ";
                        sfpHole8.Text = " ";
                        sfpHole9.Text = " ";
                        sfpTotal.Text = " ";

                    };

                }
            }
        }

        private void btnSaveCS_Click(object sender, EventArgs e)
        {
            PlayerScore currentPlayer = new PlayerScore();

            currentPlayer.RoundId = txtRound.Text;
            currentPlayer.Nickname = LstBoxNickNameCS.Text;

            currentPlayer.getPlayerScore(txtRound.Text, LstBoxNickNameCS.Text);

            bool allGood = true;
            int shots = 0;

            allGood = Int32.TryParse(scoreHole1.Text, out shots);
            if (allGood)
            {
                currentPlayer.scoreHole1 = shots;
                allGood = Int32.TryParse(scoreHole2.Text, out shots);

                if (allGood)
                {
                    currentPlayer.scoreHole2 = shots;
                    allGood = Int32.TryParse(scoreHole3.Text, out shots);

                    if (allGood)
                    {
                        currentPlayer.scoreHole3 = shots;
                        allGood = Int32.TryParse(scoreHole4.Text, out shots);

                        if (allGood)
                        {
                            currentPlayer.scoreHole4 = shots;
                            allGood = Int32.TryParse(scoreHole5.Text, out shots);
                            if (allGood)
                            {
                                currentPlayer.scoreHole5 = shots;
                                allGood = Int32.TryParse(scoreHole6.Text, out shots);

                                if (allGood)
                                {
                                    currentPlayer.scoreHole6 = shots;
                                    allGood = Int32.TryParse(scoreHole7.Text, out shots);

                                    if (allGood)
                                    {
                                        currentPlayer.scoreHole7 = shots;
                                        allGood = Int32.TryParse(scoreHole8.Text, out shots);

                                        if (allGood)
                                        {
                                            currentPlayer.scoreHole8 = shots;
                                            allGood = Int32.TryParse(scoreHole9.Text, out shots);

                                            if (allGood)
                                            {
                                                currentPlayer.scoreHole9 = shots;
                                            };
                                        };
                                    };
                                };
                            };

                        };
                    };
                };
            };

            if (allGood)
            {
                currentPlayer.CalculatePoints();

                sfpHole1.Text = currentPlayer.sfpHole1.ToString();
                sfpHole2.Text = currentPlayer.sfpHole2.ToString();
                sfpHole3.Text = currentPlayer.sfpHole3.ToString();
                sfpHole4.Text = currentPlayer.sfpHole4.ToString();
                sfpHole5.Text = currentPlayer.sfpHole5.ToString();
                sfpHole6.Text = currentPlayer.sfpHole6.ToString();
                sfpHole7.Text = currentPlayer.sfpHole7.ToString();
                sfpHole8.Text = currentPlayer.sfpHole8.ToString();
                sfpHole9.Text = currentPlayer.sfpHole9.ToString();

                currentPlayer.CalculateTotals();

                scoreTotal.Text = currentPlayer.scoreTotal.ToString();
                sfpTotal.Text = currentPlayer.sfpTotal.ToString();

                currentPlayer.updatePlayerScore();
            }
            else { MessageBox.Show("All scores need to be integers"); };

        }
        
        //Validate score input

        private void scoreHole1_Validating(object sender, CancelEventArgs e)
        {
            validateScore(lblHole1.Text, scoreHole1.Text);
        }
        private void scoreHole2_Validating(object sender, CancelEventArgs e)
        {
            validateScore(lblHole2.Text, scoreHole2.Text);
        }
        private void scoreHole3_Validating(object sender, CancelEventArgs e)
        {
            validateScore(lblHole3.Text, scoreHole3.Text);
        }
        private void scoreHole4_Validating(object sender, CancelEventArgs e)
        {
            validateScore(lblHole4.Text, scoreHole4.Text);
        }
        private void scoreHole5_Validating(object sender, CancelEventArgs e)
        {
            validateScore(lblHole5.Text, scoreHole5.Text);
        }
        private void scoreHole6_Validating(object sender, CancelEventArgs e)
        {
            validateScore(lblHole6.Text, scoreHole6.Text);
        }
        private void scoreHole7_Validating(object sender, CancelEventArgs e)
        {
            validateScore(lblHole7.Text, scoreHole7.Text);
        }
        private void scoreHole8_Validating(object sender, CancelEventArgs e)
        {
            validateScore(lblHole8.Text, scoreHole8.Text);
        }
        private void scoreHole9_Validating(object sender, CancelEventArgs e)
        {
            validateScore(lblHole9.Text, scoreHole9.Text);
        }

        private void validateScore(string hole, string score)
        // validate integer ... input is string
        // if valid calculate stabbies
        // return stabbies for display
        { 
            int iscore = 0;
            if (Int32.TryParse(score, out iscore))
            {
                ;
            }
            else
            { MessageBox.Show("Scores really must be integers please - hole (" + hole + ")"); }
            ;

        }
        public void displayResultsTab()
        {
            //need to list: PlayerScore.NickName, PlayerScore.Points, PlayerScore.Score, (Player.Handicap) in a datagridview control

            PlayerScore playerScore = new PlayerScore();

            List<PlayerResult> resultsList = playerScore.getResultsList();

            // descending handicap with descending points

            resultsList.Sort(delegate (PlayerResult x, PlayerResult y)
            {
                if (x.sfpTotal.CompareTo(y.sfpTotal) == 0)
                {
                    return y.Handicap.CompareTo(x.Handicap);
                }
                else
                {
                    return y.sfpTotal.CompareTo(x.sfpTotal);
                };
            }
            );

            //dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvResults.DataSource = resultsList;

            dgvResults.Columns[1].HeaderText = "Points";
            dgvResults.Columns[2].HeaderText = "Gross";
        }
    }
}
 