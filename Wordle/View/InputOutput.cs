using Wordle.Interfaces;
using Wordle.Utilities;

namespace Wordle.View;

public class InputOutput : IInputOutput
{
    private IWordValidator _wordValidator;

    public InputOutput(IWordValidator wordValidator)
    {
        _wordValidator = wordValidator;
    }
    public void Welcome()
    {
        Console.WriteLine(PromptMessages.Welcome);
    }

    public string GetUserInput()
    {
        string playerInput;
        do
        {
            Console.WriteLine(PromptMessages.GetUserInput);
            playerInput = Console.ReadLine()?.ToLower() ?? "";

            if (playerInput.Length != 5) Console.WriteLine(PromptMessages.ValidWordLengthMessage);
            if (!_wordValidator.IsWordValid(playerInput)) Console.WriteLine(PromptMessages.InvalidWord);
        } while (string.IsNullOrWhiteSpace(playerInput) || playerInput.Length != 5 || !_wordValidator.IsWordValid(playerInput));

        return playerInput;
    }
}