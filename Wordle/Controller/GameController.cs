using Wordle.Interfaces;

namespace Wordle.Controller;

public class GameController
{
    private IWordProvider _wordProvider;
    private IGuessChecker _guessChecker;
    private IInputOutput _io;
    public string SecretWord { get; private set; }
    public string UserInput { get; private set; }
    

    public GameController(IWordProvider wordProvider, IGuessChecker guessChecker, IInputOutput inputOutput)
    {
        _wordProvider = wordProvider;
        _guessChecker = guessChecker;
        _io = inputOutput;
    }
    public void StartGame()
    {
        SecretWord = _wordProvider.SecretWord;
        UserInput = _io.GetUserInput();
        _guessChecker.CompareWords(SecretWord, UserInput);
    }
}