using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_Kitaplığı
{
	public class ConsoleApp
	{
		public void OutLine(string content)
		{
			Console.WriteLine(content);
		}
        public void OutLine(int content)
		{
			Console.WriteLine(content);
		}
        public void Outln(string content)
		{
			Console.WriteLine(content);
		}
        public void Outln(int content)
		{
			Console.WriteLine(content);
		}
        public void Read()
		{
			Console.Read();
		}
		public void Readln(string readed)
		{
			Console.ReadLine();
		}
		public void Readkey()
		{
			Console.ReadKey();
		}
		public void Beep()
		{
			Console.Beep();
		}
	}
}
