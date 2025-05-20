using Wordle.Interfaces;

namespace Wordle.Controller;

public class GameController
{
    private IWordProvider _wordProvider;
    private IGuessChecker _guessChecker;
    private string _secretWord;
    public string SecretWord => _secretWord;

    public GameController(IWordProvider wordProvider, IGuessChecker guessChecker)
    {
        _wordProvider = wordProvider;
        _guessChecker = guessChecker;
    }
    public void StartGame()
    {
        _secretWord = _wordProvider.SecretWord;
        _guessChecker.CompareWords(_secretWord);
    }
}