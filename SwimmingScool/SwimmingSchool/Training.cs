using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchool
{
	public class Training
	{
		public int Id { get; set; }
		public string Date { get; set; }
		public Professor Professor { get; set; }
		public Group Group { get; set; }
		public virtual List<MemberTraining> MemberOnTraining { get; set; } = new List<MemberTraining>();
		public override string ToString()
		{
			return Date.ToString();
		}
	}
}
