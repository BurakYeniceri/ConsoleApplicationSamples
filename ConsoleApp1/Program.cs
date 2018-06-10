using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsLib.Core;
using ConsLib.Utilities;


namespace ConsoleApp1
{
	class Program
	{
		
		static void Main(string[] args)
		{   
			ConsoleApp app = new ConsoleApp();  //Look to ConsLib\App.cs
			app.Outln(">>>");
			var input = Console.ReadLine();
			if (input=="Spammer") //Spammer
			{
				Spammer spammer = new Spammer();  //ConsLib.Utilities.Spammer:Spams a message.
				app.Outln(">>>Enter spam message: ");
				var spaminput = Console.ReadLine(); //Reads typed spam message.
				spammer.SetSpamMsg(spaminput);//Sets spammer message.
				app.Outln(">>>Enter spam count: ");
				spaminput = Console.ReadLine();//Reads typed spam count.
				spammer.SetSpamCount(Convert.ToInt32(spaminput));//Converts string to int and sets spam count.
			Cmd:app.Outln(">>>Spammer is ready, to start spamming, write StartSpam. To exit spammer, write Cancel.");
				input = Console.ReadLine();//Gets input.
				
				if (input == "StartSpam") { spammer.Spam(); }//If input is StartSpam, starts spamming.
				if(input== "Cancel") { spammer.ResetProperities(); }//If input is Cancel, breaks spammer.
				if(input!="StartSpam" || input != "Cancel") { spammer.SendErrMsg("Unknown spammer command."); goto Cmd; }
				//^^^If input is not correct, sends error message.
				
			}
			
			app.Read();
		}
	}
}
