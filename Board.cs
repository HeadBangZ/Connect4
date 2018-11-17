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

		private Holder[,] BoardData = new Holder[7, 6];

		public void InitializeBoard()
		{
			for (int col = 0; col < BoardData.GetLength(0); col++)
			{
				for (int row = 0; row < BoardData.GetLength(1); row++)
				{
					BoardData[col, row] = new Holder();
					BoardData[col, row].SetValue(White);
					BoardData[col, row].SetLocation(new Point(col, row));
				}
			}
		}

		public void DetectPosition(Point location)
		{
			int x = 0;
			int y = 0;

			// the x position
			if (location.X < 100)
			{
				x = 0;
			}
			else if (location.X > 100 && location.X < 200)
			{
				x = 1;
			}
			else if (location.X > 200 && location.X < 300)
			{
				x = 2;
			}
			else if (location.X > 300 && location.X < 400)
			{
				x = 3;
			}
			else if (location.X > 400 && location.X < 500)
			{
				x = 4;
			}
			else if (location.X > 500 && location.X < 600)
			{
				x = 5;
			}
			else if (location.X > 600 && location.X < 700)
			{
				x = 6;
			}
			// the y position
			// Will be removed later on, since I only need the Col position
			// The Row position will be the bottom one that is empty
			if (location.Y < 100)
			{
				y = 0;
			}
			else if (location.Y > 100 && location.Y < 200)
			{
				y = 1;
			}
			else if (location.Y > 200 && location.Y < 300)
			{
				y = 2;
			}
			else if (location.Y > 300 && location.Y < 400)
			{
				y = 3;
			}
			else if (location.Y > 400 && location.Y < 500)
			{
				y = 4;
			}
			else if (location.Y > 500 && location.Y < 600)
			{
				y = 5;
			}

			if (turn % 2 == 0)
			{
				Gfx.DrawRed(new Point(x, y));
				BoardData[x, y].SetValue(Red);
				if (DetectFourInARow())
				{
					MessageBox.Show("You have won! Red");
				}
			}
			else
			{
				Gfx.DrawYellow(new Point(x, y));
				BoardData[x, y].SetValue(Yellow);
				if (DetectFourInARow())
				{
					MessageBox.Show("You have won Yellow!");
				}
			}

			turn++;
		}

		public bool DetectFourInARow()
		{
			//bool RedWin = false;
			//bool YellowWin = false;
			bool WinnerFound = false;

			return WinnerFound;
		}
	}
}
#region WinningChekcs Not Working!
//// verticalCheck
//for (int x = 0; x<BoardData.GetLength(0); x++)
//{
//	for (int y = 0; y<BoardData.GetLength(1); y++)
//	{
//		if (BoardData[x, y].GetValue() == Red && BoardData[x, y + 1].GetValue() == Red && BoardData[x, y + 2].GetValue() == Red && BoardData[x, y + 3].GetValue() == Red)
//		{
//			RedWin = true;
//			return RedWin;
//		}
//		else if (BoardData[x, y].GetValue() == Yellow && BoardData[x, y + 1].GetValue() == Yellow && BoardData[x, y + 2].GetValue() == Yellow && BoardData[x, y + 3].GetValue() == Yellow)
//		{
//			YellowWin = true;
//			return YellowWin;
//		}
//	}
//}

//// horizontalCheck 
//for (int x = 0; x<BoardData.GetLength(0); x++)
//{
//	for (int y = 0; y<BoardData.GetLength(1); y++)
//	{
//		if (BoardData[x, y].GetValue() == Red && BoardData[x + 1, y].GetValue() == Red && BoardData[x + 2, y].GetValue() == Red && BoardData[x + 3, y].GetValue() == Red)
//		{
//			RedWin = true;
//			return RedWin;
//		}
//		else if (BoardData[x, y].GetValue() == Yellow && BoardData[x + 1, y].GetValue() == Yellow && BoardData[x + 2, y].GetValue() == Yellow && BoardData[x + 3, y].GetValue() == Yellow)
//		{
//			YellowWin = true;
//			return YellowWin;
//		}
//	}
//}

//// ascendingDiagonalCheck 
//for (int x = 3; x<BoardData.GetLength(0); x++)
//{
//	for (int y = 0; y<BoardData.GetLength(1); y++)
//	{
//		if (BoardData[x, y].GetValue() == Red && BoardData[x - 1, y + 1].GetValue() == Red && BoardData[x - 2, y + 2].GetValue() == Red && BoardData[x - 3, y + 3].GetValue() == Red)
//		{
//			RedWin = true;
//			return RedWin;
//		}
//		else if (BoardData[x, y].GetValue() == Yellow && BoardData[x + 1, y].GetValue() == Yellow && BoardData[x + 2, y].GetValue() == Yellow && BoardData[x + 3, y].GetValue() == Yellow)
//		{
//			YellowWin = true;
//			return YellowWin;
//		}
//	}
//}

//// descendingDiagonalCheck
//for (int x = 3; x<BoardData.GetLength(0); x++)
//{
//	for (int y = 3; y > BoardData.GetLength(0); y++)
//	{
//		if (BoardData[x, y].GetValue() == Red && BoardData[x - 1, y - 1].GetValue() == Red && BoardData[x - 2, y - 2].GetValue() == Red && BoardData[x - 3, y - 3].GetValue() == Red)
//		{
//			RedWin = true;
//			return RedWin;
//		}
//		else if (BoardData[x, y].GetValue() == Yellow && BoardData[x - 1, y - 1].GetValue() == Yellow && BoardData[x - 2, y - 2].GetValue() == Yellow && BoardData[x - 3, y - 3].GetValue() == Yellow)
//		{
//			YellowWin = true;
//			return YellowWin;
//		}
//	}
//}

#endregion