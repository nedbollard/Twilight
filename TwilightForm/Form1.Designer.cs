namespace TwilightForm
{
    partial class Twilight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.tabPlayer = new System.Windows.Forms.TabControl();
            this.tabIntro = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpPlayer = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtHandicap = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblHandicap = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblNickname = new System.Windows.Forms.Label();
            this.LstBoxNickName = new System.Windows.Forms.ListBox();
            this.tabScoring = new System.Windows.Forms.TabPage();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveCS = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.sfpTotal = new System.Windows.Forms.TextBox();
            this.scoreTotal = new System.Windows.Forms.TextBox();
            this.sfpHole9 = new System.Windows.Forms.TextBox();
            this.sfpHole8 = new System.Windows.Forms.TextBox();
            this.sfpHole7 = new System.Windows.Forms.TextBox();
            this.sfpHole6 = new System.Windows.Forms.TextBox();
            this.sfpHole5 = new System.Windows.Forms.TextBox();
            this.sfpHole4 = new System.Windows.Forms.TextBox();
            this.sfpHole3 = new System.Windows.Forms.TextBox();
            this.sfpHole2 = new System.Windows.Forms.TextBox();
            this.sfpHole1 = new System.Windows.Forms.TextBox();
            this.txtHandicapCS = new System.Windows.Forms.TextBox();
            this.scoreHole9 = new System.Windows.Forms.TextBox();
            this.scoreHole8 = new System.Windows.Forms.TextBox();
            this.scoreHole7 = new System.Windows.Forms.TextBox();
            this.scoreHole6 = new System.Windows.Forms.TextBox();
            this.scoreHole5 = new System.Windows.Forms.TextBox();
            this.scoreHole4 = new System.Windows.Forms.TextBox();
            this.scoreHole3 = new System.Windows.Forms.TextBox();
            this.scoreHole2 = new System.Windows.Forms.TextBox();
            this.scoreHole1 = new System.Windows.Forms.TextBox();
            this.lblHole9 = new System.Windows.Forms.Label();
            this.lblHole8 = new System.Windows.Forms.Label();
            this.lblHole7 = new System.Windows.Forms.Label();
            this.lblHole6 = new System.Windows.Forms.Label();
            this.lblHole5 = new System.Windows.Forms.Label();
            this.lblHole4 = new System.Windows.Forms.Label();
            this.lblHole3 = new System.Windows.Forms.Label();
            this.lblHole2 = new System.Windows.Forms.Label();
            this.lblHole1 = new System.Windows.Forms.Label();
            this.txtForenameCS = new System.Windows.Forms.TextBox();
            this.txtSurnameCS = new System.Windows.Forms.TextBox();
            this.LstBoxNickNameCS = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabPlayer.SuspendLayout();
            this.tabIntro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpPlayer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabScoring.SuspendLayout();
            this.Score.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPlayer
            // 
            this.tabPlayer.Controls.Add(this.tabIntro);
            this.tabPlayer.Controls.Add(this.tabPage1);
            this.tabPlayer.Controls.Add(this.tabScoring);
            this.tabPlayer.Controls.Add(this.tabResults);
            this.tabPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPlayer.Location = new System.Drawing.Point(0, 0);
            this.tabPlayer.Name = "tabPlayer";
            this.tabPlayer.SelectedIndex = 0;
            this.tabPlayer.Size = new System.Drawing.Size(800, 450);
            this.tabPlayer.TabIndex = 0;
            this.tabPlayer.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabIntro
            // 
            this.tabIntro.Controls.Add(this.textBox1);
            this.tabIntro.Location = new System.Drawing.Point(4, 22);
            this.tabIntro.Name = "tabIntro";
            this.tabIntro.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntro.Size = new System.Drawing.Size(792, 424);
            this.tabIntro.TabIndex = 2;
            this.tabIntro.Text = "Intro";
            this.tabIntro.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(346, 202);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "The long & winding road ...";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpPlayer);
            this.tabPage1.Controls.Add(this.LstBoxNickName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpPlayer
            // 
            this.grpPlayer.Controls.Add(this.groupBox1);
            this.grpPlayer.Controls.Add(this.txtHandicap);
            this.grpPlayer.Controls.Add(this.txtForename);
            this.grpPlayer.Controls.Add(this.txtSurname);
            this.grpPlayer.Controls.Add(this.txtNickname);
            this.grpPlayer.Controls.Add(this.lblHandicap);
            this.grpPlayer.Controls.Add(this.lblForename);
            this.grpPlayer.Controls.Add(this.lblSurname);
            this.grpPlayer.Controls.Add(this.lblNickname);
            this.grpPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPlayer.Location = new System.Drawing.Point(123, 3);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.Size = new System.Drawing.Size(666, 418);
            this.grpPlayer.TabIndex = 1;
            this.grpPlayer.TabStop = false;
            this.grpPlayer.Text = "Player Details";
            this.grpPlayer.Leave += new System.EventHandler(this.grpPlayer_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(58, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(404, 48);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(226, 48);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New Player";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtHandicap
            // 
            this.txtHandicap.Location = new System.Drawing.Point(149, 213);
            this.txtHandicap.Name = "txtHandicap";
            this.txtHandicap.Size = new System.Drawing.Size(100, 20);
            this.txtHandicap.TabIndex = 7;
            this.txtHandicap.Visible = false;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(149, 178);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 6;
            this.txtForename.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(149, 143);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 5;
            this.txtSurname.Visible = false;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(149, 77);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(100, 20);
            this.txtNickname.TabIndex = 4;
            this.txtNickname.Visible = false;
            // 
            // lblHandicap
            // 
            this.lblHandicap.AutoSize = true;
            this.lblHandicap.Location = new System.Drawing.Point(72, 220);
            this.lblHandicap.Name = "lblHandicap";
            this.lblHandicap.Size = new System.Drawing.Size(53, 13);
            this.lblHandicap.TabIndex = 3;
            this.lblHandicap.Text = "Handicap";
            this.lblHandicap.Visible = false;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(71, 185);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(54, 13);
            this.lblForename.TabIndex = 2;
            this.lblForename.Text = "Forename";
            this.lblForename.Visible = false;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(72, 150);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            this.lblSurname.Visible = false;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(67, 84);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(58, 13);
            this.lblNickname.TabIndex = 0;
            this.lblNickname.Text = "Nick name";
            this.lblNickname.Visible = false;
            // 
            // LstBoxNickName
            // 
            this.LstBoxNickName.Dock = System.Windows.Forms.DockStyle.Left;
            this.LstBoxNickName.FormattingEnabled = true;
            this.LstBoxNickName.Location = new System.Drawing.Point(3, 3);
            this.LstBoxNickName.Name = "LstBoxNickName";
            this.LstBoxNickName.Size = new System.Drawing.Size(120, 418);
            this.LstBoxNickName.TabIndex = 0;
            this.LstBoxNickName.SelectedIndexChanged += new System.EventHandler(this.LstBoxNickName_SelectedIndexChanged);
            // 
            // tabScoring
            // 
            this.tabScoring.Controls.Add(this.txtRound);
            this.tabScoring.Controls.Add(this.label4);
            this.tabScoring.Controls.Add(this.btnSaveCS);
            this.tabScoring.Controls.Add(this.Score);
            this.tabScoring.Controls.Add(this.LstBoxNickNameCS);
            this.tabScoring.Controls.Add(this.label3);
            this.tabScoring.Controls.Add(this.txtDate);
            this.tabScoring.Controls.Add(this.label2);
            this.tabScoring.Controls.Add(this.txtCourse);
            this.tabScoring.Controls.Add(this.label1);
            this.tabScoring.Location = new System.Drawing.Point(4, 22);
            this.tabScoring.Name = "tabScoring";
            this.tabScoring.Padding = new System.Windows.Forms.Padding(3);
            this.tabScoring.Size = new System.Drawing.Size(792, 424);
            this.tabScoring.TabIndex = 1;
            this.tabScoring.Text = "Capture Scores";
            this.tabScoring.UseVisualStyleBackColor = true;
            // 
            // txtRound
            // 
            this.txtRound.Enabled = false;
            this.txtRound.Location = new System.Drawing.Point(180, 98);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(100, 20);
            this.txtRound.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Round_Id";
            // 
            // btnSaveCS
            // 
            this.btnSaveCS.Location = new System.Drawing.Point(462, 393);
            this.btnSaveCS.Name = "btnSaveCS";
            this.btnSaveCS.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCS.TabIndex = 7;
            this.btnSaveCS.Text = "Save";
            this.btnSaveCS.UseVisualStyleBackColor = true;
            this.btnSaveCS.Click += new System.EventHandler(this.btnSaveCS_Click);
            // 
            // Score
            // 
            this.Score.Controls.Add(this.label15);
            this.Score.Controls.Add(this.label14);
            this.Score.Controls.Add(this.sfpTotal);
            this.Score.Controls.Add(this.scoreTotal);
            this.Score.Controls.Add(this.sfpHole9);
            this.Score.Controls.Add(this.sfpHole8);
            this.Score.Controls.Add(this.sfpHole7);
            this.Score.Controls.Add(this.sfpHole6);
            this.Score.Controls.Add(this.sfpHole5);
            this.Score.Controls.Add(this.sfpHole4);
            this.Score.Controls.Add(this.sfpHole3);
            this.Score.Controls.Add(this.sfpHole2);
            this.Score.Controls.Add(this.sfpHole1);
            this.Score.Controls.Add(this.txtHandicapCS);
            this.Score.Controls.Add(this.scoreHole9);
            this.Score.Controls.Add(this.scoreHole8);
            this.Score.Controls.Add(this.scoreHole7);
            this.Score.Controls.Add(this.scoreHole6);
            this.Score.Controls.Add(this.scoreHole5);
            this.Score.Controls.Add(this.scoreHole4);
            this.Score.Controls.Add(this.scoreHole3);
            this.Score.Controls.Add(this.scoreHole2);
            this.Score.Controls.Add(this.scoreHole1);
            this.Score.Controls.Add(this.lblHole9);
            this.Score.Controls.Add(this.lblHole8);
            this.Score.Controls.Add(this.lblHole7);
            this.Score.Controls.Add(this.lblHole6);
            this.Score.Controls.Add(this.lblHole5);
            this.Score.Controls.Add(this.lblHole4);
            this.Score.Controls.Add(this.lblHole3);
            this.Score.Controls.Add(this.lblHole2);
            this.Score.Controls.Add(this.lblHole1);
            this.Score.Controls.Add(this.txtForenameCS);
            this.Score.Controls.Add(this.txtSurnameCS);
            this.Score.Location = new System.Drawing.Point(343, 29);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(402, 358);
            this.Score.TabIndex = 6;
            this.Score.TabStop = false;
            this.Score.Text = " ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(273, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Stableford Points";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(119, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Score";
            // 
            // sfpTotal
            // 
            this.sfpTotal.Enabled = false;
            this.sfpTotal.Location = new System.Drawing.Point(276, 289);
            this.sfpTotal.Name = "sfpTotal";
            this.sfpTotal.Size = new System.Drawing.Size(100, 20);
            this.sfpTotal.TabIndex = 35;
            // 
            // scoreTotal
            // 
            this.scoreTotal.Enabled = false;
            this.scoreTotal.Location = new System.Drawing.Point(119, 289);
            this.scoreTotal.Name = "scoreTotal";
            this.scoreTotal.Size = new System.Drawing.Size(100, 20);
            this.scoreTotal.TabIndex = 34;
            // 
            // sfpHole9
            // 
            this.sfpHole9.Enabled = false;
            this.sfpHole9.Location = new System.Drawing.Point(276, 252);
            this.sfpHole9.Name = "sfpHole9";
            this.sfpHole9.Size = new System.Drawing.Size(100, 20);
            this.sfpHole9.TabIndex = 33;
            // 
            // sfpHole8
            // 
            this.sfpHole8.Enabled = false;
            this.sfpHole8.Location = new System.Drawing.Point(276, 232);
            this.sfpHole8.Name = "sfpHole8";
            this.sfpHole8.Size = new System.Drawing.Size(100, 20);
            this.sfpHole8.TabIndex = 32;
            // 
            // sfpHole7
            // 
            this.sfpHole7.Enabled = false;
            this.sfpHole7.Location = new System.Drawing.Point(276, 213);
            this.sfpHole7.Name = "sfpHole7";
            this.sfpHole7.Size = new System.Drawing.Size(100, 20);
            this.sfpHole7.TabIndex = 31;
            // 
            // sfpHole6
            // 
            this.sfpHole6.Enabled = false;
            this.sfpHole6.Location = new System.Drawing.Point(276, 196);
            this.sfpHole6.Name = "sfpHole6";
            this.sfpHole6.Size = new System.Drawing.Size(100, 20);
            this.sfpHole6.TabIndex = 30;
            // 
            // sfpHole5
            // 
            this.sfpHole5.Enabled = false;
            this.sfpHole5.Location = new System.Drawing.Point(276, 177);
            this.sfpHole5.Name = "sfpHole5";
            this.sfpHole5.Size = new System.Drawing.Size(100, 20);
            this.sfpHole5.TabIndex = 29;
            // 
            // sfpHole4
            // 
            this.sfpHole4.Enabled = false;
            this.sfpHole4.Location = new System.Drawing.Point(276, 160);
            this.sfpHole4.Name = "sfpHole4";
            this.sfpHole4.Size = new System.Drawing.Size(100, 20);
            this.sfpHole4.TabIndex = 28;
            // 
            // sfpHole3
            // 
            this.sfpHole3.Enabled = false;
            this.sfpHole3.Location = new System.Drawing.Point(276, 141);
            this.sfpHole3.Name = "sfpHole3";
            this.sfpHole3.Size = new System.Drawing.Size(100, 20);
            this.sfpHole3.TabIndex = 27;
            // 
            // sfpHole2
            // 
            this.sfpHole2.Enabled = false;
            this.sfpHole2.Location = new System.Drawing.Point(276, 121);
            this.sfpHole2.Name = "sfpHole2";
            this.sfpHole2.Size = new System.Drawing.Size(100, 20);
            this.sfpHole2.TabIndex = 26;
            // 
            // sfpHole1
            // 
            this.sfpHole1.Enabled = false;
            this.sfpHole1.Location = new System.Drawing.Point(276, 102);
            this.sfpHole1.Name = "sfpHole1";
            this.sfpHole1.Size = new System.Drawing.Size(100, 20);
            this.sfpHole1.TabIndex = 25;
            // 
            // txtHandicapCS
            // 
            this.txtHandicapCS.Enabled = false;
            this.txtHandicapCS.Location = new System.Drawing.Point(275, 20);
            this.txtHandicapCS.Name = "txtHandicapCS";
            this.txtHandicapCS.Size = new System.Drawing.Size(100, 20);
            this.txtHandicapCS.TabIndex = 10;
            // 
            // scoreHole9
            // 
            this.scoreHole9.Location = new System.Drawing.Point(119, 252);
            this.scoreHole9.Name = "scoreHole9";
            this.scoreHole9.Size = new System.Drawing.Size(100, 20);
            this.scoreHole9.TabIndex = 19;
            this.scoreHole9.Validating += new System.ComponentModel.CancelEventHandler(this.scoreHole9_Validating);
            // 
            // scoreHole8
            // 
            this.scoreHole8.Location = new System.Drawing.Point(119, 232);
            this.scoreHole8.Name = "scoreHole8";
            this.scoreHole8.Size = new System.Drawing.Size(100, 20);
            this.scoreHole8.TabIndex = 18;
            this.scoreHole8.Validating += new System.ComponentModel.CancelEventHandler(this.scoreHole8_Validating);
            // 
            // scoreHole7
            // 
            this.scoreHole7.Location = new System.Drawing.Point(119, 213);
            this.scoreHole7.Name = "scoreHole7";
            this.scoreHole7.Size = new System.Drawing.Size(100, 20);
            this.scoreHole7.TabIndex = 17;
            this.scoreHole7.Validating += new System.ComponentModel.CancelEventHandler(this.scoreHole7_Validating);
            // 
            // scoreHole6
            // 
            this.scoreHole6.Location = new System.Drawing.Point(119, 196);
            this.scoreHole6.Name = "scoreHole6";
            this.scoreHole6.Size = new System.Drawing.Size(100, 20);
            this.scoreHole6.TabIndex = 16;
            this.scoreHole6.Validating += new System.ComponentModel.CancelEventHandler(this.scoreHole6_Validating);
            // 
            // scoreHole5
            // 
            this.scoreHole5.Location = new System.Drawing.Point(119, 177);
            this.scoreHole5.Name = "scoreHole5";
            this.scoreHole5.Size = new System.Drawing.Size(100, 20);
            this.scoreHole5.TabIndex = 15;
            this.scoreHole5.Validating += new System.ComponentModel.CancelEventHandler(this.scoreHole5_Validating);
            // 
            // scoreHole4
            // 
            this.scoreHole4.Location = new System.Drawing.Point(119, 160);
            this.scoreHole4.Name = "scoreHole4";
            this.scoreHole4.Size = new System.Drawing.Size(100, 20);
            this.scoreHole4.TabIndex = 14;
            this.scoreHole4.Validating += new System.ComponentModel.CancelEventHandler(this.scoreHole4_Validating);
            // 
            // scoreHole3
            // 
            this.scoreHole3.Location = new System.Drawing.Point(119, 141);
            this.scoreHole3.Name = "scoreHole3";
            this.scoreHole3.Size = new System.Drawing.Size(100, 20);
            this.scoreHole3.TabIndex = 13;
            this.scoreHole3.Validating += new System.ComponentModel.CancelEventHandler(this.scoreHole3_Validating);
            // 
            // scoreHole2
            // 
            this.scoreHole2.Location = new System.Drawing.Point(119, 121);
            this.scoreHole2.Name = "scoreHole2";
            this.scoreHole2.Size = new System.Drawing.Size(100, 20);
            this.scoreHole2.TabIndex = 12;
            this.scoreHole2.Validating += new System.ComponentModel.CancelEventHandler(this.scoreHole2_Validating);
            // 
            // scoreHole1
            // 
            this.scoreHole1.Location = new System.Drawing.Point(119, 102);
            this.scoreHole1.Name = "scoreHole1";
            this.scoreHole1.Size = new System.Drawing.Size(100, 20);
            this.scoreHole1.TabIndex = 11;
            this.scoreHole1.Validating += new System.ComponentModel.CancelEventHandler(this.scoreHole1_Validating);
            // 
            // lblHole9
            // 
            this.lblHole9.AutoSize = true;
            this.lblHole9.Location = new System.Drawing.Point(75, 259);
            this.lblHole9.Name = "lblHole9";
            this.lblHole9.Size = new System.Drawing.Size(41, 13);
            this.lblHole9.TabIndex = 10;
            this.lblHole9.Text = "label13";
            // 
            // lblHole8
            // 
            this.lblHole8.AutoSize = true;
            this.lblHole8.Location = new System.Drawing.Point(75, 239);
            this.lblHole8.Name = "lblHole8";
            this.lblHole8.Size = new System.Drawing.Size(41, 13);
            this.lblHole8.TabIndex = 9;
            this.lblHole8.Text = "label12";
            // 
            // lblHole7
            // 
            this.lblHole7.AutoSize = true;
            this.lblHole7.Location = new System.Drawing.Point(75, 220);
            this.lblHole7.Name = "lblHole7";
            this.lblHole7.Size = new System.Drawing.Size(41, 13);
            this.lblHole7.TabIndex = 8;
            this.lblHole7.Text = "label11";
            // 
            // lblHole6
            // 
            this.lblHole6.AutoSize = true;
            this.lblHole6.Location = new System.Drawing.Point(75, 200);
            this.lblHole6.Name = "lblHole6";
            this.lblHole6.Size = new System.Drawing.Size(41, 13);
            this.lblHole6.TabIndex = 7;
            this.lblHole6.Text = "label10";
            // 
            // lblHole5
            // 
            this.lblHole5.AutoSize = true;
            this.lblHole5.Location = new System.Drawing.Point(75, 184);
            this.lblHole5.Name = "lblHole5";
            this.lblHole5.Size = new System.Drawing.Size(35, 13);
            this.lblHole5.TabIndex = 6;
            this.lblHole5.Text = "label9";
            // 
            // lblHole4
            // 
            this.lblHole4.AutoSize = true;
            this.lblHole4.Location = new System.Drawing.Point(75, 167);
            this.lblHole4.Name = "lblHole4";
            this.lblHole4.Size = new System.Drawing.Size(35, 13);
            this.lblHole4.TabIndex = 5;
            this.lblHole4.Text = "label8";
            // 
            // lblHole3
            // 
            this.lblHole3.AutoSize = true;
            this.lblHole3.Location = new System.Drawing.Point(75, 148);
            this.lblHole3.Name = "lblHole3";
            this.lblHole3.Size = new System.Drawing.Size(35, 13);
            this.lblHole3.TabIndex = 4;
            this.lblHole3.Text = "label7";
            // 
            // lblHole2
            // 
            this.lblHole2.AutoSize = true;
            this.lblHole2.Location = new System.Drawing.Point(75, 128);
            this.lblHole2.Name = "lblHole2";
            this.lblHole2.Size = new System.Drawing.Size(35, 13);
            this.lblHole2.TabIndex = 3;
            this.lblHole2.Text = "label6";
            // 
            // lblHole1
            // 
            this.lblHole1.AutoSize = true;
            this.lblHole1.Location = new System.Drawing.Point(75, 109);
            this.lblHole1.Name = "lblHole1";
            this.lblHole1.Size = new System.Drawing.Size(35, 13);
            this.lblHole1.TabIndex = 2;
            this.lblHole1.Text = "label5";
            // 
            // txtForenameCS
            // 
            this.txtForenameCS.Enabled = false;
            this.txtForenameCS.Location = new System.Drawing.Point(140, 19);
            this.txtForenameCS.Name = "txtForenameCS";
            this.txtForenameCS.Size = new System.Drawing.Size(100, 20);
            this.txtForenameCS.TabIndex = 1;
            // 
            // txtSurnameCS
            // 
            this.txtSurnameCS.Enabled = false;
            this.txtSurnameCS.Location = new System.Drawing.Point(16, 20);
            this.txtSurnameCS.Name = "txtSurnameCS";
            this.txtSurnameCS.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameCS.TabIndex = 0;
            // 
            // LstBoxNickNameCS
            // 
            this.LstBoxNickNameCS.FormattingEnabled = true;
            this.LstBoxNickNameCS.Location = new System.Drawing.Point(174, 143);
            this.LstBoxNickNameCS.Name = "LstBoxNickNameCS";
            this.LstBoxNickNameCS.Size = new System.Drawing.Size(120, 95);
            this.LstBoxNickNameCS.TabIndex = 5;
            this.LstBoxNickNameCS.SelectedIndexChanged += new System.EventHandler(this.LstBoxNickNameCS_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(180, 65);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // txtCourse
            // 
            this.txtCourse.Enabled = false;
            this.txtCourse.Location = new System.Drawing.Point(180, 29);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 20);
            this.txtCourse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course";
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.dgvResults);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(792, 424);
            this.tabResults.TabIndex = 3;
            this.tabResults.Text = "Leader Board";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToOrderColumns = true;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(3, 3);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(786, 418);
            this.dgvResults.TabIndex = 0;
            // 
            // Twilight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPlayer);
            this.Name = "Twilight";
            this.Text = "Twilight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Twilight_FormClosing);
            this.Load += new System.EventHandler(this.Twilight_Load);
            this.tabPlayer.ResumeLayout(false);
            this.tabIntro.ResumeLayout(false);
            this.tabIntro.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.grpPlayer.ResumeLayout(false);
            this.grpPlayer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabScoring.ResumeLayout(false);
            this.tabScoring.PerformLayout();
            this.Score.ResumeLayout(false);
            this.Score.PerformLayout();
            this.tabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPlayer;

        private System.Windows.Forms.TabPage tabIntro;
        private System.Windows.Forms.TextBox textBox1;
        
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpPlayer;
        private System.Windows.Forms.ListBox LstBoxNickName;

        private System.Windows.Forms.TextBox txtHandicap;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lblHandicap;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TabPage tabScoring;
        private System.Windows.Forms.Button btnSaveCS;
        private System.Windows.Forms.GroupBox Score;
        private System.Windows.Forms.ListBox LstBoxNickNameCS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHandicapCS;
        private System.Windows.Forms.TextBox scoreHole9;
        private System.Windows.Forms.TextBox scoreHole8;
        private System.Windows.Forms.TextBox scoreHole7;
        private System.Windows.Forms.TextBox scoreHole6;
        private System.Windows.Forms.TextBox scoreHole5;
        private System.Windows.Forms.TextBox scoreHole4;
        private System.Windows.Forms.TextBox scoreHole3;
        private System.Windows.Forms.TextBox scoreHole2;
        private System.Windows.Forms.TextBox scoreHole1;
        private System.Windows.Forms.Label lblHole9;
        private System.Windows.Forms.Label lblHole8;
        private System.Windows.Forms.Label lblHole7;
        private System.Windows.Forms.Label lblHole6;
        private System.Windows.Forms.Label lblHole5;
        private System.Windows.Forms.Label lblHole4;
        private System.Windows.Forms.Label lblHole3;
        private System.Windows.Forms.Label lblHole2;
        private System.Windows.Forms.Label lblHole1;
        private System.Windows.Forms.TextBox txtForenameCS;
        private System.Windows.Forms.TextBox txtSurnameCS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox sfpTotal;
        private System.Windows.Forms.TextBox scoreTotal;
        private System.Windows.Forms.TextBox sfpHole9;
        private System.Windows.Forms.TextBox sfpHole8;
        private System.Windows.Forms.TextBox sfpHole7;
        private System.Windows.Forms.TextBox sfpHole6;
        private System.Windows.Forms.TextBox sfpHole5;
        private System.Windows.Forms.TextBox sfpHole4;
        private System.Windows.Forms.TextBox sfpHole3;
        private System.Windows.Forms.TextBox sfpHole2;
        private System.Windows.Forms.TextBox sfpHole1;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}

