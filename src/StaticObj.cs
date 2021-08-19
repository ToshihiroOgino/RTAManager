using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTAManager.src
{
	public class StaticObj
	{
		/// <summary>
		/// すべてのレコードをアプリに共有するための変数
		/// </summary>
		public static List<Record> AllRecords { get; set; }

		/// <summary>
		/// すべてのタグをアプリに共有するための変数
		/// </summary>
		public static List<string> AllTags { get; set; }
	}
}
