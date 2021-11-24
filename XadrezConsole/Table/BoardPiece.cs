namespace Table
{
    class BoardPiece
    {
        public Position position { get; set; }
        public Color color { get; set; }
        public int movimentQtd { get; protected set; }
        public table table { get; protected set; }
    
        public BoardPiece (table table, Color color)
        {
            this.position = null;
            this.table = table;
            this.color = color;
            this.movimentQtd = 0;
        }

    }
}
