using System;
using System.Linq;
using Rps.Core.Interfaces;
using Rps.Core.Models;
using Rps.Core.Models.Enums;

namespace Rps.Core.Services
{
    public class PlayService : IPlayService
    {
        private readonly Random _random;

        public PlayService()
        {
            _random = new Random();
        }

        public Shape Play(Player player, int counter, Shape selectedShape = Shape.Unknown)
        {
            if (player == null)
            {
                throw new NullReferenceException("Player cannot be null");
            }

            Shape outputShape;

            if (player.PlayerType == PlayerType.Player)
            {
                outputShape = selectedShape;
            }
            else
            {
                // computer player
                int randomNumber = _random.Next(1, 4);

                outputShape = (Shape)randomNumber;
            }

            player.OutputShapes.Add(counter, outputShape);

            return outputShape;
        }

        public Player ProcessResult(Player playerOne, Player playerTwo, out string output)
        {
            Shape playerOneShape = playerOne.OutputShapes.Last().Value;
            Shape playerTwoShape = playerTwo.OutputShapes.Last().Value;

            if (playerOneShape == playerTwoShape)
            {
                // no win, both equal
                output = "Draw, Both Lose!";
                return null;
            }

            if ((int)playerTwoShape % 3 + 1 == (int)playerOneShape)
            {
                output = playerOne.Name + " Wins!";
                playerOne.Score += 1;

                return playerOne;
            }

            if ((int)playerOneShape % 3 + 1 == (int)playerTwoShape)
            {
                output = playerTwo.Name + " Wins!";
                playerTwo.Score += 1;

                return playerTwo;
            }

            throw new Exception("Failed to ProcessResult");
        }
    }
}