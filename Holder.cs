using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connect4
{
	class Holder
	{
		private int value = Board.White;
		private Point location;

		public Point GetLocation()
		{
			return location;
		}

		public void SetLocation(Point value)
		{
			location = value;
		}

		public int GetValue()
		{
			return value;
		}

		public void SetValue(int number)
		{
			value = number;
		}
	}
}
