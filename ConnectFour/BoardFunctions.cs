using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class BoardFunctions
    {
        public static bool CheckFourInRow(char[,] board, char RB)
        {
            int win = 0;

            for (int i = 5; i >= 1; --i)
            {
                for (int ix = 6; ix >= 1; --ix)
                {

                    if (i - 3 >= 0 && ix - 3 >= 0 && board[i, ix] == RB &&
                        board[i - 1, ix - 1] == RB &&
                        board[i - 2, ix - 2] == RB &&
                        board[i - 3, ix - 3] == RB)
                    {
                        win = 1;
                    }

                    if (ix - 3 >= 0 && board[i, ix] == RB &&
                        board[i, ix - 1] == RB &&
                        board[i, ix - 2] == RB &&
                        board[i, ix - 3] == RB)
                    {
                        win = 1;
                    }

                    if (i - 3 >= 0 &&  board[i, ix] == RB &&
                        board[i - 1, ix] == RB &&
                        board[i - 2, ix] == RB &&
                        board[i - 3, ix] == RB)
                    {
                        win = 1;
                    }

                    if (ix + 3 <= 6 && i - 3 >= 0  && board[i, ix] == RB &&
                        board[i - 1, ix + 1] == RB &&
                        board[i - 2, ix + 2] == RB &&
                        board[i - 3, ix + 3] == RB)
                    {
                        win = 1;
                    }

                    if (ix + 3 <= 6 && board[i, ix] == RB &&
                         board[i, ix + 1] == RB &&
                         board[i, ix + 2] == RB &&
                         board[i, ix + 3] == RB)
                    {
                        win = 1;
                    }
                }
            }

            return win == 1;
        }
    }
}
