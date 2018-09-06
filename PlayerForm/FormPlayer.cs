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

namespace PlayerForm
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        public void btnPlayerUpdate_Click(object sender, EventArgs e)
        {
            var Player = new Player();

            Player.NickName = txtNickName.Text;
            Player.SurName = txtSurName.Text;
            Player.ForeName = txtForeName.Text;

            int _Handicap;
            bool OK = int.TryParse(txtHandicap.Text, out _Handicap);
            if (OK)
                {
                    Player.Handicap = _Handicap;
                }
            else
                {
                    MessageBox.Show("handicap requires an integer");
                }

            var sb = new StringBuilder();

            sb.AppendLine("Nickname = '");
            sb.Append(Player.NickName);
            sb.Append("'");

            sb.AppendLine("Surname = '");
            sb.Append(Player.SurName);
            sb.Append("'");

            sb.AppendLine("Forename = '");
            sb.Append(Player.ForeName);
            sb.Append("'");

            sb.AppendLine("Handicap = '");
            sb.Append(Player.Handicap.ToString());
            sb.Append("'");

            MessageBox.Show(sb.ToString());







        }
    }
}
