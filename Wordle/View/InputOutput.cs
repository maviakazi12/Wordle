using Wordle.Interfaces;
using Wordle.Utilities;

namespace Wordle.View;

public class InputOutput : IInputOutput
{
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
        } while (string.IsNullOrWhiteSpace(playerInput));

        return playerInput;
    }
}