using Ninject.Extensions.Factory;
using Ninject.Modules;
using Rps.Core.Interfaces;
using Rps.Core.Models.Enums;
using Rps.Core.Services;
using Rps.Core.Services.ProcessGame;

namespace Rps.Infrastructure.IoC
{
    public class RpsModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProcessGameFactory>().ToFactory(() => new NameInstanceProvider());
            Bind<IProcessGame>().To<ComputerVsComputer>().Named(GameType.ComputerVsComputer.ToString());
            Bind<IProcessGame>().To<PlayerVsComputer>().Named(GameType.PlayerVsComputer.ToString());

            Bind<IPlayService>().To<PlayService>();
        }
    }
}