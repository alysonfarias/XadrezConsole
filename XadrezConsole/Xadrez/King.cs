using Table;
namespace xadrez
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
    }
}
