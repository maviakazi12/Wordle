using Wordle.Interfaces;

namespace Wordle.Controller;

public class GameController
{
    private IWordProvider _wordProvider;
    private string _secretWord;
    public string SecretWord => _secretWord;

    public GameController(IWordProvider wordProvider)
    {
        _wordProvider = wordProvider;
    }
    public void StartGame()
    {
        _secretWord = _wordProvider.SecretWord;
    }
}