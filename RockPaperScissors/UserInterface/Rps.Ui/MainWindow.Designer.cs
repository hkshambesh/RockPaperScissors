namespace Rps.Ui
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerTwoScore = new System.Windows.Forms.Label();
            this.lblPlayerTwoScore = new System.Windows.Forms.Label();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerOneScore = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblPlayerWin = new System.Windows.Forms.Label();
            this.pbPlayerOneOutput = new System.Windows.Forms.PictureBox();
            this.pbPlayerTwoOutput = new System.Windows.Forms.PictureBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerOneOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTwoOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.Location = new System.Drawing.Point(205, 38);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(79, 13);
            this.lblPlayerTwo.TabIndex = 0;
            this.lblPlayerTwo.Text = "lblPlayerTwo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "VS";
            // 
            // playerTwoScore
            // 
            this.playerTwoScore.AutoSize = true;
            this.playerTwoScore.Location = new System.Drawing.Point(255, 51);
            this.playerTwoScore.Name = "playerTwoScore";
            this.playerTwoScore.Size = new System.Drawing.Size(0, 13);
            this.playerTwoScore.TabIndex = 3;
            this.playerTwoScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayerTwoScore
            // 
            this.lblPlayerTwoScore.AutoSize = true;
            this.lblPlayerTwoScore.Location = new System.Drawing.Point(251, 51);
            this.lblPlayerTwoScore.Name = "lblPlayerTwoScore";
            this.lblPlayerTwoScore.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerTwoScore.TabIndex = 4;
            this.lblPlayerTwoScore.Text = "label4";
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.Location = new System.Drawing.Point(77, 38);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(78, 13);
            this.lblPlayerOne.TabIndex = 5;
            this.lblPlayerOne.Text = "lblPlayerOne";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Score";
            // 
            // lblPlayerOneScore
            // 
            this.lblPlayerOneScore.AutoSize = true;
            this.lblPlayerOneScore.Location = new System.Drawing.Point(121, 51);
            this.lblPlayerOneScore.Name = "lblPlayerOneScore";
            this.lblPlayerOneScore.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerOneScore.TabIndex = 7;
            this.lblPlayerOneScore.Text = "label5";
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRock.BackgroundImage")));
            this.btnRock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRock.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRock.Location = new System.Drawing.Point(74, 98);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(67, 61);
            this.btnRock.TabIndex = 8;
            this.btnRock.Text = "Rock";
            this.btnRock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaper.BackgroundImage")));
            this.btnPaper.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPaper.Location = new System.Drawing.Point(158, 98);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(61, 61);
            this.btnPaper.TabIndex = 9;
            this.btnPaper.Text = "Paper";
            this.btnPaper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScissors.BackgroundImage")));
            this.btnScissors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnScissors.Location = new System.Drawing.Point(230, 99);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(67, 60);
            this.btnScissors.TabIndex = 10;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(148, 68);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(68, 13);
            this.lblCounter.TabIndex = 11;
            this.lblCounter.Text = "first to 5 wins";
            // 
            // lblPlayerWin
            // 
            this.lblPlayerWin.AutoSize = true;
            this.lblPlayerWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWin.Location = new System.Drawing.Point(139, 268);
            this.lblPlayerWin.Name = "lblPlayerWin";
            this.lblPlayerWin.Size = new System.Drawing.Size(100, 13);
            this.lblPlayerWin.TabIndex = 12;
            this.lblPlayerWin.Text = "lblPlayerOneWin";
            // 
            // pbPlayerOneOutput
            // 
            this.pbPlayerOneOutput.Location = new System.Drawing.Point(74, 193);
            this.pbPlayerOneOutput.Name = "pbPlayerOneOutput";
            this.pbPlayerOneOutput.Size = new System.Drawing.Size(67, 57);
            this.pbPlayerOneOutput.TabIndex = 14;
            this.pbPlayerOneOutput.TabStop = false;
            // 
            // pbPlayerTwoOutput
            // 
            this.pbPlayerTwoOutput.Location = new System.Drawing.Point(240, 193);
            this.pbPlayerTwoOutput.Name = "pbPlayerTwoOutput";
            this.pbPlayerTwoOutput.Size = new System.Drawing.Size(67, 57);
            this.pbPlayerTwoOutput.TabIndex = 15;
            this.pbPlayerTwoOutput.TabStop = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(12, 3);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMainMenu.TabIndex = 17;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(93, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 315);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.pbPlayerTwoOutput);
            this.Controls.Add(this.pbPlayerOneOutput);
            this.Controls.Add(this.lblPlayerWin);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblPlayerOneScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.lblPlayerTwoScore);
            this.Controls.Add(this.playerTwoScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerTwo);
            this.Name = "MainWindow";
            this.Text = "Rock, Paper, Scissors - Game Started -";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerOneOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTwoOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerTwoScore;
        private System.Windows.Forms.Label lblPlayerTwoScore;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerOneScore;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblPlayerWin;
        private System.Windows.Forms.PictureBox pbPlayerOneOutput;
        private System.Windows.Forms.PictureBox pbPlayerTwoOutput;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnReset;
    }
}