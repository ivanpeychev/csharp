using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
	public class GSM
	{
		public string Model { get; internal set; }
		public string Manufacturer { get; internal set; }
		public decimal Price { get; internal set; }
		public Owner Owner { get; internal set; }
		public Battery Battery { get; internal set; }

		public GSM()
		{
			Owner = new Owner();
			Battery = new Battery();
			this.Model = "N/A";
			this.Manufacturer = "N/A";
			this.Price = 0;
			this.Owner.FirstName = "N/A";
			this.Owner.SurName = "N/A";
			this.Battery.Model = "N/A";
			this.Battery.HoursIdle = 0;
			this.Battery.TalkHours = 0;
		}

		public GSM(int price)
			:this()
		{
			this.Price = 200;
		}

		public void GetInfo()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(this.Model);
			sb.AppendLine(this.Manufacturer);
			sb.AppendLine(this.Price.ToString());
			sb.AppendLine(this.Owner.FullName);
			sb.AppendLine(this.Battery.Model);
			sb.AppendLine(this.Battery.HoursIdle.ToString());
			sb.AppendLine(this.Battery.TalkHours.ToString());
			Console.Write(sb);
		}
	}
}