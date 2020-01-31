namespace AI_Coursework
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
            this.teamOneDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamTwoDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teamOneOrtg = new System.Windows.Forms.TextBox();
            this.teamTwoOrtg = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.teamOneCheck = new System.Windows.Forms.CheckBox();
            this.teamTwoCheck = new System.Windows.Forms.CheckBox();
            this.teamTwoDrtg = new System.Windows.Forms.TextBox();
            this.teamOneDrtg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamOneDropdown
            // 
            this.teamOneDropdown.FormattingEnabled = true;
            this.teamOneDropdown.Items.AddRange(new object[] {
            "Atlanta Hawks",
            "Boston Celtics",
            "Brooklyn Nets",
            "Charlotte Hornets",
            "Chicago Bulls",
            "Cleveland Cavaliers",
            "Dallas Mavericks",
            "Denver Nuggets",
            "Detroit Pistons",
            "Golden State Warriors",
            "Houston Rockets",
            "Indiana Pacers",
            "Los Angeles Clippers",
            "Los Angeles Lakers",
            "Memphis Grizzlies",
            "Miami Heat",
            "Milwaukee Bucks",
            "Minnesota Timberwolves",
            "New Orleans Pelicans",
            "New York Knicks",
            "Oklahoma City Thunder",
            "Orlando Magic",
            "Philadelphia 76ers",
            "Phoenix Suns",
            "Portland Trail Blazers",
            "Sacramento Kings",
            "San Antonio Spurs",
            "Toronto Raptors",
            "Utah Jazz",
            "Washington Wizards"});
            this.teamOneDropdown.Location = new System.Drawing.Point(201, 84);
            this.teamOneDropdown.Name = "teamOneDropdown";
            this.teamOneDropdown.Size = new System.Drawing.Size(121, 33);
            this.teamOneDropdown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Team Two";
            // 
            // teamTwoDropdown
            // 
            this.teamTwoDropdown.FormattingEnabled = true;
            this.teamTwoDropdown.Items.AddRange(new object[] {
            "Atlanta Hawks",
            "Boston Celtics",
            "Brooklyn Nets",
            "Charlotte Hornets",
            "Chicago Bulls",
            "Cleveland Cavaliers",
            "Dallas Mavericks",
            "Denver Nuggets",
            "Detroit Pistons",
            "Golden State Warriors",
            "Houston Rockets",
            "Indiana Pacers",
            "Los Angeles Clippers",
            "Los Angeles Lakers",
            "Memphis Grizzlies",
            "Miami Heat",
            "Milwaukee Bucks",
            "Minnesota Timberwolves",
            "New Orleans Pelicans",
            "New York Knicks",
            "Oklahoma City Thunder",
            "Orlando Magic",
            "Philadelphia 76ers",
            "Phoenix Suns",
            "Portland Trail Blazers",
            "Sacramento Kings",
            "San Antonio Spurs",
            "Toronto Raptors",
            "Utah Jazz",
            "Washington Wizards"});
            this.teamTwoDropdown.Location = new System.Drawing.Point(493, 84);
            this.teamTwoDropdown.Name = "teamTwoDropdown";
            this.teamTwoDropdown.Size = new System.Drawing.Size(121, 33);
            this.teamTwoDropdown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Offensive rating";
            // 
            // teamOneOrtg
            // 
            this.teamOneOrtg.Location = new System.Drawing.Point(201, 133);
            this.teamOneOrtg.Name = "teamOneOrtg";
            this.teamOneOrtg.Size = new System.Drawing.Size(100, 31);
            this.teamOneOrtg.TabIndex = 6;
            // 
            // teamTwoOrtg
            // 
            this.teamTwoOrtg.Location = new System.Drawing.Point(493, 132);
            this.teamTwoOrtg.Name = "teamTwoOrtg";
            this.teamTwoOrtg.Size = new System.Drawing.Size(100, 31);
            this.teamTwoOrtg.TabIndex = 7;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(319, 355);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(113, 51);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Home team";
            // 
            // teamOneCheck
            // 
            this.teamOneCheck.AutoSize = true;
            this.teamOneCheck.Location = new System.Drawing.Point(201, 239);
            this.teamOneCheck.Name = "teamOneCheck";
            this.teamOneCheck.Size = new System.Drawing.Size(28, 27);
            this.teamOneCheck.TabIndex = 10;
            this.teamOneCheck.UseVisualStyleBackColor = true;
            // 
            // teamTwoCheck
            // 
            this.teamTwoCheck.AutoSize = true;
            this.teamTwoCheck.Location = new System.Drawing.Point(493, 239);
            this.teamTwoCheck.Name = "teamTwoCheck";
            this.teamTwoCheck.Size = new System.Drawing.Size(28, 27);
            this.teamTwoCheck.TabIndex = 12;
            this.teamTwoCheck.UseVisualStyleBackColor = true;
            // 
            // teamTwoDrtg
            // 
            this.teamTwoDrtg.Location = new System.Drawing.Point(493, 182);
            this.teamTwoDrtg.Name = "teamTwoDrtg";
            this.teamTwoDrtg.Size = new System.Drawing.Size(100, 31);
            this.teamTwoDrtg.TabIndex = 15;
            // 
            // teamOneDrtg
            // 
            this.teamOneDrtg.Location = new System.Drawing.Point(201, 183);
            this.teamOneDrtg.Name = "teamOneDrtg";
            this.teamOneDrtg.Size = new System.Drawing.Size(100, 31);
            this.teamOneDrtg.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Defensive rating";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teamTwoDrtg);
            this.Controls.Add(this.teamOneDrtg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teamTwoCheck);
            this.Controls.Add(this.teamOneCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.teamTwoOrtg);
            this.Controls.Add(this.teamOneOrtg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teamTwoDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamOneDropdown);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teamOneDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox teamTwoDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teamOneOrtg;
        private System.Windows.Forms.TextBox teamTwoOrtg;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox teamOneCheck;
        private System.Windows.Forms.CheckBox teamTwoCheck;
        private System.Windows.Forms.TextBox teamTwoDrtg;
        private System.Windows.Forms.TextBox teamOneDrtg;
        private System.Windows.Forms.Label label5;
    }
}

