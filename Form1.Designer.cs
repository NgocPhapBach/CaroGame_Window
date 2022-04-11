
namespace Caro_Phap
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearGame = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.prcbTime = new System.Windows.Forms.ProgressBar();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.undoGame = new System.Windows.Forms.Button();
            this.pnlChessBoard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlChessBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChessBoard.Controls.Add(this.panel1);
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(602, 602);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(617, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 208);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.clearGame);
            this.panel2.Controls.Add(this.startGame);
            this.panel2.Location = new System.Drawing.Point(630, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 84);
            this.panel2.TabIndex = 0;
            // 
            // clearGame
            // 
            this.clearGame.BackColor = System.Drawing.Color.MediumBlue;
            this.clearGame.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearGame.ForeColor = System.Drawing.Color.Yellow;
            this.clearGame.Location = new System.Drawing.Point(4, 44);
            this.clearGame.Name = "clearGame";
            this.clearGame.Size = new System.Drawing.Size(106, 34);
            this.clearGame.TabIndex = 1;
            this.clearGame.Text = "CLEAR";
            this.clearGame.UseVisualStyleBackColor = false;
            this.clearGame.Click += new System.EventHandler(this.clearGame_Click);
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.MediumBlue;
            this.startGame.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.ForeColor = System.Drawing.Color.Yellow;
            this.startGame.Location = new System.Drawing.Point(3, 4);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(106, 34);
            this.startGame.TabIndex = 0;
            this.startGame.Text = "NEWGAME";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayer.Controls.Add(this.undoGame);
            this.pnlPlayer.Controls.Add(this.pctbMark);
            this.pnlPlayer.Controls.Add(this.prcbTime);
            this.pnlPlayer.Controls.Add(this.txbPlayerName);
            this.pnlPlayer.Location = new System.Drawing.Point(630, 102);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(114, 194);
            this.pnlPlayer.TabIndex = 1;
            // 
            // pctbMark
            // 
            this.pctbMark.Location = new System.Drawing.Point(6, 95);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(100, 91);
            this.pctbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbMark.TabIndex = 2;
            this.pctbMark.TabStop = false;
            // 
            // prcbTime
            // 
            this.prcbTime.Location = new System.Drawing.Point(6, 66);
            this.prcbTime.Name = "prcbTime";
            this.prcbTime.Size = new System.Drawing.Size(100, 23);
            this.prcbTime.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(6, 4);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txbPlayerName.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // undoGame
            // 
            this.undoGame.BackColor = System.Drawing.Color.MediumBlue;
            this.undoGame.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoGame.ForeColor = System.Drawing.Color.Yellow;
            this.undoGame.Location = new System.Drawing.Point(6, 30);
            this.undoGame.Name = "undoGame";
            this.undoGame.Size = new System.Drawing.Size(100, 30);
            this.undoGame.TabIndex = 2;
            this.undoGame.Text = "UNDO";
            this.undoGame.UseVisualStyleBackColor = false;
            this.undoGame.Click += new System.EventHandler(this.undoGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(760, 625);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game đánh caro - Sinh viên Đại học Kiến trúc Đà Nẵng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pnlChessBoard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearGame;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.ProgressBar prcbTime;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button undoGame;
    }
}

