using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class FrmGamePlayScreen : Form
    {
        readonly QuizGameEngine Game;
        private RadioButton _CurrentSelectedRButtonChoice = null;
        private RadioButton _RbCorrectChoiceButton = null;

        public FrmGamePlayScreen(QuizGameEngine.StGameConfigurations Configs)
        {
            InitializeComponent();
            Game = new QuizGameEngine(Configs);
        }

        private void FrmGamePlayScreen_Load(object sender, System.EventArgs e)
        {
            LbPlayerName.Text = Game.GameConfigurations.PlayerName;
            LbScoreCounter.Text = Game.Score.ToString();

            if (Game.GameConfigurations.TotalQuestions > 0)
            {
                LoadCurrentQuestionToPlay();
            }
            else
            {
                MessageBox.Show("Hmm, What are you doing here?", "You shouldn't be here!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadRbButtonWithChoice(RadioButton RbCoiceButton, string Choice)
        {
            RbCoiceButton.Text = Choice;
            RbCoiceButton.Tag = Choice;
        }
        
        private RadioButton GetCorrectChoiceRButton()
        {
            string CorrectAnswer = 
                Game.GetCurrentQuestion().GetCorrectAnswer();

            if (RbAnswer1.Tag.ToString() == CorrectAnswer)
            {
                return RbAnswer1;
            }
            
            if (RbAnswer2.Tag.ToString() == CorrectAnswer)
            {
                return RbAnswer2;
                
            }
            
            if (RbAnswer3.Tag.ToString() == CorrectAnswer)
            {
                return RbAnswer3;
                
            }

            if (RbAnswer4.Tag.ToString() == CorrectAnswer)
            {
                return RbAnswer4;
            }

            return null;
        }

        private RadioButton GetUserChoiceRButtonFromAnswer(string UserAnswer)
        {
            if (RbAnswer1.Tag.ToString() == UserAnswer)
            {
                return RbAnswer1;
            }

            if (RbAnswer2.Tag.ToString() == UserAnswer)
            {
                return RbAnswer2;

            }

            if (RbAnswer3.Tag.ToString() == UserAnswer)
            {
                return RbAnswer3;

            }

            if (RbAnswer4.Tag.ToString() == UserAnswer)
            {
                return RbAnswer4;
            }

            return null;
        }

        private void SetCorrectChoiceRButton()
        {
            _RbCorrectChoiceButton = GetCorrectChoiceRButton();
        } 
        
        private void LoadMultipleChoices(QuizGameEngine.GameQuestion CurrentQuestion)
        {
            string[] MultipleChoices = CurrentQuestion.GetMultipleChoices();

            LoadRbButtonWithChoice(RbAnswer1, MultipleChoices[0]);
            LoadRbButtonWithChoice(RbAnswer2, MultipleChoices[1]);
            LoadRbButtonWithChoice(RbAnswer3, MultipleChoices[2]);
            LoadRbButtonWithChoice(RbAnswer4, MultipleChoices[3]);

        }

        private void LoadCurrentQuestionContent()
        {
            QuizGameEngine.GameQuestion CurrentQuestion = Game.GetCurrentQuestion();
            LbQuestionNumber.Text = $"Question {Game.CurrentQuestionNumber} out of {Game.GameConfigurations.TotalQuestions}";
            TxtQuestionString.Text = CurrentQuestion.GetQuestionString();
            LoadMultipleChoices(CurrentQuestion);
            SetCorrectChoiceRButton();

            if (CurrentQuestion.IsValidated())
            {
                _CurrentSelectedRButtonChoice = GetUserChoiceRButtonFromAnswer(CurrentQuestion.UserAnswer);
                PutQuestionInValidatedState();
            }
        }

        private void ResetChoiceButton(RadioButton RbChoiceButton)
        {
            RbChoiceButton.Text = "";
            RbChoiceButton.Tag = null;
            RbChoiceButton.Checked = false;
            RbChoiceButton.BackColor = Color.White;
        }

        private void ResetChoicesRadioButtons()
        {
            ResetChoiceButton(RbAnswer1);
            ResetChoiceButton(RbAnswer2);
            ResetChoiceButton(RbAnswer3);
            ResetChoiceButton(RbAnswer4);
        }

        private void ResetQuestion()
        {
            TxtQuestionString.Clear();
            ResetChoicesRadioButtons();
            BtnSubmit.Hide();
            GbQuestion.Enabled = true;
        }

        private void PrapareButtonNextStyle()
        {
            if (Game.IsLastQuestion())
            {
                BtnNext.Text = "Finish";
            }
            else
            {
                BtnNext.Text = "Next";
            }

            BtnNext.Enabled = Game.GetCurrentQuestion().IsValidated();
        }

        private void PrapereButtonPreviousStyle()
        {
            BtnPrevious.Enabled = !Game.IsFirstQuestion();
        }

        private void PrapereNextAndPrevButtons()
        {
            PrapareButtonNextStyle();
            PrapereButtonPreviousStyle();
        }

        private void LoadCurrentQuestionToPlay()
        {
            this.Enabled = false;
            ResetQuestion();
            LoadCurrentQuestionContent();
            PrapereNextAndPrevButtons();
            this.Enabled = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChoiceSelected(object sender, EventArgs e)
        {
            if (sender is RadioButton ChoiceButton)
            {
                BtnSubmit.Show();

                _CurrentSelectedRButtonChoice = ChoiceButton;
                
            }
        }

        private void PutQuestionInValidatedState()
        {
            switch (Game.GetCurrentQuestion().AnswerState)
            {
                case QuizGameEngine.GameQuestion.EnUserAnswerState.Correct:
                    PutQuestionInCorrectState();
                    break;
                case QuizGameEngine.GameQuestion.EnUserAnswerState.Wrong:
                    PutQuestionInWrongState();
                    break;
            }
        }

        private void PutQuestionInCorrectState()
        {
            _CurrentSelectedRButtonChoice.BackColor = Color.Green;
            _CurrentSelectedRButtonChoice.Checked = false;
            GbQuestion.Enabled = false;
        }

        private void PutQuestionInWrongState()
        {
            _CurrentSelectedRButtonChoice.BackColor = Color.Red;
            _CurrentSelectedRButtonChoice.Checked = false;
            
            _RbCorrectChoiceButton.BackColor = Color.Green;
            _RbCorrectChoiceButton.Checked = false;
           
            GbQuestion.Enabled = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            switch (Game.ValidateCurrentQuestion(_CurrentSelectedRButtonChoice.Tag.ToString()))
            {
                case QuizGameEngine.GameQuestion.EnValidateResult.Correct:
                    PutQuestionInCorrectState();
                    break;
                case QuizGameEngine.GameQuestion.EnValidateResult.Wrong:
                    PutQuestionInWrongState();
                    break;
                default:
                    MessageBox.Show("Hmm, What are you doing here?", "You shouldn't be here!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            LbScoreCounter.Text = Game.Score.ToString();
            BtnNext.Enabled = true;
        }

        private void ShowResults()
        {
            FrmGameResultScreen FResults =
                    new FrmGameResultScreen(Game.GetResults());

            FResults.ShowDialog();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!Game.IsLastQuestion())
            {
                Game.GoToNextQuestion();
                LoadCurrentQuestionToPlay();
            }
            else
            {
                ShowResults();
                this.Close();
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            Game.GoToPreviousQuestion();
            LoadCurrentQuestionToPlay();
        }
    
    }
}
