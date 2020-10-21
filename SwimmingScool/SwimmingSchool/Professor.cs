using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchool
{
	public class Professor
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string DateOfBirth { get; set; }
		public string HireDate { get; set; }
		public virtual Gender Gender { get; set; }
		public virtual City City { get; set; }
		public int CardNumber { get; set; }
		public byte[] Photo { get; set; }

		public override string ToString()
		{
			return $"{FirstName} {LastName}";
		}

	}
}
