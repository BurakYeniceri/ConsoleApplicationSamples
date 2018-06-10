using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Konsol_Kitaplığı
{
	public class Spammer
	{
		int temp;//Temporary variable.
		private int spamcount;//Count for spam.
		private string spammsg;//Message for spam.
		public void SetSpamCount (int spamcount)
		{
			this.spamcount = spamcount;
		}//Sets spam count.
		public void ResetProperities()
		{
			ConsoleApp app = new ConsoleApp();
			temp = 0;
			spamcount = 0;
			spammsg = "";
			app.Outln("All properities reset.");
		}//Resets spammer properities.
		public void SetSpamMsg(string spammsg)
		{
			this.spammsg = spammsg;
			
		}//Sets spam message.
		public void GetSpamMsg()
		{
			ConsoleApp app = new ConsoleApp();
			app.Outln(spammsg);

		}//Gets spam message.
		public void Spam()
		{
			ConsoleApp app = new ConsoleApp();
			while (temp != spamcount)
			{
				app.Outln(">>>"+spammsg);
				temp++;
				if (temp == spamcount) { break; }
			}
		}//Starts spamming.
		public void SendErrMsg()
		{   
			///<summary>
			/// Sends error message for spammer.
			/// </summary>
			ConsoleApp app = new ConsoleApp();
			app.Outln("Unknown command.");
        }//Sends error message.
	}
}
