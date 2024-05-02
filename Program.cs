
using System;

internal class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1;
    static int choice = 0;
    enum TicTac
    {
        Win,
        Draw,
        Next
    };
    static TicTac ticTac = TicTac.Next;
    private static void Main(string[] args)
    {
        Console.WriteLine("Start!");
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
            //Player Step
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
                Thread.Sleep(000);
            }
            CheckWin();
        }
        while (ticTac != TicTac.Win && ticTac != TicTac.Draw);
        Console.Clear();
        DrawBoard();

        if (ticTac == TicTac.Win)
        {
            Console.WriteLine("Player {0} has won!", player % 2 + 1);
        }
        else
        {
            Console.WriteLine("Draw!");
        }
        Console.ReadLine();

        void DrawBoard()
        {
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine("_____ _____ _____ ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine("_____ _____ _____ ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        }

        static void CheckWin()
        {
            //Điều kiện chiến thắng theo chiều ngang
            if (board[0] == board[1] && board[1] == board[2])
            {
                ticTac = TicTac.Win;
            }
            else if (board[3] == board[4] && board[4] == board[5])
            {
                ticTac = TicTac.Win;
            }
            else if (board[6] == board[7] && board[7] == board[8])
            {
                ticTac = TicTac.Win;
            }

            //Điều kiện thắng theo chiều dọc
            else if (board[0] == board[3] && board[3] == board[6])
            {
                ticTac = TicTac.Win;
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
                ticTac = TicTac.Win;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                ticTac = TicTac.Win;
            }

            //Điều kiện thắng theo đường chéo
            else if (board[0] == board[4] && board[4] == board[8])
            {
                ticTac = TicTac.Win;
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                ticTac = TicTac.Win;
            }

            //Kiểm tra hoa
            else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
            {
                ticTac = TicTac.Draw;
            }


            else
            {
                ticTac = TicTac.Next;
            }
        }


    }
}


