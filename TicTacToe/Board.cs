namespace TicTacToe
{
    using System.Collections.Generic;
    using System.Linq;

    public class Board
    {
        private readonly List<Tile> _plays = new List<Tile>();

        public Board()
        {
            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 3; j++)
                _plays.Add(new Tile {RowIndex = i, ColumnIndex = j, Symbol = ' '});
        }

        public Tile TileAt(int rowIndex, int columnIndex)
        {
            return _plays.Single(tile => tile.RowIndex == rowIndex && tile.ColumnIndex == columnIndex);
        }

        public void AddTileAt(char symbol, int rowIndex, int columnIndex)
        {
            _plays.Single(tile => tile.RowIndex == rowIndex && tile.ColumnIndex == columnIndex).Symbol = symbol;
        }
    }
}