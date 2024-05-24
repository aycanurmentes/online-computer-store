using System;
using SQLite;
using TabbedPages.Models;
namespace TabbedPages.Models
{
	public class UserInfo
	{
		[PrimaryKey,AutoIncrement]
        public int ID { get; set; }
		public string Name { get; set; }
	}
}

