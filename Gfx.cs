using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace connect4
{
	class Gfx
	{
		private static Graphics gfxEngine;

		//private int CanvasWidth { get; } = 700;
		//private int CanvasHeight { get; } = 600;

		private const int CanvasWidth = 700;
		private const int CanvasHeight = 600;

		public Gfx(Graphics gfxEngineObject)
		{
			gfxEngine = gfxEngineObject;
			SetupCanvas();
		}

		public void SetupCanvas()
		{
			Brush bg = new SolidBrush(Color.WhiteSmoke);
			Pen lines = new Pen(Color.Black, 1);

			gfxEngine.FillRectangle(bg, new Rectangle(0, 0, 700, 600));

			// rows and columns
			for (int i = 0; i < CanvasHeight; i += 100)
			{
				for (int j = 0; j <= CanvasWidth; j += 100)
				{
					gfxEngine.DrawLine(lines, new Point(j, 0), new Point(j, CanvasWidth));
				}
				gfxEngine.DrawLine(lines, new Point(0, i), new Point(CanvasWidth, i));
			}
		}

		public static void DrawRed(Point location)
		{
			Brush redPaint = new SolidBrush(Color.Red);
			int xPlacement = location.X * 100;
			int yPlacement = location.Y * 100;

			gfxEngine.FillRectangle(redPaint, xPlacement + 1, yPlacement + 1, 100 - 1, 100 - 1);
		}

		public static void DrawYellow(Point location)
		{
			Brush redPaint = new SolidBrush(Color.Yellow);
			int xPlacement = location.X * 100;
			int yPlacement = location.Y * 100;

			gfxEngine.FillRectangle(redPaint, xPlacement + 1, yPlacement + 1, 100 - 1, 100 - 1);
		}
	}
}
