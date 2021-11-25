using Table;
namespace Xadrez
{
    class Tower : BoardPiece
    {
        public Tower(table tab, Color color) : base(tab, color)
        {
        }
        public override bool[,] possibleMoviments()
        {
            bool[,] mat = new bool[table.lines, table.columns];

            Position pos = new Position(0, 0);

            // above
            pos.setValue(position.line - 1, position.column);
            while (table.verifyPosition(position) && canMove(pos)) 
            {
                mat[pos.line, pos.column] = true;
                if(table.boardPiece(pos) != null && table.boardPiece(pos).color != color)
                {
                    break;
                }
                pos.line = pos.line - 1;
            }

            // below
            pos.setValue(position.line + 1, position.column);
            while (table.verifyPosition(position) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (table.boardPiece(pos) != null && table.boardPiece(pos).color != color)
                {
                    break;
                }
                pos.line = pos.line + 1;
            }
            // left
            pos.setValue(position.line, position.column + 1);
            while (table.verifyPosition(position) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (table.boardPiece(pos) != null && table.boardPiece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column - 1 ;
            }

            // right
            pos.setValue(position.line, position.column + 1);
            while (table.verifyPosition(position) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (table.boardPiece(pos) != null && table.boardPiece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column + 1;
            }

            return mat;

        }
        public bool canMove(Position pos)
        {
            BoardPiece boardPiece = table.boardPiece(pos);


            return boardPiece == null || boardPiece.color != this.color;
        }


        public override string ToString()
        {
            return "T";
        }
    }
}
