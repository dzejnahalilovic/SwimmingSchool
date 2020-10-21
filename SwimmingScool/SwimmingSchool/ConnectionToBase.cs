using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchool
{
	public class ConnectionToBase : DbContext
	{
		public ConnectionToBase() : base("PathToBase")
		{

		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}
		public DbSet<City> City { get; set; }
		public DbSet<Member> Member { get; set; }
		public DbSet<Professor> Professor { get; set; }
		public DbSet<Gender> Gender { get; set; }
		public DbSet<Training> Training { get; set; }
		public DbSet<Group> Group { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<MemberTraining> MemberTraining {get;set;}
	}
}
