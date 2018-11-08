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
		Gfx engine;
		public Connect4()
		{
			InitializeComponent();
		}

		private void Frame_Paint(object sender, PaintEventArgs e)
		{
			Graphics ToPass = Frame.CreateGraphics();
			engine = new Gfx(ToPass);
		}
	}
}
