using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace ShadeAutoClicker
{
	public class Mouse
	{
		[DllImport("user32.dll")]
			public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		const int MOUSE_LEFT_DOWN = 0x0002;
		const int MOUSE_LEFT_UP = 0x0004;

		const int MOUSE_RIGHT_DOWN = 0x0008;
		const int MOUSE_RIGHT_UP = 0x0010;

		public enum Buttons
		{
			Left,
			Right
		}

		public static void Click(Buttons btn)
		{
			int _x = Cursor.Position.X;
			int _y = Cursor.Position.Y;

			if (btn == Buttons.Left)
			{
				mouse_event(MOUSE_LEFT_DOWN | MOUSE_LEFT_UP, _x, _y, 0, 0);
			}
			else
			{
				mouse_event(MOUSE_RIGHT_DOWN | MOUSE_RIGHT_UP, _x, _y, 0, 0);
			}
		}

		public static void Move(Point point)
		{
			Cursor.Position = point;
		}

		public static Point GetPosition()
		{
			return Cursor.Position;
		}
	}
}
