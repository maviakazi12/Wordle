using FluentAssertions;
using JetBrains.Annotations;
using Wordle.View;

namespace Wordle.Tests.ViewTests;

[TestSubject(typeof(InputOutput))]
public class InputOutputTest
{

    [Fact]
    public void Welcome_Should_Show_Welcome_Message_To_Console()
    {
        //Arrange
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        var inputOutput = new InputOutput();
        //Act
        inputOutput.Welcome();
        var output = stringWriter.ToString();
        //Assert
        output.Should().Contain("🎉 Welcome to Wordle! 🎉");
    }

    [Fact]
    public void GetUserInput_Should_Capture_Player_Guess_Word()
    {
        //Arrange
        var fakeInput = new StringReader("apple");
        Console.SetIn(fakeInput);

        var fakeOutput = new StringWriter();
        Console.SetOut(fakeOutput);
        
        var inputOutput = new InputOutput();
        //Act
        var userInput = inputOutput.GetUserInput();
        //Assert
        userInput.Should().Be("apple");
    }
}