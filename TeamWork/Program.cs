using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
                       /*UNDER CONSTRUCTION*/
            string PlayerOneSymbol;
            string PlayerTwoSymbol;
            int Flag = 0;
            int Xcoordinate;
            int Ycoordinate;
            string Player;
            //1 = x
            //-1 = y

            Console.WriteLine("Player one, choose thy symbol(x or o ~LOWERCASE~).");
            PlayerOneSymbol = Console.ReadLine();
           
            if(PlayerOneSymbol == "x")
            {
                Flag = Flag + 1;
                PlayerTwoSymbol = "o";
            }
            if(PlayerOneSymbol == "o")
            {
                Flag = Flag - 1;
                PlayerTwoSymbol = "x";
            }

            Console.WriteLine("Player one enter your X co-ordinate:");
            Xcoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine("Player one enter your Y co-ordinate:");
            Ycoordinate = int.Parse(Console.ReadLine());

            Console.WriteLine("flag = {0}",Flag);
            Console.WriteLine("player one symbol = {0}",PlayerOneSymbol);
            DrawBoard(Flag,Xcoordinate,Ycoordinate);
        }

        static void DrawBoard(int inFlag, int inXcord, int inYcord)
        {
            char[,] DrawBoard = new char[4, 4];
            char PositionOne = 'g';
            if(inFlag == 1)
            {
                DrawBoard[inXcord, inYcord] = 'x';
            }
            if(inFlag == -1)
            {
                DrawBoard[inXcord, inYcord] = 'o';
            }
            Console.WriteLine("position = {0}",DrawBoard);

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", DrawBoard[1,1], DrawBoard[1,2], DrawBoard[1,3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", DrawBoard[2,1], DrawBoard[2,2], DrawBoard[2,3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", DrawBoard[3,1], DrawBoard[3,2], DrawBoard[3,3]);
            Console.WriteLine("     |     |      ");

        }
    }

}

