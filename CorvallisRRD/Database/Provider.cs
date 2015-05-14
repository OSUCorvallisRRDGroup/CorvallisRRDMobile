using SQLite;
using System;

namespace CorvallisRRD
{
	[Table("Provider")]
	public class Provider
	{
		[PrimaryKey, AutoIncrement]
		public uint Id { get; set; }

		[MaxLength(200)]
		public string Name { get; set; }

		[MaxLength(100)]
		public string Website { get; set; }

		[MaxLength(10)]
		public string PhoneNumber { get; set; }

		public string Address { get; set; }

		public string OperatingHours { get; set; }

		public DateTime Created { get; set; }

		public DateTime Updated { get; set; }

		public DateTime Deleted { get; set; }
	}
}