using Rps.Core.Interfaces;
using Rps.Core.Models;
using Rps.Core.Models.Enums;

namespace Rps.Core.Services.ProcessGame
{
    public class PlayerVsComputer : IProcessGame
    {
        public ScreenSetting LoadSettings()
        {
            return  new ScreenSetting
            {
                IsShapesEnabled = true,
                IsTimerSet = false,

                PlayerOne = new Player
                {
                    Name = "Player (You)",
                    PlayerType = PlayerType.Player
                },

                PlayerTwo = new Player
                {
                    Name = "Computer",
                    PlayerType = PlayerType.Computer
                }
            };
        }
    }
}