using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class GamePlay
    {
        public static WinCases Play(char[,] board)
        {
            var redSuccess = BoardFunctions.CheckFourInRow(board, 'R');
            var blackSuccess = BoardFunctions.CheckFourInRow(board, 'B');

            if (redSuccess && !blackSuccess)
                return WinCases.RedWins;

            if (blackSuccess && !redSuccess)
                return WinCases.BlackWins;

            if (redSuccess && blackSuccess)
                return WinCases.RedAndBlackWin;

            if (!redSuccess && !blackSuccess)
            {
                if (CheckForEmptySpaces(board))
                {
                    return WinCases.NoWinnerAndEmptySpaces;
                }
                else
                    return WinCases.NoWinnerNoEmptySpaces;
            }

            return WinCases.InvalidEntry;
        }

        public static bool CheckForEmptySpaces(char[,] board)
        {
            bool ret = false;

            foreach(char c in board)
            {
                if (c == 'E')
                    return true;
            }

            return ret;
        }
    }
}
