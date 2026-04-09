namespace QuizGame
{
    partial class FrmGamePlayScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGamePlayScreen));
            this.LbName = new System.Windows.Forms.Label();
            this.LbScore = new System.Windows.Forms.Label();
            this.LbScoreCounter = new System.Windows.Forms.Label();
            this.LbPlayerName = new System.Windows.Forms.Label();
            this.LbQuestionNumber = new System.Windows.Forms.Label();
            this.GbQuestion = new System.Windows.Forms.GroupBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TxtQuestionString = new System.Windows.Forms.TextBox();
            this.RbAnswer1 = new System.Windows.Forms.RadioButton();
            this.RbAnswer4 = new System.Windows.Forms.RadioButton();
            this.RbAnswer2 = new System.Windows.Forms.RadioButton();
            this.RbAnswer3 = new System.Windows.Forms.RadioButton();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GbQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Transparent;
            this.LbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbName.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbName.Location = new System.Drawing.Point(12, 9);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(105, 38);
            this.LbName.TabIndex = 4;
            this.LbName.Text = "Name :";
            // 
            // LbScore
            // 
            this.LbScore.AutoSize = true;
            this.LbScore.BackColor = System.Drawing.Color.Transparent;
            this.LbScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbScore.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbScore.Location = new System.Drawing.Point(710, 9);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(108, 38);
            this.LbScore.TabIndex = 5;
            this.LbScore.Text = "Score :";
            // 
            // LbScoreCounter
            // 
            this.LbScoreCounter.BackColor = System.Drawing.Color.Transparent;
            this.LbScoreCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbScoreCounter.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScoreCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbScoreCounter.Location = new System.Drawing.Point(815, 9);
            this.LbScoreCounter.Name = "LbScoreCounter";
            this.LbScoreCounter.Size = new System.Drawing.Size(68, 38);
            this.LbScoreCounter.TabIndex = 8;
            this.LbScoreCounter.Text = "0";
            this.LbScoreCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPlayerName
            // 
            this.LbPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.LbPlayerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbPlayerName.Location = new System.Drawing.Point(113, 9);
            this.LbPlayerName.Name = "LbPlayerName";
            this.LbPlayerName.Size = new System.Drawing.Size(186, 38);
            this.LbPlayerName.TabIndex = 9;
            this.LbPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbQuestionNumber
            // 
            this.LbQuestionNumber.BackColor = System.Drawing.Color.Transparent;
            this.LbQuestionNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbQuestionNumber.Font = new System.Drawing.Font("Comic Sans MS", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQuestionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbQuestionNumber.Location = new System.Drawing.Point(174, 76);
            this.LbQuestionNumber.Name = "LbQuestionNumber";
            this.LbQuestionNumber.Size = new System.Drawing.Size(538, 57);
            this.LbQuestionNumber.TabIndex = 10;
            this.LbQuestionNumber.Text = "N/A";
            this.LbQuestionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbQuestion
            // 
            this.GbQuestion.BackColor = System.Drawing.Color.Transparent;
            this.GbQuestion.Controls.Add(this.BtnSubmit);
            this.GbQuestion.Controls.Add(this.TxtQuestionString);
            this.GbQuestion.Controls.Add(this.RbAnswer1);
            this.GbQuestion.Controls.Add(this.RbAnswer4);
            this.GbQuestion.Controls.Add(this.RbAnswer2);
            this.GbQuestion.Controls.Add(this.RbAnswer3);
            this.GbQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbQuestion.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GbQuestion.Location = new System.Drawing.Point(173, 136);
            this.GbQuestion.Name = "GbQuestion";
            this.GbQuestion.Size = new System.Drawing.Size(541, 369);
            this.GbQuestion.TabIndex = 0;
            this.GbQuestion.TabStop = false;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.White;
            this.BtnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnSubmit.FlatAppearance.BorderSize = 3;
            this.BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(428, 327);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(107, 36);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Visible = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtQuestionString
            // 
            this.TxtQuestionString.BackColor = System.Drawing.Color.White;
            this.TxtQuestionString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQuestionString.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuestionString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.TxtQuestionString.Location = new System.Drawing.Point(6, 25);
            this.TxtQuestionString.Multiline = true;
            this.TxtQuestionString.Name = "TxtQuestionString";
            this.TxtQuestionString.ReadOnly = true;
            this.TxtQuestionString.Size = new System.Drawing.Size(529, 110);
            this.TxtQuestionString.TabIndex = 5;
            this.TxtQuestionString.TabStop = false;
            this.TxtQuestionString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RbAnswer1
            // 
            this.RbAnswer1.Appearance = System.Windows.Forms.Appearance.Button;
            this.RbAnswer1.BackColor = System.Drawing.Color.White;
            this.RbAnswer1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RbAnswer1.FlatAppearance.BorderSize = 2;
            this.RbAnswer1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbAnswer1.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAnswer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RbAnswer1.Location = new System.Drawing.Point(145, 161);
            this.RbAnswer1.Name = "RbAnswer1";
            this.RbAnswer1.Size = new System.Drawing.Size(250, 36);
            this.RbAnswer1.TabIndex = 0;
            this.RbAnswer1.Text = "Answer 1";
            this.RbAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbAnswer1.UseVisualStyleBackColor = false;
            this.RbAnswer1.CheckedChanged += new System.EventHandler(this.ChoiceSelected);
            // 
            // RbAnswer4
            // 
            this.RbAnswer4.Appearance = System.Windows.Forms.Appearance.Button;
            this.RbAnswer4.BackColor = System.Drawing.Color.White;
            this.RbAnswer4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RbAnswer4.FlatAppearance.BorderSize = 2;
            this.RbAnswer4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbAnswer4.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAnswer4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RbAnswer4.Location = new System.Drawing.Point(145, 287);
            this.RbAnswer4.Name = "RbAnswer4";
            this.RbAnswer4.Size = new System.Drawing.Size(250, 36);
            this.RbAnswer4.TabIndex = 3;
            this.RbAnswer4.Text = "Answer 4";
            this.RbAnswer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbAnswer4.UseVisualStyleBackColor = false;
            this.RbAnswer4.CheckedChanged += new System.EventHandler(this.ChoiceSelected);
            // 
            // RbAnswer2
            // 
            this.RbAnswer2.Appearance = System.Windows.Forms.Appearance.Button;
            this.RbAnswer2.BackColor = System.Drawing.Color.White;
            this.RbAnswer2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RbAnswer2.FlatAppearance.BorderSize = 2;
            this.RbAnswer2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbAnswer2.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAnswer2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RbAnswer2.Location = new System.Drawing.Point(145, 203);
            this.RbAnswer2.Name = "RbAnswer2";
            this.RbAnswer2.Size = new System.Drawing.Size(250, 36);
            this.RbAnswer2.TabIndex = 1;
            this.RbAnswer2.Text = "Answer 2";
            this.RbAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbAnswer2.UseVisualStyleBackColor = false;
            this.RbAnswer2.CheckedChanged += new System.EventHandler(this.ChoiceSelected);
            // 
            // RbAnswer3
            // 
            this.RbAnswer3.Appearance = System.Windows.Forms.Appearance.Button;
            this.RbAnswer3.BackColor = System.Drawing.Color.White;
            this.RbAnswer3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RbAnswer3.FlatAppearance.BorderSize = 2;
            this.RbAnswer3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RbAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbAnswer3.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAnswer3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RbAnswer3.Location = new System.Drawing.Point(145, 245);
            this.RbAnswer3.Name = "RbAnswer3";
            this.RbAnswer3.Size = new System.Drawing.Size(250, 36);
            this.RbAnswer3.TabIndex = 2;
            this.RbAnswer3.Text = "Answer 3";
            this.RbAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbAnswer3.UseVisualStyleBackColor = false;
            this.RbAnswer3.CheckedChanged += new System.EventHandler(this.ChoiceSelected);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.White;
            this.BtnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnNext.FlatAppearance.BorderSize = 3;
            this.BtnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(605, 511);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(107, 36);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.BackColor = System.Drawing.Color.White;
            this.BtnPrevious.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnPrevious.FlatAppearance.BorderSize = 3;
            this.BtnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevious.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.Location = new System.Drawing.Point(173, 511);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(107, 36);
            this.BtnPrevious.TabIndex = 12;
            this.BtnPrevious.TabStop = false;
            this.BtnPrevious.Text = "Back";
            this.BtnPrevious.UseVisualStyleBackColor = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnExit.FlatAppearance.BorderSize = 3;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(6, 568);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(107, 36);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.TabStop = false;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmGamePlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 608);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.GbQuestion);
            this.Controls.Add(this.LbQuestionNumber);
            this.Controls.Add(this.LbPlayerName);
            this.Controls.Add(this.LbScoreCounter);
            this.Controls.Add(this.LbScore);
            this.Controls.Add(this.LbName);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGamePlayScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.FrmGamePlayScreen_Load);
            this.GbQuestion.ResumeLayout(false);
            this.GbQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbScore;
        private System.Windows.Forms.Label LbScoreCounter;
        private System.Windows.Forms.Label LbPlayerName;
        private System.Windows.Forms.Label LbQuestionNumber;
        private System.Windows.Forms.GroupBox GbQuestion;
        private System.Windows.Forms.RadioButton RbAnswer1;
        private System.Windows.Forms.RadioButton RbAnswer4;
        private System.Windows.Forms.RadioButton RbAnswer2;
        private System.Windows.Forms.RadioButton RbAnswer3;
        private System.Windows.Forms.TextBox TxtQuestionString;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnExit;
    }
}