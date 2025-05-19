using JetBrains.Annotations;
using Wordle.Controller;
using FluentAssertions;
using Wordle.Interfaces;
using Moq;


namespace Wordle.Tests.Controller;

[TestSubject(typeof(GameController))]
public class GameControllerTest
{

    [Fact]
    public void StartGame_Should_Get_Word_From_WordProvider()
    {
        //Arrange
        var mockWordProvider = new Mock<IWordProvider>();
        mockWordProvider.Setup(a => a.GetWord()).Returns("plate");
        var gameController = new GameController(mockWordProvider.Object);
        //Act
        var word = gameController.StartGame();
        //Assert
        word.Should().Be("plate");
    }
}