using System;
using Table;

namespace Xadrez
{
    class ChessMatch
    {
        public table tab { get; private set; }
        private int turn;
        private Color actualPlayer;
        public bool isFinished { get; set; }

        public ChessMatch()
        {
            tab = new table(8, 8);
            turn = 1;
            actualPlayer = Color.White;
            isFinished = false;
            insertBoardPieces();
        }

        private void insertBoardPieces()
        {
            tab.insertBoardPiece(new Tower(tab, Color.Black), new XadrezPosition('c', 1).toPositition());
            tab.insertBoardPiece(new Tower(tab, Color.Black), new XadrezPosition('c', 2).toPositition());
            tab.insertBoardPiece(new Tower(tab, Color.Black), new XadrezPosition('d', 2).toPositition());
            tab.insertBoardPiece(new Tower(tab, Color.Black), new XadrezPosition('e', 2).toPositition());
            tab.insertBoardPiece(new Tower(tab, Color.Black), new XadrezPosition('e', 1).toPositition());
            tab.insertBoardPiece(new Tower(tab, Color.Black), new XadrezPosition('d', 1).toPositition());

            tab.insertBoardPiece(new Tower(tab, Color.White), new XadrezPosition('c', 7).toPositition());
            tab.insertBoardPiece(new Tower(tab, Color.White), new XadrezPosition('c', 8).toPositition());
            tab.insertBoardPiece(new Tower(tab, Color.White), new XadrezPosition('d', 7).toPositition());
            tab.insertBoardPiece(new Tower(tab, Color.White), new XadrezPosition('e', 7).toPositition());
            tab.insertBoardPiece(new Tower(tab, Color.White), new XadrezPosition('e', 8).toPositition());
            tab.insertBoardPiece(new Tower(tab, Color.White), new XadrezPosition('d', 8).toPositition());
        }

        public void performMoviment(Position originPosition, Position destinationPosition)
        {
            BoardPiece bp = tab.deleteBoardPiece(originPosition);
            bp.incrementMovimentQtd();
            BoardPiece capturedBoardPiece = tab.deleteBoardPiece(destinationPosition);
            tab.insertBoardPiece(bp, destinationPosition);
        }
    }
}
