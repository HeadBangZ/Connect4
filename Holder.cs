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
		public const int Red = 0;
		public const int Yellow = 1;
		public const int none = 2;

		public Point Location { get; set; }

		public string None { get; set; }
	}
}
