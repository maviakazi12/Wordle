using Wordle.Interfaces;

namespace Wordle.Utilities;

public class WordValidator : IWordValidator
{
    private readonly HashSet<string> _validWords;
    public WordValidator()
    {
        var filePath = Path.Combine(AppContext.BaseDirectory, "Resources", "WordList.txt");
        _validWords = File.ReadAllLines(filePath).Select(word => word.Trim().ToLower()).ToHashSet();

    }

    public bool IsWordValid(string userInput)
    {
       return _validWords.Contains(userInput);
    }
}