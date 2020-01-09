using PlayChess.Board.Contracts;
using PlayChess.Common.Console;
using PlayChess.Renderers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PlayChess.Renderers
{
    public class ConsoleRenderer : IRenderer
    {
        private const string Logo = "...PLAY CHESS...";
        private const int CharactersPerBoardSquareRow = 9;
        private const int CharactersPerBoardSquareCol = 9;


        public void RenderMenu()
        {
            ConsoleFeatures.SetCursorAtCenter(Logo.Length);
            Console.WriteLine(Logo);
            //TODO: add main menu

            Thread.Sleep(1000);
            
        }
        public void RenderBoard(IBoard board)
        {
            //TODO: validate console diimensions
            var startRowPrint = Console.WindowHeight / 2 - board.TotalRows / 2 * CharactersPerBoardSquareRow;
            var startColPrint = Console.WindowWidth / 2 - board.TotalCols / 2 * CharactersPerBoardSquareCol;
            //fix charactersperboadsquareCol е първо

            var currentRow = startRowPrint;
            var currentCol = startColPrint;
            Console.BackgroundColor = ConsoleColor.White;

            for (int top = 0; top < board.TotalRows; top++)
            {
                for (int left = 0; left < board.TotalCols; left++)
                {
                    currentRow += left * CharactersPerBoardSquareCol;
                    currentCol += top * CharactersPerBoardSquareRow;

                    Console.SetCursorPosition(currentCol,currentRow); 
                }
            }

            

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");

            Console.ReadLine();

        }

        
    }
}
