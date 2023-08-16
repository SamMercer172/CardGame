using CardGame.Domain.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace CardGame.Application.GameEngines.Tests
{
    [TestClass()]
    public class GameCollectionTests
    {
        public static IEnumerable<object[]> GameCollectionTestData => new[] { 
            new object [] { "Test" },
            new object[] { "Game1" }, 
            new object[] { "ZGF213" }, 
            new object[] { "HYRT!2" }
        };

        [DynamicData(nameof(GameCollectionTestData))]
        [TestMethod()]
        public void IsGameIdUsed_NotInUse(string gameId)
        {
            var game = Substitute.For<IGameEngine>();
            game.GameID.Returns("NoneOfTheAbove");

            GameCollection gameCollection = new GameCollection();
            gameCollection.AddGame(game);

            Assert.IsFalse(gameCollection.IsGameIdUsed(gameId));
        }

        [DynamicData(nameof(GameCollectionTestData))]
        [TestMethod()]
        public void IsGameIdUsed_IsInUse(string gameId)
        {
            var game = Substitute.For<IGameEngine>();
            game.GameID.Returns(gameId);

            GameCollection gameCollection = new GameCollection();
            gameCollection.AddGame(game);

            Assert.IsTrue(gameCollection.IsGameIdUsed(gameId));
        }

        [DynamicData(nameof(GameCollectionTestData))]
        [TestMethod()]
        public void GetGame_ReturnsGame(string gameId)
        {
            var game = Substitute.For<IGameEngine>();
            game.GameID.Returns(gameId);

            GameCollection gameCollection = new GameCollection();
            gameCollection.AddGame(game);

            Assert.IsNotNull(gameCollection.GetGame(gameId));
        }

        [DynamicData(nameof(GameCollectionTestData))]
        [TestMethod()]
        public void GetGame_Fails(string gameId)
        {
            var game = Substitute.For<IGameEngine>();
            game.GameID.Returns("NoneOfTheAbove");

            GameCollection gameCollection = new GameCollection();
            gameCollection.AddGame(game);

            Assert.ThrowsException<GameNotFoundException>(() => gameCollection.GetGame(gameId));
        }
    }
}