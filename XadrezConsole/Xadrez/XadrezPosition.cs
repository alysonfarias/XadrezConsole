using Table;
namespace xadrez
{
    class XadrezPosition
    {
        public char column { get; set; }
        public int line { get; set; }

        public XadrezPosition (char column, int line)
        {
            this.column = column;
            this.line = line;
        }
        public override string ToString()
        {
            return this.column + ", " + this.line;
        }

        public Position toPositition()
        {
            return new Position(8 - line, column - 'a');
        }
    }
}
