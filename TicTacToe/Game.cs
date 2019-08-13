namespace TicTacToe
{
    using System;

    public class Game
    {
        private readonly Board _board = new Board();
        private char _lastSymbol = ' ';

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
            //if the positions in first row are taken
            if (_board.TileAt(0, 0).Symbol != ' ' &&
                _board.TileAt(0, 1).Symbol != ' ' &&
                _board.TileAt(0, 2).Symbol != ' ')
                //if first row is full with same symbol
                if (_board.TileAt(0, 0).Symbol ==
                    _board.TileAt(0, 1).Symbol &&
                    _board.TileAt(0, 2).Symbol ==
                    _board.TileAt(0, 1).Symbol)
                    return _board.TileAt(0, 0).Symbol;

            //if the positions in first row are taken
            if (_board.TileAt(1, 0).Symbol != ' ' &&
                _board.TileAt(1, 1).Symbol != ' ' &&
                _board.TileAt(1, 2).Symbol != ' ')
                //if middle row is full with same symbol
                if (_board.TileAt(1, 0).Symbol ==
                    _board.TileAt(1, 1).Symbol &&
                    _board.TileAt(1, 2).Symbol ==
                    _board.TileAt(1, 1).Symbol)
                    return _board.TileAt(1, 0).Symbol;

            //if the positions in first row are taken
            if (_board.TileAt(2, 0).Symbol != ' ' &&
                _board.TileAt(2, 1).Symbol != ' ' &&
                _board.TileAt(2, 2).Symbol != ' ')
                //if middle row is full with same symbol
                if (_board.TileAt(2, 0).Symbol ==
                    _board.TileAt(2, 1).Symbol &&
                    _board.TileAt(2, 2).Symbol ==
                    _board.TileAt(2, 1).Symbol)
                    return _board.TileAt(2, 0).Symbol;

            return ' ';
        }

        private void EnsureValidPosition(int x, int y)
        {
            if (_board.TileAt(x, y).Symbol != ' ')
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
            if (_lastSymbol == ' ' && symbol == 'O')
            {
                throw new Exception("Invalid first player");
            }
        }

    }
}