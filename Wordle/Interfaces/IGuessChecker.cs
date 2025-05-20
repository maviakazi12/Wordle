using Wordle.Model;

namespace Wordle.Interfaces;

public interface IGuessChecker
{
    public List<LetterFeedback> CompareWords(string secretWord, string userInput);
}