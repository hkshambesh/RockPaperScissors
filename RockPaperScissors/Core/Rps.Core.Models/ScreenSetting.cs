using Rps.Core.Models.Enums;

namespace Rps.Core.Models
{
    public class ScreenSetting
    {
        public ScreenSetting()
        {
            // default counter = 5
            Counter = 5;
        }

        public Player PlayerOne{ get; set; }
        public Player PlayerTwo { get; set; }
        public bool IsShapesEnabled { get; set; }
        public bool IsTimerSet { get; set; }
        public int Counter { get; set; }
    }
}