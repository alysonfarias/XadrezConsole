namespace Table
{
    abstract class BoardPiece
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

        public void incrementMovimentQtd()
        {
            this.movimentQtd++;
        }

        public abstract bool[,] possibleMoviments();
    }
}
