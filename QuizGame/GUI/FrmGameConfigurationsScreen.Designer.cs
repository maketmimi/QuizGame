namespace QuizGame
{
    partial class FrmGameConfigurationsScreen
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
            this.LbTitle = new System.Windows.Forms.Label();
            this.TxtPlayerName = new System.Windows.Forms.TextBox();
            this.LbPlayerName = new System.Windows.Forms.Label();
            this.GbLevel = new System.Windows.Forms.GroupBox();
            this.RbHard = new System.Windows.Forms.RadioButton();
            this.RbEasy = new System.Windows.Forms.RadioButton();
            this.RbMedium = new System.Windows.Forms.RadioButton();
            this.NudTotalQuestions = new System.Windows.Forms.NumericUpDown();
            this.LbQuestionsNumber = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GbLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudTotalQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbTitle.Location = new System.Drawing.Point(24, 24);
            this.LbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(355, 67);
            this.LbTitle.TabIndex = 4;
            this.LbTitle.Text = "Configurations";
            // 
            // TxtPlayerName
            // 
            this.TxtPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPlayerName.BackColor = System.Drawing.Color.White;
            this.TxtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.TxtPlayerName.Location = new System.Drawing.Point(137, 130);
            this.TxtPlayerName.Margin = new System.Windows.Forms.Padding(0);
            this.TxtPlayerName.Name = "TxtPlayerName";
            this.TxtPlayerName.Size = new System.Drawing.Size(249, 41);
            this.TxtPlayerName.TabIndex = 0;
            // 
            // LbPlayerName
            // 
            this.LbPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbPlayerName.AutoSize = true;
            this.LbPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbPlayerName.Location = new System.Drawing.Point(17, 128);
            this.LbPlayerName.Margin = new System.Windows.Forms.Padding(0);
            this.LbPlayerName.Name = "LbPlayerName";
            this.LbPlayerName.Size = new System.Drawing.Size(114, 38);
            this.LbPlayerName.TabIndex = 3;
            this.LbPlayerName.Text = "Name :";
            // 
            // GbLevel
            // 
            this.GbLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GbLevel.Controls.Add(this.RbHard);
            this.GbLevel.Controls.Add(this.RbEasy);
            this.GbLevel.Controls.Add(this.RbMedium);
            this.GbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbLevel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GbLevel.Location = new System.Drawing.Point(93, 271);
            this.GbLevel.Margin = new System.Windows.Forms.Padding(0);
            this.GbLevel.Name = "GbLevel";
            this.GbLevel.Size = new System.Drawing.Size(216, 181);
            this.GbLevel.TabIndex = 0;
            this.GbLevel.TabStop = false;
            this.GbLevel.Text = "Level";
            // 
            // RbHard
            // 
            this.RbHard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RbHard.Appearance = System.Windows.Forms.Appearance.Button;
            this.RbHard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RbHard.FlatAppearance.BorderSize = 2;
            this.RbHard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RbHard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RbHard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RbHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbHard.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbHard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RbHard.Location = new System.Drawing.Point(27, 127);
            this.RbHard.Margin = new System.Windows.Forms.Padding(0);
            this.RbHard.Name = "RbHard";
            this.RbHard.Size = new System.Drawing.Size(163, 36);
            this.RbHard.TabIndex = 2;
            this.RbHard.Text = "Hard";
            this.RbHard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbHard.UseVisualStyleBackColor = true;
            this.RbHard.CheckedChanged += new System.EventHandler(this.LevelChanged);
            // 
            // RbEasy
            // 
            this.RbEasy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RbEasy.Appearance = System.Windows.Forms.Appearance.Button;
            this.RbEasy.Checked = true;
            this.RbEasy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RbEasy.FlatAppearance.BorderSize = 2;
            this.RbEasy.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.RbEasy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.RbEasy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.RbEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbEasy.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbEasy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RbEasy.Location = new System.Drawing.Point(27, 43);
            this.RbEasy.Margin = new System.Windows.Forms.Padding(0);
            this.RbEasy.Name = "RbEasy";
            this.RbEasy.Size = new System.Drawing.Size(163, 36);
            this.RbEasy.TabIndex = 0;
            this.RbEasy.TabStop = true;
            this.RbEasy.Text = "Easy";
            this.RbEasy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbEasy.UseVisualStyleBackColor = true;
            this.RbEasy.CheckedChanged += new System.EventHandler(this.LevelChanged);
            // 
            // RbMedium
            // 
            this.RbMedium.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RbMedium.Appearance = System.Windows.Forms.Appearance.Button;
            this.RbMedium.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RbMedium.FlatAppearance.BorderSize = 2;
            this.RbMedium.FlatAppearance.CheckedBackColor = System.Drawing.Color.Olive;
            this.RbMedium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.RbMedium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.RbMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbMedium.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMedium.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RbMedium.Location = new System.Drawing.Point(27, 85);
            this.RbMedium.Margin = new System.Windows.Forms.Padding(0);
            this.RbMedium.Name = "RbMedium";
            this.RbMedium.Size = new System.Drawing.Size(163, 36);
            this.RbMedium.TabIndex = 1;
            this.RbMedium.Text = "Medium";
            this.RbMedium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbMedium.UseVisualStyleBackColor = true;
            this.RbMedium.CheckedChanged += new System.EventHandler(this.LevelChanged);
            // 
            // NudTotalQuestions
            // 
            this.NudTotalQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NudTotalQuestions.AutoSize = true;
            this.NudTotalQuestions.BackColor = System.Drawing.Color.White;
            this.NudTotalQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudTotalQuestions.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudTotalQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.NudTotalQuestions.Location = new System.Drawing.Point(305, 200);
            this.NudTotalQuestions.Margin = new System.Windows.Forms.Padding(0);
            this.NudTotalQuestions.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudTotalQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudTotalQuestions.Name = "NudTotalQuestions";
            this.NudTotalQuestions.Size = new System.Drawing.Size(81, 45);
            this.NudTotalQuestions.TabIndex = 1;
            this.NudTotalQuestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudTotalQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LbQuestionsNumber
            // 
            this.LbQuestionsNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbQuestionsNumber.AutoSize = true;
            this.LbQuestionsNumber.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQuestionsNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbQuestionsNumber.Location = new System.Drawing.Point(17, 202);
            this.LbQuestionsNumber.Margin = new System.Windows.Forms.Padding(0);
            this.LbQuestionsNumber.Name = "LbQuestionsNumber";
            this.LbQuestionsNumber.Size = new System.Drawing.Size(282, 38);
            this.LbQuestionsNumber.TabIndex = 1;
            this.LbQuestionsNumber.Text = "Questions Number :";
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStart.BackColor = System.Drawing.Color.White;
            this.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnStart.FlatAppearance.BorderSize = 3;
            this.BtnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(214, 477);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(168, 43);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnExit.FlatAppearance.BorderSize = 3;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(20, 477);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(168, 43);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmGameConfigurationsScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 527);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LbQuestionsNumber);
            this.Controls.Add(this.NudTotalQuestions);
            this.Controls.Add(this.GbLevel);
            this.Controls.Add(this.LbPlayerName);
            this.Controls.Add(this.TxtPlayerName);
            this.Controls.Add(this.LbTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGameConfigurationsScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Configurations";
            this.GbLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudTotalQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.TextBox TxtPlayerName;
        private System.Windows.Forms.Label LbPlayerName;
        private System.Windows.Forms.GroupBox GbLevel;
        private System.Windows.Forms.RadioButton RbEasy;
        private System.Windows.Forms.RadioButton RbHard;
        private System.Windows.Forms.RadioButton RbMedium;
        private System.Windows.Forms.NumericUpDown NudTotalQuestions;
        private System.Windows.Forms.Label LbQuestionsNumber;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnExit;
    }
}