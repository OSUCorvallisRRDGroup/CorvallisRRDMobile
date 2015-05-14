using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace CorvallisRRD
{
	public class RRDDatabase : SQLiteConnection
	{
		static object dbLock = new object();

		public static string DbPath
		{
			get
			{
				var dbFile = "@string/database_file";
				var dbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

				return Path.Combine(dbPath, dbFile);
			}
		}

		public RRDDatabase(string path) : base(path)
		{
			CreateTable<Provider>();
			CreateTable<Category>();
			CreateTable<Item>();
		}

		public IEnumerable<Provider> GetProviders()
		{
			lock (dbLock)
			{
				return (from p in Table<Provider>() select p).ToList();
			}
		}

		public IEnumerable<Category> GetCategories()
		{
			lock (dbLock)
			{
				return (from c in Table<Category>() select c).ToList();
			}
		}

		public IEnumerable<Item> GetItems()
		{
			lock (dbLock)
			{
				return (from i in Table<Item>() select i).ToList();
			}
		}
	}
}