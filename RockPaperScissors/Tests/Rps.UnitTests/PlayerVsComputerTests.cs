using NUnit.Framework;
using Rps.Core.Interfaces;
using Rps.Core.Models;
using Rps.Core.Models.Enums;
using Rps.Core.Services;

namespace Rps.UnitTests
{
    [TestFixture]
    public class PlayerVsComputerTests
    {
        private Player _playerOne;
        private Player _playerTwo;
        private IPlayService _playService;

        [TestFixtureSetUp]
        public void Setup()
        {
            _playerOne = new Player { Name = "Player", PlayerType = PlayerType.Player };

            _playerTwo = new Player { Name = "Computer", PlayerType = PlayerType.Computer };

            _playService = new PlayService();
        }

        [TestFixtureTearDown]
        public void Cleanup()
        {
            _playerOne = null;
            _playerTwo = null;
            _playService = null;
        }

        [Test]
        public void When_Player_against_Computer_Select_Shape_Test()
        {
            // act
            var playerOne = new Player
            {
                PlayerType = PlayerType.Player
            };

            var playerTwo = new Player
            {
                PlayerType = PlayerType.Computer
            };

            IPlayService playService = new PlayService();

            // actual
            var playerOneActual = playService.Play(playerOne, 1, Shape.Paper);
            var playerTwoActual = playService.Play(playerTwo, 1);

            // assert
            Assert.AreEqual(playerOneActual, Shape.Paper);
            Assert.IsNotNull(playerTwoActual);
        }

        [TestCase(1, Shape.Paper)]
        [TestCase(2, Shape.Rock)]
        [TestCase(3, Shape.Scissors)]
        [TestCase(4, Shape.Scissors)]
        [TestCase(5, Shape.Paper)]
        public void Process_Result_Test_For_PlayerVsComputer(int counter, Shape playerOneShape)
        {
            // act
            string output;

            // actual
            var playerOneActual = _playService.Play(_playerOne, counter, playerOneShape);
            var playerTwoActual = _playService.Play(_playerTwo, counter);

            var winner = _playService.ProcessResult(_playerOne, _playerTwo, out output);

            // assert
            if (winner == null)
            {
                Assert.AreEqual("Draw, Both Lose!", output);
            }
            else
            {
                Assert.IsNotNull(winner);
                Assert.IsTrue(output.Contains("Win"));
            }
        }
    }
}