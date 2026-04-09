using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class FrmStartScreen : Form
    {
        public FrmStartScreen()
        {
            InitializeComponent();
        }

        private FrmAboutScreen AboutScreen = null;

        private void PutButtonInNormalState(Button ScreenButton)
        {
            ScreenButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
        }

        private void ButtonsMouseEnter(object sender, EventArgs e)
        {
            if (sender is Button ScreenButton)
            {
                ScreenButton.FlatAppearance.BorderColor = Color.Navy;
            }
        }

        private void ButtonsMouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button ScreenButton)
            {
                ScreenButton.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void Restore_Buttons(object sender, EventArgs e)
        {
            if (sender is Button ScreenButton)
            {
                PutButtonInNormalState(ScreenButton);
            }
        }
        
        private void Restore_Buttons(object sender, MouseEventArgs e)
        {
            Restore_Buttons(sender, (EventArgs) e);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            FrmGameConfigurationsScreen FConfigs = new FrmGameConfigurationsScreen();

            this.Hide();
            FConfigs.ShowDialog();
            this.Show();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            if (AboutScreen != null && AboutScreen.Visible)
            {
                return;
            }

            AboutScreen = new FrmAboutScreen();
            AboutScreen.Show();
        }
    
    }
}
