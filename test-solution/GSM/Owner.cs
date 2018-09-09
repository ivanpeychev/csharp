using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
	public class Owner
	{
		public string FirstName { get; set; }
		public string SurName { get; set; }
		public string FullName 
		{
			get 
			{
				return String.Concat(FirstName + " ", SurName);
			}
		}
	}
}
