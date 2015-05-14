using SQLite;
using System;

namespace CorvallisRRD
{
	[Table("Item")]
	public class Item
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