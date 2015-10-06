using System;
using System.Windows.Forms;
using Rps.Core.Interfaces;
using Rps.Core.Models.Enums;

namespace Rps.Ui
{
    public partial class MainMenu : Form
    {
        private readonly IProcessGameFactory _processGameFactory;
        private readonly IPlayService _playService;
        private IProcessGame _processGame;

        public MainMenu(IProcessGameFactory processGameFactory, IPlayService playService)
        {
            _processGameFactory = processGameFactory;
            _playService = playService;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            _processGame = _processGameFactory.GetProcessGameByType(GameType.PlayerVsComputer.ToString());

            var mainWindow = new MainWindow(_processGame, _playService);

            this.Hide();
            mainWindow.Closed += (s, args) => this.Close();

            mainWindow.Show();
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            _processGame = _processGameFactory.GetProcessGameByType(GameType.ComputerVsComputer.ToString());

            var mainWindow = new MainWindow(_processGame, _playService);

            this.Hide();
            mainWindow.Closed += (s, args) => this.Close();

            mainWindow.Show();
        }
    }
}