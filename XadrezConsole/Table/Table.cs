namespace Table
{
    class table
    {
        public int lines { get; set; }
        public int columns { get; set; }

        private BoardPiece[,] boardPieces;

        public table ( int lines , int columns)
        {
            this.lines = lines;
            this.columns = columns;
            boardPieces = new BoardPiece[lines, columns];
        }
        public BoardPiece boardPiece(int line, int column)
        {
            return boardPieces[line, column];
        }
        public BoardPiece boardPiece(Position pos)
        {
            return boardPieces[pos.line, pos.column];
        }

        public void insertBoardPiece(BoardPiece boardPiece, Position pos)
        {
            if (hasBoardPiece(pos))
            {
                throw new ExceptionTable("Already exist a board piece in this position");
            }
            boardPieces[pos.line, pos.column] = boardPiece;
            boardPiece.position = pos;

        }
        public bool hasBoardPiece(Position pos)
        {
            validatePosition(pos);
            return boardPiece(pos) != null;
        }
        public bool verifyPosition(Position pos)
        {
            if (pos.line < 0 || pos.line >= lines || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }
            return true;
        }

        public void validatePosition(Position pos)
        {
            if (!verifyPosition(pos))
            {
                throw new ExceptionTable("Invalid position");
            }           
        }
    }
}
