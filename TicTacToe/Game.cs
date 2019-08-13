namespace TicTacToe
{
    using System;

    public class Game
    {
        private const char NoSymbol = ' ';
        private readonly Board _board = new Board();
        private char _lastSymbol = NoSymbol;

        public void Play(char symbol, int rowIndex, int columnIndex)
        {
            EnsureFirstPlayerIsX(symbol);
            EnsureCorrectPlayer(symbol);
            EnsureValidPosition(rowIndex, columnIndex);

            _lastSymbol = symbol;
            _board.AddTileAt(symbol, rowIndex, columnIndex);
        }

        public char Winner()
        {
            if (VerifyCellsNotEmptyIn(0))
                if (VerifyCellsAreSameIn(0))
                    return _board.TileAt(0, 0).Symbol;

            if (VerifyCellsNotEmptyIn(1))
                if (VerifyCellsAreSameIn(1))
                    return _board.TileAt(1, 0).Symbol;

            if (VerifyCellsNotEmptyIn(2))
                if (VerifyCellsAreSameIn(2))
                    return _board.TileAt(2, 0).Symbol;

            return NoSymbol;
        }

        private bool VerifyCellsNotEmptyIn(int rowIndex)
        {
            return _board.TileAt(rowIndex, 0).Symbol != NoSymbol &&
                   _board.TileAt(rowIndex, 1).Symbol != NoSymbol &&
                   _board.TileAt(rowIndex, rowIndex).Symbol != NoSymbol;
        }

        private bool VerifyCellsAreSameIn(int rowIndex)
        {
            return _board.TileAt(rowIndex, 0).Symbol ==
                   _board.TileAt(rowIndex, 1).Symbol &&
                   _board.TileAt(rowIndex, 2).Symbol ==
                   _board.TileAt(rowIndex, 1).Symbol;
        }

        private void EnsureValidPosition(int x, int y)
        {
            if (_board.TileAt(x, y).Symbol != NoSymbol)
            {
                throw new Exception("Invalid position");
            }
        }

        private void EnsureCorrectPlayer(char symbol)
        {
            if (symbol == _lastSymbol)
            {
                throw new Exception("Invalid next player");
            }
        }

        private void EnsureFirstPlayerIsX(char symbol)
        {
            if (_lastSymbol == NoSymbol && symbol == 'O')
            {
                throw new Exception("Invalid first player");
            }
        }

    }
}