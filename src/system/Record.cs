using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace RTAManager.src.system
{
	public class Record
	{
		/// <summary>作成者</summary>
		[DataMember]
		public string name { get; set; }

		/// <summary>スコア</summary>
		[DataMember]
		public string score { get; set; }

		/// <summary>記録時間</summary>
		[DataMember]
		public string when { get; set; }

		/// <summary>タグ</summary>
		[DataMember]
		public List<string> tag { get; set; }

		/// <summary>コメント</summary>
		[DataMember]
		public string comment { get; set; }
	}
}
