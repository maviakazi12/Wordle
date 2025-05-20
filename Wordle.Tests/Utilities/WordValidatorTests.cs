using FluentAssertions;
using JetBrains.Annotations;
using Wordle.Utilities;

namespace Wordle.Tests.Utilities;

[TestSubject(typeof(WordValidator))]
public class WordValidatorTests
{
    private readonly WordValidator _validator;

    public WordValidatorTests()
    {
        _validator = new WordValidator();
    }

    [Theory]
    [InlineData("apple")]
    [InlineData("grape")]
    public void IsWordValid_ReturnsTrue_ForValidWords(string word)
    {
        _validator.IsWordValid(word).Should().BeTrue();
    }

    [Theory]
    [InlineData("zzzzz")]
    [InlineData("fakee")]
    public void IsWordValid_ReturnsFalse_ForInvalidWords(string word)
    {
        _validator.IsWordValid(word).Should().BeFalse();
    }
}
