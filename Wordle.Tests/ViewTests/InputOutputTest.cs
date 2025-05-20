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
        InputOutput.Welcome();
        var output = stringWriter.ToString();
        //Assert
        output.Should().Contain("Welcome To Wordle");
    }
}