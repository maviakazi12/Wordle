namespace Wordle.Utilities;

public static class PromptMessages
{
    public const string Welcome = "🎉 Welcome to Wordle! 🎉\n" +
                                  "Can you guess the secret 5-letter word?\n" +
                                  "You have 6 attempts to find it.\n\n" +
                                  "🟩 = correct letter, correct position\n" +
                                  "🟨 = correct letter, wrong position\n" +
                                  "⬛ = letter not in the word\n\n" +
                                  "Good luck and have fun! 🌟\n";
}