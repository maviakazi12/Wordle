using Wordle.Interfaces;
using Wordle.Utilities;
namespace Wordle.Controller;

public class WordProvider : IWordProvider
{
    private List<string> ShuffledList {get; set; } = new List<string>();
    public string SecretWord { get; private set; }

    public WordProvider()
    {
        Shuffle();
        SecretWord = GetWord();
    }

    private List<string> Shuffle()
    {
        Random rand = new Random();

        ShuffledList = new List<string>(WordList.Words);
        
        
        var i = ShuffledList.Count - 1;
        var j = rand.Next(i + 1);

        while (--i > 0)
        {
            (ShuffledList[i], ShuffledList[j]) = (ShuffledList[j], ShuffledList[i]);
        }
        return ShuffledList;

    }

    private string GetWord()
    {
        Random rand = new Random();
        var randomIndex = rand.Next(ShuffledList.Count - 1);
        SecretWord = ShuffledList[randomIndex];
        return SecretWord;
    }

}