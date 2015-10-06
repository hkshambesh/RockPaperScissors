namespace Rps.Core.Interfaces
{
    public interface IProcessGameFactory
    {
        IProcessGame GetProcessGameByType(string gameType);
    }
}