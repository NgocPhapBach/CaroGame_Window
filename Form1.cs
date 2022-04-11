using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_Phap
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlChessBoard, txbPlayerName, pctbMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prcbTime.Step = Cons.STEP;
            prcbTime.Maximum = Cons.TIME;
            prcbTime.Value = 0;

            timer.Interval = Cons.INTERVAL;

            NewGame();

            ClearGame();

            pnlChessBoard.Enabled = false;
            pnlPlayer.Enabled = false;

        }

        #region Methods
        void EndGame()
        {
            timer.Stop();
            pnlChessBoard.Enabled = false;
            pnlPlayer.Enabled = false;
            ChessBoard.WinPlayer();
        }

        void NewGame()
        {
            pnlChessBoard.Enabled = true;
            pnlPlayer.Enabled = true;

            prcbTime.Value = 0;
            timer.Stop();

            ChessBoard.DrawChessBoard();
  
        }

        void ClearGame()
        {
            prcbTime.Value = 0;
            timer.Stop();

            ChessBoard.DrawChessBoard();

            pnlChessBoard.Enabled = false;
            pnlPlayer.Enabled = false;
        }

        void UndoGame()
        {
            ChessBoard.Undo();
        }
        
        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            timer.Start();
            prcbTime.Value = 0;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            prcbTime.PerformStep();

            if (prcbTime.Value >= prcbTime.Maximum)
            {
                EndGame();               
            }
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            NewGame();
            
        }

        private void clearGame_Click(object sender, EventArgs e)
        {
            ClearGame();
        }

        private void undoGame_Click(object sender, EventArgs e)
        {
            UndoGame();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát Game?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
        #endregion
    }
}
