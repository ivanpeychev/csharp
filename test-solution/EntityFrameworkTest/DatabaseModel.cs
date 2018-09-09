namespace EntityFrameworkTest
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class DatabaseModel : DbContext
	{
		public DatabaseModel()
			: base("name=DatabaseModel")
		{
		}

		public virtual DbSet<Person> People { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Person>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<Person>()
				.Property(e => e.SurName)
				.IsUnicode(false);

			modelBuilder.Entity<Person>()
				.Property(e => e.Email)
				.IsUnicode(false);
		}
	}
}
