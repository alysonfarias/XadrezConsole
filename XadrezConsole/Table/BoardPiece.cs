namespace Table
{
    class BoardPiece
    {
        public Position position { get; set; }
        public Color color { get; set; }
        public int movimentQtd { get; protected set; }
        public tableOne table { get; protected set; }
    
        public BoardPiece (Position position, tableOne table, Color color)
        {
            this.position = position;
            this.table = table;
            this.color = color;
            this.movimentQtd = 0;
        }
    }
}
