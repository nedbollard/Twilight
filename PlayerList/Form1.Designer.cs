namespace PlayerList
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.playerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPlayers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstPlayer = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataBindingSource)).BeginInit();
            this.tabPlayers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerDataBindingSource
            // 
            this.playerDataBindingSource.DataSource = typeof(ClassLibrary1.PlayerData);
            this.playerDataBindingSource.CurrentChanged += new System.EventHandler(this.playerDataBindingSource_CurrentChanged);
            // 
            // tabPlayers
            // 
            this.tabPlayers.AccessibleDescription = "Players";
            this.tabPlayers.AccessibleName = "Players";
            this.tabPlayers.Controls.Add(this.tabPage1);
            this.tabPlayers.Controls.Add(this.tabPage2);
            this.tabPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPlayers.Location = new System.Drawing.Point(0, 0);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.SelectedIndex = 0;
            this.tabPlayers.Size = new System.Drawing.Size(800, 450);
            this.tabPlayers.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lstPlayer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstPlayer
            // 
            this.lstPlayer.DataSource = this.playerDataBindingSource;
            this.lstPlayer.FormattingEnabled = true;
            this.lstPlayer.Location = new System.Drawing.Point(29, 26);
            this.lstPlayer.Name = "lstPlayer";
            this.lstPlayer.Size = new System.Drawing.Size(120, 95);
            this.lstPlayer.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(473, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPlayers);
            this.Name = "Form1";
            this.Text = "Twilight";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerDataBindingSource)).EndInit();
            this.tabPlayers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource playerDataBindingSource;
        private System.Windows.Forms.TabControl tabPlayers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPlayer;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

