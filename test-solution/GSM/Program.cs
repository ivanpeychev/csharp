using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
	class Program
	{
		static void Main()
		{
			GSM gsm = new GSM(price: 200)
			{
				Model = "C100",
				Manufacturer = "Alcatel"
			};
			
			gsm.GetInfo();
		}
	}
}
