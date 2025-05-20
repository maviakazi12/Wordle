namespace Wordle.Interfaces;

public interface IWordValidator
{
    public bool IsWordValid(string userInput);
}