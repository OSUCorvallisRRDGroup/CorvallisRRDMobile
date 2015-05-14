using SQLite;
using System;

namespace CorvallisRRD
{
	[Table("Category")]
	public class Category
	{
		[PrimaryKey, AutoIncrement]
		public uint Id { get; set; }

		[MaxLength(100)]
		public string Name { get; set; }

		public DateTime Created { get; set; }

		public DateTime Updated { get; set; }

		public DateTime Deleted { get; set; }
	}
}