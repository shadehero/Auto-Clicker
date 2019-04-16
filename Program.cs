using System;
using System.Threading;
 

namespace ShadeAutoClicker
{
	class MainClass
	{
		static int Speed = 100;
		static bool Run = false;

		public static void Main(string[] args)
		{
			Keyboard _keyboard = new Keyboard();
			_keyboard.KeyPressed += _keyboard_KeyPressed;
			_keyboard.Start();


			Console.Title = "ShadeAutoClicker By ShadeHero";
			Console.WriteLine(" +----------------------+");
			Console.WriteLine(" |       Controls       |");
			Console.WriteLine(" +----------------------+");
			Console.WriteLine(" | Left Arrow - Slower  |");
			Console.WriteLine(" | Right Arrow - Faster |");
			Console.WriteLine(" | Space - Start/Stop   |");
			Console.WriteLine(" +----------------------+");

			while (true)
			{
				
				if (Run)
				{
					Console.Title = Speed.ToString();
					Mouse.Click(Mouse.Buttons.Left);
					Thread.Sleep(Speed);
				}
			}
		}

		static void _keyboard_KeyPressed(string key)
		{

			if (key == "Space")
			{
				if (Run) { Run = false; } else { Run = true;}
			}

			if (key == "Right")
			{
				if (Speed > 0)
				{
					Speed -= 10;
				}
				Console.Title = "Delay(Speed):" +  Speed.ToString();
			}

			if (key == "Left")
			{
				if (Speed < 100)
				{
					Speed += 10;
				}
				Console.Title = "Delay(Speed):" + Speed.ToString();
			}
		}
	}
}
