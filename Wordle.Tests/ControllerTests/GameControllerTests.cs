using JetBrains.Annotations;
using Wordle.Controller;
using FluentAssertions;
using Wordle.Interfaces;
using Moq;


namespace Wordle.Tests.Controller;

[TestSubject(typeof(GameController))]
public class GameControllerTests
{

    [Fact]
    public void StartGame_ReturnsWordProvidedByWordProvider()
    {
        //Arrange
        var mockWordProvider = new Mock<IWordProvider>();
        mockWordProvider.Setup(a => a.SecretWord).Returns("plate");
        var gameController = new GameController(mockWordProvider.Object);
        //Act
        gameController.StartGame();
        var word = gameController.SecretWord;
        //Assert
        word.Should().Be("plate");
    }
}