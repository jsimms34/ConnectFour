using System;
using System.IO;
//public struct PlayerInfo
//{
//    public String playerName;
//    public char playerID;
//};

namespace ConnectFour
{
    public class Program
    {
        static void Main(string[] args)
        {
            var board = new char[6, 7];
            int i = 0, j = 0;
            string input = File.ReadAllText(@"ExampleBoard.txt");
            string[] stringSeparators = new string[] { "\r\n" };

            foreach (var row in input.Split(stringSeparators, StringSplitOptions.None))
            {
                j = 0;  
                foreach (var col in row)
                {
                    board[i, j] = col;
                    j++;
                }
                i++;
            }

            var outcome = GamePlay.Play(board).ToString();
            Console.WriteLine(outcome);
        }
    }
}
