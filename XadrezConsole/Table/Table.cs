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
    }
}
