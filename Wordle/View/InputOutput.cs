using Wordle.Interfaces;
using Wordle.Utilities;

namespace Wordle.View;

public class InputOutput : IInputOutput
{
    public void Welcome()
    {
        Console.WriteLine(PromptMessages.Welcome);
    }
}