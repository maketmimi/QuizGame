using QuestionsGame;
using SimpleCalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace QuizGame
{
    internal class MathQuestion : IQuestion
    {
        private static readonly Random Rnd = new Random();

        private readonly Dictionary<Calculator.EnOperations, string> OperationToSymbol =
            new Dictionary<Calculator.EnOperations, string>()
        {
            {Calculator.EnOperations.Add, "+" },
            {Calculator.EnOperations.Subtract, "-" },
            {Calculator.EnOperations.Multiply, "×" },
            {Calculator.EnOperations.Divide, "÷" },
            {Calculator.EnOperations.Mod, "Mod" }
        };

        public int Number1 { get; }
        public int Number2 { get; }
        public int Answer { get; }
        public Calculator.EnOperations Operation { get; }
        public string[] MultipleChoices { get; }

        public MathQuestion(int Number1, int Number2, Calculator.EnOperations Operation)
        {
            this.Number1 = Number1;
            this.Number2 = Number2;
            this.Operation = Operation;

            Calculator clc = new Calculator();
            clc.Add(this.Number1);
            clc.PerformOperation(this.Number2, this.Operation);

            Answer = ((int)clc.Result);

            MultipleChoices = new string[4];
            MultipleChoices[0] = Answer.ToString();


            for (uint i = 1; i < MultipleChoices.Length; i++)
            {
                MultipleChoices[i] = GetUniqueRandomChoice(MultipleChoices, Answer - 10, Answer + 10);
            }

            ArrayHelpers.ShuffleArray(MultipleChoices);
        }

        public MathQuestion(int Number1, int Number2, Calculator.EnOperations Operation, string[] MultipleChoices)
        {
            this.Number1 = Number1;
            this.Number2 = Number2;
            this.Operation = Operation;
            this.MultipleChoices = MultipleChoices;

            Calculator clc = new Calculator();
            clc.Add(this.Number1);
            clc.PerformOperation(this.Number2, this.Operation);
        }

        public MathQuestion(QuizGameEngine.EnGameLevel Level)
        {
            MathQuestion Question = GetMathQuestionInLevel(Level);

            this.Number1 = Question.Number1;
            this.Number2 = Question.Number2;
            this.Answer = Question.Answer;
            this.Operation = Question.Operation;
            this.MultipleChoices = Question.MultipleChoices;
        }

        private static MathQuestion GetMathQuestionInRange(int From, int To)
        {
            int Number1 = MathQuestion.Rnd.Next(From, To);
            int Number2;

            Calculator.EnOperations Operation =
                (Calculator.EnOperations) MathQuestion.Rnd.Next(((byte)Calculator.EnOperations.Add)
                , ((byte)Calculator.EnOperations.Divide));


            if (Operation == Calculator.EnOperations.Divide)
            {
                do
                {
                    Number2 = MathQuestion.Rnd.Next(From, To);
                }
                while (Number2 == 0);
            }
            else
            {
                Number2 = MathQuestion.Rnd.Next(From, To);
            }

            return new MathQuestion(Number1, Number2, Operation);
        }

        private static MathQuestion GetMathQuestionInLevel(QuizGameEngine.EnGameLevel Level)
        {
            switch (Level)
            {
                case QuizGameEngine.EnGameLevel.Easy:
                    return GetMathQuestionInRange(0, 10);
                case QuizGameEngine.EnGameLevel.Medium:
                    return GetMathQuestionInRange(0, 100);
                case QuizGameEngine.EnGameLevel.Hard:
                    return GetMathQuestionInRange(0, 1000);
                default:
                    return GetMathQuestionInRange(0, 10);
            }
        }
          
        private string GetUniqueRandomChoice(string[] ChoicesArr, int From, int To)
        {
            string UniqueChoice;

            do
            {
                UniqueChoice = Rnd.Next(From, To).ToString();
            }
            while (ChoicesArr.Contains(UniqueChoice));

            return UniqueChoice;
        }

        public bool IsCorrectAnswer(string AnswerToCheck)
        {
            if (int.TryParse(AnswerToCheck, out int Answer))
            {
                return Answer == this.Answer;
            }

            return false;
        }

        public string GetQuestionString()
        {
            StringBuilder QuestionString = new StringBuilder();
            string Operation;

            if (Enum.IsDefined(typeof(Calculator.EnOperations), this.Operation))
            {
                Operation = OperationToSymbol[this.Operation];                
            }
            else
            {
                Operation = "?";
            }

                QuestionString.AppendLine("What is");
            QuestionString.AppendLine($"{Number1} {Operation} {Number2}");

            return QuestionString.ToString();
        }

        public string[] GetMultipleChoices()
        {
            return MultipleChoices;
        }
    
        public string GetCorrectAnswer()
        {

            return this.Answer.ToString();

        }

    }
}
