using QuizGame;
using System;
using static QuizGame.QuizGameEngine;


namespace QuizGame
{
    public class QuizGameEngine
    {
        public QuizGameEngine(StGameConfigurations Configs)
        {
            GameConfigurations = Configs;
            
            ArrQuestions = new GameQuestion[GameConfigurations.TotalQuestions];
            InitilizeQuestions(GameConfigurations);

            if (ArrQuestions != null && ArrQuestions.Length != 0)
            {
                _CurrentQuestionNumber = 0;
            }
        }

        public QuizGameEngine(StGameConfigurations Configs, GameQuestion[] QuestionsArr)
        {
            GameConfigurations = Configs;
            
            if (QuestionsArr != null && QuestionsArr.Length == Configs.TotalQuestions)
            {
                ArrQuestions = QuestionsArr;
            }

            if (ArrQuestions != null  && ArrQuestions.Length != 0)
            {
                _CurrentQuestionNumber = 0;
            }
        }

        public enum EnQuestionSubject
        {
            Maths
        }
        public enum EnGameLevel
        {
            Easy,
            Medium,
            Hard
        }

        private void InitilizeQuestions(StGameConfigurations Configs)
        {
            for (uint i = 0; i < ArrQuestions.Length; i++)
            {
                ArrQuestions[i] = new GameQuestion(Configs.QuestionsSubject, Configs.GameLevel);   
            }
        }

        public class GameQuestion
        {
            public enum EnValidateResult
            {
                Correct,
                Wrong,
                AlreadyValidated,
                CannotValidate
            }
            public enum EnUserAnswerState
            {
                Correct,
                Wrong,
                NotAnswerd
            }

            readonly IQuestion _Question;
            public EnUserAnswerState AnswerState { private set; get; } = EnUserAnswerState.NotAnswerd;
            public string UserAnswer { private set; get; } = null;

            public GameQuestion(IQuestion Question)
            {
                _Question = Question;
            }

            public GameQuestion(EnQuestionSubject QuestionSubject, EnGameLevel QuestionLevel)
            {
                switch (QuestionSubject)
                {
                    case EnQuestionSubject.Maths:
                        _Question = new MathQuestion(QuestionLevel);
                        break;
                    default:
                        _Question = new MathQuestion(QuestionLevel);
                        break;
                }
            }

            public bool IsValidated()
            {
                return AnswerState != EnUserAnswerState.NotAnswerd;
            }

            public string[] GetMultipleChoices()
            {
                return _Question.GetMultipleChoices();
            }

            public string GetQuestionString()
            {
                return _Question.GetQuestionString();
            }

            public EnValidateResult ValidateAnswer(string Answer)
            {
                if (IsValidated())
                    return EnValidateResult.AlreadyValidated;

                UserAnswer = Answer;

                if (_Question.IsCorrectAnswer(Answer))
                {
                    AnswerState = EnUserAnswerState.Correct;
                    return EnValidateResult.Correct;
                }
                else
                {
                    AnswerState = EnUserAnswerState.Wrong;
                    return EnValidateResult.Wrong;
                }
            }

            public bool IsCorrectAnswer(string AnswerToCheck)
            {
                return _Question.IsCorrectAnswer(AnswerToCheck);
            }

            public string GetCorrectAnswer()
            {
                return _Question.GetCorrectAnswer();
            }

        } 

        public struct StGameConfigurations
        {
            public readonly EnQuestionSubject QuestionsSubject;
            public readonly EnGameLevel GameLevel;
            public readonly string PlayerName;
            public readonly uint TotalQuestions;

            public StGameConfigurations(EnQuestionSubject QuestionsSubject, EnGameLevel GameLevel
                , string PlayerName, uint TotalQuestions)
            {
                this.QuestionsSubject = QuestionsSubject;
                this.GameLevel = GameLevel;
                this.PlayerName = PlayerName;
                this.TotalQuestions = TotalQuestions;
            }
        }

        public struct StGameResults
        {
            public StGameConfigurations Configurations;
            public uint Score;
            public bool Success;

            public string GetFinalResultString()
            {
                if (Success)
                {
                    return "Successful";
                }
                else
                {
                    return "Failed";
                }
            }

            public StGameResults(StGameConfigurations Configurations, uint Score, bool Success)
            {
                this.Configurations = Configurations;
                this.Score = Score;
                this.Success = Success;
            }

        }


        public StGameConfigurations GameConfigurations { get; }
        public uint Score { private set; get; } = 0;
        public GameQuestion[] ArrQuestions { get; } = null;
        private uint? _CurrentQuestionNumber = null;
        public uint? CurrentQuestionNumber
        { 
            get
            {
                return _CurrentQuestionNumber + 1;
            }
        }



        public bool IsLastQuestion()
        {
            // note we are using a zero based indexing inside the
            // class but a one based indexing for the public use 
            return _CurrentQuestionNumber == ArrQuestions.Length - 1; 
        }

        public bool IsFirstQuestion()
        {
            // note we are using a zero based indexing inside the
            // class but a one based indexing for the public use 
            return _CurrentQuestionNumber == 0; 
        }
        
        public GameQuestion.EnValidateResult ValidateCurrentQuestion(string UserAnswer)
        {
            if (_CurrentQuestionNumber.HasValue)
            {
                var Result = ArrQuestions[_CurrentQuestionNumber.Value].ValidateAnswer(UserAnswer);

                if (Result == GameQuestion.EnValidateResult.Correct)
                    Score++;

                return Result;
            }
            else
            {
                return GameQuestion.EnValidateResult.CannotValidate;
            }
        }

        public GameQuestion GetCurrentQuestion()
        {
            if (_CurrentQuestionNumber.HasValue)
            {
                return ArrQuestions[_CurrentQuestionNumber.Value];
            }
            else
            {
                return null;
            }
        }

        public GameQuestion GoToNextQuestion()
        {
            if (!IsLastQuestion())
            {
                _CurrentQuestionNumber++;
            }
            
            return GetCurrentQuestion();
        }

        public GameQuestion GoToPreviousQuestion()
        {
            if (!IsFirstQuestion())
            {
                _CurrentQuestionNumber--;
            }

            return GetCurrentQuestion();
        }

        public bool IsFinalResultSuccessful()
        {
            return Score >= (GameConfigurations.TotalQuestions / 2.0);
        }

        public StGameResults GetResults()
        {
            return new StGameResults(GameConfigurations, Score, IsFinalResultSuccessful());
        }

    }
}
