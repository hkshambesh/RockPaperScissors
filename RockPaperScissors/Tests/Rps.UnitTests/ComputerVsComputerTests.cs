using System;
using NUnit.Framework;
using Rps.Core.Interfaces;
using Rps.Core.Models;
using Rps.Core.Models.Enums;
using Rps.Core.Services;

namespace Rps.UnitTests
{
    public class ComputerVsComputerTests
    {
        private Player _playerOne;
        private Player _playerTwo;
        private IPlayService _playService;

        [TestFixtureSetUp]
        public void Setup()
        {
            _playerOne = new Player { Name = "Computer 1", PlayerType = PlayerType.Computer};

            _playerTwo = new Player { Name = "Computer 2", PlayerType = PlayerType.Computer }; 

            _playService = new PlayService();
        }

        [TestFixtureTearDown]
        public void Cleanup()
        {
            _playerOne = null;
            _playerTwo = null;
            _playService = null;
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void When_Computer_against_Computer_Select_Shape_Test(int counter)
        {
            // act
            var playerOne = new Player
            {
                PlayerType = PlayerType.Computer
            };

            var playerTwo = new Player
            {
                PlayerType = PlayerType.Computer
            };

            IPlayService playService = new PlayService();

            // actual
            var playerOneActual = playService.Play(playerOne, counter);
            var playerTwoActual = playService.Play(playerTwo, counter);

            // assert
            Assert.IsNotNull(playerOneActual);
            Assert.IsNotNull(playerTwoActual);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Process_Result_Test_For_ComputerVsComputerTests(int counter)
        {
            // act
            string output;

            // actual
            var playerOneActual = _playService.Play(_playerOne, counter);
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