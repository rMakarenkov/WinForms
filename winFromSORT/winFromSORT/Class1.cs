using System;

namespace winFromSORT
{
	internal class Main
	{
		public Main()
		{
			People Lord = new People();
			People Slave = new Black();
			People Normal = new Normal();

			string r = Lord.GetColor();
			string r2 = Slave.GetColor();
			string r3 = Normal.GetColor();

			Console.WriteLine(r);
			Console.WriteLine(r2);
			Console.WriteLine(r3);
		}
	}

	class People
	{
		public virtual string GetColor()
		{
			Console.WriteLine( GetType());

			return "Нормальный";

		}
	}

	class People2
	{
		public virtual string GetColor()
		{
			Console.WriteLine(GetType());

			return "Нормальный2";

		}
	}

	class Black : People, People2
	{
		public override string GetColor()
		{
			Console.WriteLine(GetType());

			return "Черный";
		}
	}

	class Normal : People
	{		
	}
}
