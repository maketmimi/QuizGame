using System.Windows.Forms;

namespace QuizGame
{
    public partial class FrmGameResultScreen : Form
    {
        private readonly QuizGameEngine.StGameResults _ResultsToShow;

        public FrmGameResultScreen(QuizGameEngine.StGameResults ResultsToShow)
        {
            InitializeComponent();
            _ResultsToShow = ResultsToShow;
        }

        private void FrmGameResultScreen_Load(object sender, System.EventArgs e)
        {
            TxtPlayerName.Text = _ResultsToShow.Configurations.PlayerName;
            TxtTotalQuestions.Text = _ResultsToShow.Configurations.TotalQuestions.ToString();
            TxtCorrectAnswers.Text = _ResultsToShow.Score.ToString();
            TxtWrongAnswers.Text = (_ResultsToShow.Configurations.TotalQuestions - _ResultsToShow.Score).ToString();
            LbFinalResult.Text = _ResultsToShow.GetFinalResultString();
        }

        private void BtnCloseGame_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPlayAgain_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    
    }
}
