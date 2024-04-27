
using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 0;

        static void DrawBoard()
        {
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine("_____ _____ _____ ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine("_____ _____ _____ ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        }

        static int CheckWin()
        {
            #region Horzontal Winning Condtion
            if (board[0] == board[1] && board[1] == board[2])
            {
                return 1;
            }
            else if (board[3] == board[4] && board[4] == board[5])
            {
                return 1;
            }
            else if (board[6] == board[7] && board[7] == board[8])
            {
                return 1;
            }
            #endregion

            #region Vertical Winning Condtion
            else if (board[0] == board[3] && board[3] == board[6])
            {
                return 1;
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
                return 1;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            else if (board[0] == board[4] && board[4] == board[8])
            {
                return 1;
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                return 1;
            }
            #endregion

            #region Checking For Draw

            else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1: X and Player 2: O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Turn Player 2");
                }
                else
                {
                    Console.WriteLine("Turn Player 1");
                }
                Console.WriteLine("\n");
                DrawBoard();

                choice = int.Parse(Console.ReadLine()) - 1;


                if (board[choice] != 'X' && board[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        board[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        board[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with an {1}", choice + 1, board[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    System.Threading.Thread.Sleep(2000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);

            Console.Clear();
            DrawBoard();

            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won!", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            Console.ReadLine();
        }
    }
}
