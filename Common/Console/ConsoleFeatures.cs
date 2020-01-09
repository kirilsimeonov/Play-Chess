

namespace PlayChess.Common.Console
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    //Console Helperi - pravqt obshti neshta po konzolata

    public static class ConsoleFeatures
    {
        
        public static void SetCursorAtCenter(int messageLength)
        {
            int centerRow = Console.WindowHeight / 2;
            int centerCol = Console.WindowWidth / 2 - messageLength / 2;
            Console.SetCursorPosition(centerCol, centerRow);
            
        }
    }
}
