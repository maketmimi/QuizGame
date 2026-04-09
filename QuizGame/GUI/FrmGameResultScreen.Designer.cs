namespace QuizGame
{
    partial class FrmGameResultScreen
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
            this.LbPlayerName = new System.Windows.Forms.Label();
            this.TxtPlayerName = new System.Windows.Forms.TextBox();
            this.LbTitle = new System.Windows.Forms.Label();
            this.LbTotalQuestions = new System.Windows.Forms.Label();
            this.TxtTotalQuestions = new System.Windows.Forms.TextBox();
            this.LbCorrect = new System.Windows.Forms.Label();
            this.TxtCorrectAnswers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbWrong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtWrongAnswers = new System.Windows.Forms.TextBox();
            this.LbFinalResult = new System.Windows.Forms.Label();
            this.BtnCloseGame = new System.Windows.Forms.Button();
            this.BtnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbPlayerName
            // 
            this.LbPlayerName.AutoSize = true;
            this.LbPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbPlayerName.Location = new System.Drawing.Point(37, 113);
            this.LbPlayerName.Name = "LbPlayerName";
            this.LbPlayerName.Size = new System.Drawing.Size(114, 38);
            this.LbPlayerName.TabIndex = 6;
            this.LbPlayerName.Text = "Name :";
            // 
            // TxtPlayerName
            // 
            this.TxtPlayerName.BackColor = System.Drawing.Color.White;
            this.TxtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.TxtPlayerName.Location = new System.Drawing.Point(157, 115);
            this.TxtPlayerName.Name = "TxtPlayerName";
            this.TxtPlayerName.ReadOnly = true;
            this.TxtPlayerName.Size = new System.Drawing.Size(254, 34);
            this.TxtPlayerName.TabIndex = 5;
            this.TxtPlayerName.Text = "N/A";
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbTitle.Location = new System.Drawing.Point(127, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(194, 67);
            this.LbTitle.TabIndex = 7;
            this.LbTitle.Text = "Results";
            // 
            // LbTotalQuestions
            // 
            this.LbTotalQuestions.AutoSize = true;
            this.LbTotalQuestions.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbTotalQuestions.Location = new System.Drawing.Point(37, 179);
            this.LbTotalQuestions.Name = "LbTotalQuestions";
            this.LbTotalQuestions.Size = new System.Drawing.Size(225, 38);
            this.LbTotalQuestions.TabIndex = 9;
            this.LbTotalQuestions.Text = "Total Questions";
            // 
            // TxtTotalQuestions
            // 
            this.TxtTotalQuestions.BackColor = System.Drawing.Color.White;
            this.TxtTotalQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotalQuestions.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.TxtTotalQuestions.Location = new System.Drawing.Point(297, 181);
            this.TxtTotalQuestions.Name = "TxtTotalQuestions";
            this.TxtTotalQuestions.ReadOnly = true;
            this.TxtTotalQuestions.Size = new System.Drawing.Size(114, 34);
            this.TxtTotalQuestions.TabIndex = 8;
            this.TxtTotalQuestions.Text = "N/A";
            // 
            // LbCorrect
            // 
            this.LbCorrect.AutoSize = true;
            this.LbCorrect.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbCorrect.Location = new System.Drawing.Point(37, 226);
            this.LbCorrect.Name = "LbCorrect";
            this.LbCorrect.Size = new System.Drawing.Size(234, 38);
            this.LbCorrect.TabIndex = 11;
            this.LbCorrect.Text = "Correct Answers";
            // 
            // TxtCorrectAnswers
            // 
            this.TxtCorrectAnswers.BackColor = System.Drawing.Color.White;
            this.TxtCorrectAnswers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCorrectAnswers.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorrectAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.TxtCorrectAnswers.Location = new System.Drawing.Point(297, 228);
            this.TxtCorrectAnswers.Name = "TxtCorrectAnswers";
            this.TxtCorrectAnswers.ReadOnly = true;
            this.TxtCorrectAnswers.Size = new System.Drawing.Size(114, 34);
            this.TxtCorrectAnswers.TabIndex = 10;
            this.TxtCorrectAnswers.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(262, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(262, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = ":";
            // 
            // LbWrong
            // 
            this.LbWrong.AutoSize = true;
            this.LbWrong.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbWrong.Location = new System.Drawing.Point(37, 273);
            this.LbWrong.Name = "LbWrong";
            this.LbWrong.Size = new System.Drawing.Size(218, 38);
            this.LbWrong.TabIndex = 15;
            this.LbWrong.Text = "Wrong Answers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(261, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = ":";
            // 
            // TxtWrongAnswers
            // 
            this.TxtWrongAnswers.BackColor = System.Drawing.Color.White;
            this.TxtWrongAnswers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtWrongAnswers.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWrongAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.TxtWrongAnswers.Location = new System.Drawing.Point(297, 275);
            this.TxtWrongAnswers.Name = "TxtWrongAnswers";
            this.TxtWrongAnswers.ReadOnly = true;
            this.TxtWrongAnswers.Size = new System.Drawing.Size(114, 34);
            this.TxtWrongAnswers.TabIndex = 14;
            this.TxtWrongAnswers.Text = "N/A";
            // 
            // LbFinalResult
            // 
            this.LbFinalResult.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFinalResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LbFinalResult.Location = new System.Drawing.Point(78, 334);
            this.LbFinalResult.Name = "LbFinalResult";
            this.LbFinalResult.Size = new System.Drawing.Size(292, 67);
            this.LbFinalResult.TabIndex = 17;
            this.LbFinalResult.Text = "N/A";
            this.LbFinalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCloseGame
            // 
            this.BtnCloseGame.BackColor = System.Drawing.Color.White;
            this.BtnCloseGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnCloseGame.FlatAppearance.BorderSize = 3;
            this.BtnCloseGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnCloseGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCloseGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseGame.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseGame.Location = new System.Drawing.Point(43, 415);
            this.BtnCloseGame.Name = "BtnCloseGame";
            this.BtnCloseGame.Size = new System.Drawing.Size(168, 43);
            this.BtnCloseGame.TabIndex = 19;
            this.BtnCloseGame.Text = "Close Game";
            this.BtnCloseGame.UseVisualStyleBackColor = false;
            this.BtnCloseGame.Click += new System.EventHandler(this.BtnCloseGame_Click);
            // 
            // BtnPlayAgain
            // 
            this.BtnPlayAgain.BackColor = System.Drawing.Color.White;
            this.BtnPlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnPlayAgain.FlatAppearance.BorderSize = 3;
            this.BtnPlayAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnPlayAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayAgain.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayAgain.Location = new System.Drawing.Point(237, 415);
            this.BtnPlayAgain.Name = "BtnPlayAgain";
            this.BtnPlayAgain.Size = new System.Drawing.Size(168, 43);
            this.BtnPlayAgain.TabIndex = 18;
            this.BtnPlayAgain.Text = "Play Again";
            this.BtnPlayAgain.UseVisualStyleBackColor = false;
            this.BtnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // FrmGameResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 463);
            this.Controls.Add(this.BtnCloseGame);
            this.Controls.Add(this.BtnPlayAgain);
            this.Controls.Add(this.LbFinalResult);
            this.Controls.Add(this.LbWrong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtWrongAnswers);
            this.Controls.Add(this.LbCorrect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCorrectAnswers);
            this.Controls.Add(this.LbTotalQuestions);
            this.Controls.Add(this.TxtTotalQuestions);
            this.Controls.Add(this.LbPlayerName);
            this.Controls.Add(this.TxtPlayerName);
            this.Controls.Add(this.LbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGameResultScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.FrmGameResultScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbPlayerName;
        private System.Windows.Forms.TextBox TxtPlayerName;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Label LbTotalQuestions;
        private System.Windows.Forms.TextBox TxtTotalQuestions;
        private System.Windows.Forms.Label LbCorrect;
        private System.Windows.Forms.TextBox TxtCorrectAnswers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbWrong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtWrongAnswers;
        private System.Windows.Forms.Label LbFinalResult;
        private System.Windows.Forms.Button BtnCloseGame;
        private System.Windows.Forms.Button BtnPlayAgain;
    }
}