using FluentAssertions;
using JetBrains.Annotations;
using Wordle.Controller;
using Wordle.Interfaces;
using Moq;
using Moq.AutoMock;


namespace Wordle.Tests.ControllerTests;

[TestSubject(typeof(GameController))]
public class GameControllerTests
{
    private (GameController controller, AutoMocker mocker) CreateGameController()
    {
        // var gameController = new GameController(mockWordProvider.Object);
        var mocker = new AutoMocker();
        var controller = new GameController(

            mocker.Get<IWordProvider>(),
            mocker.Get<IGuessChecker>()
        );
        return (controller, mocker);
    }
    [Fact]
    public void StartGame_Returns_SecretWord_Provided_By_WordProvider()
    {
        //Arrange
        var (controller, mocker) = CreateGameController();
        mocker.GetMock<IWordProvider>().Setup(a => a.SecretWord).Returns("plate");
        //Act
        controller.StartGame();
        var word = controller.SecretWord;
        //Assert
        word.Should().Be("plate");
    }

    [Fact]
    public void StartGame_Passes_SecretWord_To_GuessCheck()
    {
        //Arrange
        var (controller, mocker) = CreateGameController();
        //Act
        controller.StartGame();
        //Assert
        mocker.GetMock<IGuessChecker>().Verify(a => a.CompareWords("plate"), Times.Once);
    }

    [Fact]
    public void StartGame_Should_Invoke_User_Input_Prompt()
    {
        
    }
}