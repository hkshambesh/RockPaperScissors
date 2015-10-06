using System.Collections.Generic;
using Rps.Core.Models.Enums;

namespace Rps.Core.Models
{
    public class Player
    {
        public Player()
        {
            Score = 0;

            // store result for each game count
            OutputShapes = new Dictionary<int, Shape>();
        }

        public string Name { get; set; }
        public PlayerType PlayerType { get; set; }
        public int Score { get; set; }
        public IDictionary<int, Shape> OutputShapes { get; set; }
    }
}