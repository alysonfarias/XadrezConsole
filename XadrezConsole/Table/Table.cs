namespace Table
{
    class tableOne
    {
        public int lines { get; set; }
        public int columns { get; set; }

        private BoardPiece[,] BoardPieces;

        public tableOne ( int lines , int columns)
        {
            this.lines = lines;
            this.columns = columns;
            BoardPieces = new BoardPiece[lines, columns];
        }
    }
}
