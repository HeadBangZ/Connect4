using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connect4
{
	public partial class Connect4 : Form
	{
		private Gfx engine;
		private Board ConnectFourBoard;

		public Connect4()
		{
			InitializeComponent();
		}

		private void Frame_Paint(object sender, PaintEventArgs e)
		{
			Graphics ToPass = Frame.CreateGraphics();
			engine = new Gfx(ToPass);

			ConnectFourBoard = new Board();
			ConnectFourBoard.InitializeBoard();
		}

		private void Frame_MouseClick(object sender, MouseEventArgs e)
		{
			Point mouseLocation = Cursor.Position;

			mouseLocation = Frame.PointToClient(mouseLocation);
			ConnectFourBoard.DetectPosition(mouseLocation);
		}
	}
}
