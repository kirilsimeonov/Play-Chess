using PlayChess.Board.Contracts;
using PlayChess.Common;
using PlayChess.Pieces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayChess.Board
{
    public class Board : IBoard
    {
        private readonly IPiece[,] board;

        public Board(int rows = Constants.DefaultChessRows, int cols = Constants.DefaultChessCols)
        {
            this.TotalRows = rows;
            this.TotalCols = cols;
            this.board = new IPiece[rows, cols];
        }

        

        public int TotalRows { get; private set; }

        public int TotalCols { get; private set; }

        public void AddPiece(IPiece piece, Position position)
        {
            ObjectValidator.CheckIfObjectIsNull(piece, ErrorMessages.NullPieceError);
            this.CheckIfPositionIsValid(position);

            int arrayRow = this.GetArrayRow(position.Row);
            int arrayCol = this.GetArrayCol(position.Col);

            this.board[arrayRow, arrayCol] = piece;


        }

        public void RemovePiece(Position position)
        {
           
            this.CheckIfPositionIsValid(position);

            int arrayRow = this.GetArrayRow(position.Row);
            int arrayCol = this.GetArrayCol(position.Col);

            this.board[arrayRow, arrayCol] = null;

        }

        private int GetArrayRow(int chessRow)
        {
            return this.TotalRows - chessRow;
        }
        private int GetArrayCol(char chessCol)
        {
            return chessCol - 'a';
        }

        private void CheckIfPositionIsValid(Position position)
        {
            if (position.Row < Constants.MinimumBoardRowValue || position.Row > Constants.MaximumBoardRowValue)
            {
                throw new IndexOutOfRangeException("Invalid row input!");
            }
            if (position.Col < Constants.MinimumBoardColValue || position.Col > Constants.MaximumBoardColValue)
            {
                throw new IndexOutOfRangeException("Invalid column input!");
            }
        }

        
    }
}
