using Rps.Core.Interfaces;
using Rps.Core.Models;
using Rps.Core.Models.Enums;

namespace Rps.Core.Services.ProcessGame
{
    public class ComputerVsComputer : IProcessGame
    {
        public ScreenSetting LoadSettings()
        {
            return new ScreenSetting
            {
                IsShapesEnabled = false,
                IsTimerSet = true,

                PlayerOne = new Player
                {
                    Name = "Computer 1",
                    PlayerType = PlayerType.Computer
                },

                PlayerTwo = new Player
                {
                    Name = "Computer 2",
                    PlayerType = PlayerType.Computer
                }
            };
        }
    }
}