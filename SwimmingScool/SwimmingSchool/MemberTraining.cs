using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchool
{
	public class MemberTraining
	{
		public int Id { get; set; }
		public virtual Training Training { get; set; }
		public virtual Member Member { get; set; }
		public string Note { get; set; }
	}
}
