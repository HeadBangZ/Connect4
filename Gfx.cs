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
		private Graphics gfxEngine;

		private int CanvasWidth { get; } = 700;
		private int CanvasHeight { get; } = 600;

		//const int CanvasWidth = 700;
		//const int CanvasHeight = 600;

		public Gfx(Graphics gfxEngine)
		{
			this.gfxEngine = gfxEngine;
			SetupCanvas();
		}

		public void SetupCanvas()
		{
			Brush bg = new SolidBrush(Color.WhiteSmoke);
			Pen lines = new Pen(Color.Black);

			gfxEngine.FillRectangle(bg, new Rectangle(0, 0, 700, 600));

			// rows and columns
			for (int i = 100; i < CanvasWidth; i += 100)
			{
				for (int j = 100; j < CanvasHeight; j += 100)
				{
					gfxEngine.DrawLine(lines, new Point(i, 0), new Point(i, CanvasHeight));
				}
				gfxEngine.DrawLine(lines, new Point(0, i), new Point(CanvasWidth, i));
			}
		}
	}
}
