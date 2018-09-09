using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
	public class Battery
	{
		public string Model { get; internal set; }
		public int HoursIdle { get; internal set; }
		public int TalkHours { get; internal set; }
	}
}
