using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var playerData = new ClassLibrary1.PlayerData();
            playerData.LoadPlayers();

            lstPlayers.DataSource = new BindingSource(playerData, null);
            lstPlayers.DisplayMember = "Value";
            lstPlayers.ValueMember = "Key";
        }

        private void playerDataBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var playerData = new ClassLibrary1.PlayerData();
            playerData.LoadPlayers();

            this.lstPlayers.DataSource = playerData;
            this.lstPlayers.DisplayMember = "Value";
            this.lstPlayers.ValueMember = "Key";
        }
    }
}
