using Rps.Core.Models;
using Rps.Core.Models.Enums;

namespace Rps.Core.Interfaces
{
    public interface IPlayService
    {
        Shape Play(Player player, int counter, Shape selectedShape = Shape.Unknown);
        Player ProcessResult(Player playerOne, Player playerTwo, out string output);
    }
}