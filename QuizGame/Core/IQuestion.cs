using System;

namespace QuizGame
{
    public interface IQuestion
    {
        string[] GetMultipleChoices();
        string GetQuestionString();
        bool IsCorrectAnswer(string AnswerToCheck);
        string GetCorrectAnswer();
    }
}
