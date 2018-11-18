using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO : Make Coin Fall Down The Rack And Reset Game

namespace connect4
{
	class Board : Connect4
	{
		public int turn = 0;

		public const int Red = 0;
		public const int Yellow = 1;
		public const int White = 2;

		private Container[,] BoardData = new Container[7, 6];

		public void InitializeBoard()
		{
			for (int col = 0; col < BoardData.GetLength(0); col++)
			{
				for (int row = 0; row < BoardData.GetLength(1); row++)
				{
					BoardData[col, row] = new Container();
					BoardData[col, row].SetValue(White);
					BoardData[col, row].SetLocation(new Point(col, row));
				}
			}
		}

		public void DetectPosition(Point location)
		{
			int x = location.X / 100;
			int y = location.Y / 100;

			// Old Placement Detection
			#region Placement commented out
			//int x = 0;
			//int y = 0;

			//// Row value
			//if (location.X < 100)
			//{
			//	x = 0;
			//}
			//else if (location.X > 100 && location.X < 200)
			//{
			//	x = 1;
			//}
			//else if (location.X > 200 && location.X < 300)
			//{
			//	x = 2;
			//}
			//else if (location.X > 300 && location.X < 400)
			//{
			//	x = 3;
			//}
			//else if (location.X > 400 && location.X < 500)
			//{
			//	x = 4;
			//}
			//else if (location.X > 500 && location.X < 600)
			//{
			//	x = 5;
			//}
			//else if (location.X > 600 && location.X < 700)
			//{
			//	x = 6;
			//}

			//// Column Value
			//if (location.Y < 100)
			//{
			//	y = 0;
			//}
			//else if (location.Y > 100 && location.Y < 200)
			//{
			//	y = 1;
			//}
			//else if (location.Y > 200 && location.Y < 300)
			//{
			//	y = 2;
			//}
			//else if (location.Y > 300 && location.Y < 400)
			//{
			//	y = 3;
			//}
			//else if (location.Y > 400 && location.Y < 500)
			//{
			//	y = 4;
			//}
			//else if (location.Y > 500 && location.Y < 600)
			//{
			//	y = 5;
			//}
			#endregion

			// Turn check, and valid placement check
			if (BoardData[x, y].GetValue() == White)
			{
				bool ColumnIsFilled = false;

				if (turn % 2 == 0)
				{
					for (int col = BoardData.GetLength(1) - 1; col >= 0; col--)
					{
						if (BoardData[x, col].GetValue() == White)
						{
							Gfx.DrawRed(new Point(x, col));
							BoardData[x, col].SetValue(Red);
							DetectFourInARow(Red);
							break;
						}
						else if (col == BoardData.GetLength(1))
						{
							ColumnIsFilled = true;
						}
					}
				}
				else
				{
					for (int col = BoardData.GetLength(1) - 1; col >= 0; col--)
					{
						if (BoardData[x, col].GetValue() == White)
						{
							Gfx.DrawYellow(new Point(x, col));
							BoardData[x, col].SetValue(Yellow);
							DetectFourInARow(Yellow);
							break;
						}
						else if (col == BoardData.GetLength(1))
						{
							ColumnIsFilled = true;
						}
					}
				}

				turn++;
			}
		}

		public void TheChampionIsPlayer(string playerColor) => MessageBox.Show(playerColor + " Player Wins!");

		public void DetectFourInARow(int winnerColor)
		{
			// horizontalCheck (-)
			for (int row = 0; row < BoardData.GetLength(0) - 3; row++)
			{
				for (int col = 0; col < BoardData.GetLength(1); col++)
				{
					if (BoardData[row, col].GetValue() == winnerColor && BoardData[row + 1, col].GetValue() == winnerColor && BoardData[row + 2, col].GetValue() == winnerColor && BoardData[row + 3, col].GetValue() == winnerColor)
					{
						CheckWinner(winnerColor);
					}
				}
			}

			// verticalCheck (|)
			for (int row = 0; row < BoardData.GetLength(0); row++)
			{
				for (int col = 0; col < BoardData.GetLength(1) - 3; col++)
				{
					if (BoardData[row, col].GetValue() == winnerColor && BoardData[row, col + 1].GetValue() == winnerColor && BoardData[row, col + 2].GetValue() == winnerColor && BoardData[row, col + 3].GetValue() == winnerColor)
					{
						CheckWinner(winnerColor);
					}
				}
			}

			// top-left diagonal (\)
			for (int row = 0; row < BoardData.GetLength(0) - 3; row++)
			{
				for (int col = 0; col < BoardData.GetLength(1) - 3; col++)
				{
					if (BoardData[row, col].GetValue() == winnerColor && BoardData[row + 1, col + 1].GetValue() == winnerColor && BoardData[row + 2, col + 2].GetValue() == winnerColor && BoardData[row + 3, col + 3].GetValue() == winnerColor)
					{
						CheckWinner(winnerColor);
					}
				}
			}

			// top-right diagonal (/)
			for (int row = 0; row < BoardData.GetLength(0) - 3; row++)
			{
				for (int col = 3; col < BoardData.GetLength(1); col++)
				{
					if (BoardData[row, col].GetValue() == winnerColor && BoardData[row + 1, col - 1].GetValue() == winnerColor && BoardData[row + 2, col - 2].GetValue() == winnerColor && BoardData[row + 3, col - 3].GetValue() == winnerColor)
					{
						CheckWinner(winnerColor);
					}
				}
			}
		}

		public bool CheckWinner(int champion)
		{
			bool ColorWin = false;

			if (champion == 0)
			{
				ColorWin = true;
				TheChampionIsPlayer("Red");
				return ColorWin;
			}
			else if (champion == 1)
			{
				ColorWin = true;
				TheChampionIsPlayer("Yellow");
				return ColorWin;
			}
			else
			{
				return false;
			}
		}
	}
}
