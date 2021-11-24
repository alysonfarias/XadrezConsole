using Table;
namespace xadrez
{
    class Tower : BoardPiece
    {
        public Tower(table tab, Color color) : base(tab, color)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
