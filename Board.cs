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
		public Rectangle[,] BoardData = new Rectangle[7, 6];
		private Holder[,] Holders = new Holder[7, 6];

		public void InitializeBoard()
		{
			for (int col = 0; col < 7; col++)
			{
				for (int row = 0; row < 6; row++)
				{
					BoardData[col, row] = new Rectangle(col * 100, row * 100, 100, 100);
					Holders[col, row] = new Holder
					{
						Location = new Point(col, row)
					};
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

			turn++;

			if (turn % 2 == 0)
			{
				Gfx.DrawRed(new Point(x, y));
			}
			else
			{
				Gfx.DrawYellow(new Point(x, y));
			}

		}
	}
}
