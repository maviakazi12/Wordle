using Wordle.Interfaces;
using Wordle.Model;

namespace Wordle.Controller;

public class GuessChecker :IGuessChecker
{
    public List<LetterFeedback> CompareWords(string secretWord, string userInput)
    {
        return new List<LetterFeedback>();
    }
}