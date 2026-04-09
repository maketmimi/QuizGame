using System.Windows.Forms;

namespace QuizGame
{
    public partial class FrmGameConfigurationsScreen : Form
    {
        public FrmGameConfigurationsScreen()
        {
            InitializeComponent();
            InitializeLevelButtons();
        }

        private void InitializeLevelButtons()
        {
            RbEasy.Tag = QuizGameEngine.EnGameLevel.Easy;
            RbMedium.Tag = QuizGameEngine.EnGameLevel.Medium;
            RbHard.Tag = QuizGameEngine.EnGameLevel.Hard;
        }


        private QuizGameEngine.EnGameLevel _SelectedLevel = 
            QuizGameEngine.EnGameLevel.Easy;


        private QuizGameEngine.StGameConfigurations GetCurrentConfigs()
        {
            return new QuizGameEngine.StGameConfigurations
                (QuizGameEngine.EnQuestionSubject.Maths
                , _SelectedLevel, TxtPlayerName.Text, ((uint)NudTotalQuestions.Value));
        }

        // "true" indicating no problems
        private bool CheckEmptyInputFields()
        {
            if (string.IsNullOrEmpty(TxtPlayerName.Text))
            {
                MessageBox.Show("Cannot leave fields empty!", "Empty Fields!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }

        // "true" indicating no problems
        private bool CheckInputErrors()
        {

            return CheckEmptyInputFields();

        }

        private void LevelChanged(object sender, System.EventArgs e)
        {
            if (sender is RadioButton LevelButton)
            {
                _SelectedLevel = (QuizGameEngine.EnGameLevel) LevelButton.Tag;
            }
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnStart_Click(object sender, System.EventArgs e)
        {
            if (CheckInputErrors())
            {
                FrmGamePlayScreen FGamePlay = new FrmGamePlayScreen(GetCurrentConfigs());

                this.Hide();
                FGamePlay.ShowDialog();
                this.Close();
            }
        }
    
    }
}
