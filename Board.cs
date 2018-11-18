using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

			if (BoardData[x, y].GetValue() == White)
			{
				if (turn % 2 == 0)
				{
					Gfx.DrawRed(new Point(x, y));
					BoardData[x, y].SetValue(Red);
					DetectFourInARow(Red);
				}
				else
				{
					Gfx.DrawYellow(new Point(x, y));
					BoardData[x, y].SetValue(Yellow);
					DetectFourInARow(Yellow);
				}
				turn++;
			}
		}

		public void TheChampionIsPlayer(string playerColor)
		{
			MessageBox.Show(playerColor + " Player Wins!");
		}

		public void DetectFourInARow(int winnerColor)
		{
			// verticalCheck (|)
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

			// horizontalCheck (-)
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
