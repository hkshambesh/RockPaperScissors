using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using Rps.Core.Interfaces;
using Rps.Core.Models;
using Rps.Core.Models.Enums;
using Rps.Infrastructure.IoC;

namespace Rps.Ui
{
    public partial class MainWindow : Form
    {
        private readonly IProcessGame _processGame;
        private readonly IPlayService _playService;

        private ScreenSetting _screenSetting;
        private int _counter;
        
        public MainWindow(IProcessGame processGame, IPlayService playService)
        {
            _processGame = processGame;
            _playService = playService;

            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var main = DependencyResolver.Kernel.Get<MainMenu>();

            this.Hide();
            main.Closed += (s, args) => this.Close();

            main.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            ProcessPlay(Shape.Rock);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            ProcessPlay(Shape.Paper);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            ProcessPlay(Shape.Scissors);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            ProcessComputerVsComputer();
            btnStartGame.Enabled = false;
        }

        private void ProcessPlay(Shape shape = Shape.Unknown)
        {
            this.ShapeButtons(false);

            Shape playerOneShape = _playService.Play(_screenSetting.PlayerOne, _counter, shape);
            pbPlayerOneOutput.Visible = true;
            pbPlayerOneOutput.ImageLocation = ImageLocator(playerOneShape);
            pbPlayerOneOutput.Load();
            pbPlayerOneOutput.Refresh();

            Shape playerTwoShape = _playService.Play(_screenSetting.PlayerTwo, _counter);
            pbPlayerTwoOutput.Visible = true;
            pbPlayerTwoOutput.ImageLocation = ImageLocator(playerTwoShape);
            pbPlayerTwoOutput.Load();
            pbPlayerTwoOutput.Refresh();

            string output;

            _playService.ProcessResult(_screenSetting.PlayerOne, _screenSetting.PlayerTwo, out output);

            lblPlayerWin.Visible = true;
            lblPlayerWin.Text = output;
            lblPlayerWin.Refresh();

            lblPlayerOneScore.Text = _screenSetting.PlayerOne.Score.ToString();
            lblPlayerOneScore.Refresh();

            lblPlayerTwoScore.Text = _screenSetting.PlayerTwo.Score.ToString();
            lblPlayerTwoScore.Refresh();

            _counter++;

            lblCounter.Text = _counter + " to " + _screenSetting.Counter + " wins";

            if (_counter == _screenSetting.Counter)
            {
                if (_screenSetting.PlayerOne.Score > _screenSetting.PlayerTwo.Score)
                {
                    output = _screenSetting.PlayerOne.Name + " wins!";
                }
                else if (_screenSetting.PlayerOne.Score == _screenSetting.PlayerTwo.Score)
                {
                    output = "Draw!";
                }
                else
                {
                    output = _screenSetting.PlayerTwo.Name + " wins!";
                }

                DialogResult dialogResult = MessageBox.Show(output + ", Play Again ?", "Game Finish", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    LoadSettings();

                    ProcessComputerVsComputer();
                }
            }
            else
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));

                this.HideResultArea();
                this.ShapeButtons(true);
            }
        }

        private void LoadSettings()
        {
            _counter = 0;
            
            _screenSetting = _processGame.LoadSettings();

            lblCounter.Text = _counter + " to " + _screenSetting.Counter + " wins";

            lblPlayerOne.Text = _screenSetting.PlayerOne.Name;
            lblPlayerOneScore.Text = _screenSetting.PlayerOne.Score.ToString();

            lblPlayerTwo.Text = _screenSetting.PlayerTwo.Name;
            lblPlayerTwoScore.Text = _screenSetting.PlayerTwo.Score.ToString();

            this.HideResultArea();

            // Computer vs Computer
            if (!_screenSetting.IsShapesEnabled)
            {
                btnStartGame.Visible = true;
                btnStartGame.Enabled = true;
                HideShapeButtons();
            }
        }

        private void HideResultArea()
        {
            pbPlayerOneOutput.Visible = false;
            pbPlayerTwoOutput.Visible = false;
            lblPlayerWin.Visible = false;
            lblPlayerWin.Visible = false;
        }

        private void HideShapeButtons()
        {
            btnPaper.Visible = false;
            btnRock.Visible = false;
            btnScissors.Visible = false;
        }

        private void ShapeButtons(bool enable)
        {
            btnPaper.Enabled = enable;
            btnRock.Enabled = enable;
            btnScissors.Enabled = enable;
        }

        private string ImageLocator(Shape shape)
        {
            string imagePath = string.Empty;

            switch (shape)
            {
                case Shape.Paper:
                    imagePath = @"images\paper-td.png";
                    break;
                case Shape.Rock:
                    imagePath = @"images\rock-td.png";
                    break;
                case Shape.Scissors:
                    imagePath = @"images\scissors-td.png";
                    break;
            }

            return imagePath;
        }

        private void ProcessComputerVsComputer()
        {
            if (!_screenSetting.IsShapesEnabled)
            {
                for (int i = 0; i < _screenSetting.Counter; i++)
                {
                    this.ProcessPlay();

                    Thread.Sleep(TimeSpan.FromSeconds(2));
                }
            }
        }
    }
}