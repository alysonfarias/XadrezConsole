using Table;
namespace Xadrez
{
    class King : BoardPiece
    {
        public King(table tab, Color color) : base(tab, color)
        {
        }


        public override string ToString()
        {
            return "K";
        }
        public override bool[,] possibleMoviments()
        {
            bool[,] mat = new bool[table.lines, table.columns];

            Position pos = new Position(0, 0);

            // above
            pos.setValue(position.line - 1, position.column);
            if (table.verifyPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            // north east
            pos.setValue(position.line - 1, position.column + 1);
            if (table.verifyPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            // right
            pos.setValue(position.line, position.column + 1);
            if (table.verifyPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            // sudeste
            pos.setValue(position.line - 1, position.column + 1);
            if (table.verifyPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            //below
            pos.setValue(position.line + 1, position.column);
            if (table.verifyPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            //sudoeste
            pos.setValue(position.line + 1, position.column - 1);
            if (table.verifyPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            //left - south-west
            pos.setValue(position.line, position.column - 1);
            if (table.verifyPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            //noroeste - northwest
            pos.setValue(position.line - 1, position.column - 1);
            if (table.verifyPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            return mat;

        }
        public bool canMove(Position pos)
        {
            BoardPiece boardPiece = table.boardPiece(pos);
            
            
            return boardPiece == null || boardPiece.color != this.color;
        }


    }
}
