namespace PlayerForm
{
    partial class FormPlayer
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
            this.lblHead1 = new System.Windows.Forms.Label();
            this.lblHead2 = new System.Windows.Forms.Label();
            this.NickName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblHandicap = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtForeName = new System.Windows.Forms.TextBox();
            this.txtHandicap = new System.Windows.Forms.TextBox();
            this.btnPlayerUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHead1
            // 
            this.lblHead1.AutoSize = true;
            this.lblHead1.Location = new System.Drawing.Point(13, 22);
            this.lblHead1.Name = "lblHead1";
            this.lblHead1.Size = new System.Drawing.Size(43, 13);
            this.lblHead1.TabIndex = 0;
            this.lblHead1.Text = "Twilight";
            // 
            // lblHead2
            // 
            this.lblHead2.AutoSize = true;
            this.lblHead2.Location = new System.Drawing.Point(12, 45);
            this.lblHead2.Name = "lblHead2";
            this.lblHead2.Size = new System.Drawing.Size(101, 13);
            this.lblHead2.TabIndex = 1;
            this.lblHead2.Text = "Player Maintenance";
            // 
            // NickName
            // 
            this.NickName.AutoSize = true;
            this.NickName.Location = new System.Drawing.Point(113, 94);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(60, 13);
            this.NickName.TabIndex = 2;
            this.NickName.Text = "Nick Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(124, 134);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(119, 166);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(54, 13);
            this.lblForename.TabIndex = 4;
            this.lblForename.Text = "Forename";
            // 
            // lblHandicap
            // 
            this.lblHandicap.AutoSize = true;
            this.lblHandicap.Location = new System.Drawing.Point(120, 202);
            this.lblHandicap.Name = "lblHandicap";
            this.lblHandicap.Size = new System.Drawing.Size(53, 13);
            this.lblHandicap.TabIndex = 5;
            this.lblHandicap.Text = "Handicap";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(207, 86);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(100, 20);
            this.txtNickName.TabIndex = 6;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(207, 127);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(100, 20);
            this.txtSurName.TabIndex = 7;
            // 
            // txtForeName
            // 
            this.txtForeName.Location = new System.Drawing.Point(207, 159);
            this.txtForeName.Name = "txtForeName";
            this.txtForeName.Size = new System.Drawing.Size(100, 20);
            this.txtForeName.TabIndex = 8;
            // 
            // txtHandicap
            // 
            this.txtHandicap.Location = new System.Drawing.Point(207, 199);
            this.txtHandicap.Name = "txtHandicap";
            this.txtHandicap.Size = new System.Drawing.Size(100, 20);
            this.txtHandicap.TabIndex = 9;
            // 
            // btnPlayerUpdate
            // 
            this.btnPlayerUpdate.Location = new System.Drawing.Point(190, 244);
            this.btnPlayerUpdate.Name = "btnPlayerUpdate";
            this.btnPlayerUpdate.Size = new System.Drawing.Size(117, 23);
            this.btnPlayerUpdate.TabIndex = 10;
            this.btnPlayerUpdate.Text = "Click to Add/Update";
            this.btnPlayerUpdate.UseVisualStyleBackColor = true;
            this.btnPlayerUpdate.Click += new System.EventHandler(this.btnPlayerUpdate_Click);
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlayerUpdate);
            this.Controls.Add(this.txtHandicap);
            this.Controls.Add(this.txtForeName);
            this.Controls.Add(this.txtSurName);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.lblHandicap);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.lblHead2);
            this.Controls.Add(this.lblHead1);
            this.Name = "FormPlayer";
            this.Text = "Player Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead1;
        private System.Windows.Forms.Label lblHead2;
        private System.Windows.Forms.Label NickName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblHandicap;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtForeName;
        private System.Windows.Forms.TextBox txtHandicap;
        private System.Windows.Forms.Button btnPlayerUpdate;
    }
}

