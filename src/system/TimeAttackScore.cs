using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTAManager.src.system
{
	class TimeAttackScore
	{
		/// <summary>作成者</summary>
		public string Publisher { get; set; }

		/// <summary>スコア</summary>
		public string Record { get; set; }

		/// <summary>記録時間</summary>
		public string Time { get; set; }

		/// <summary>タグ</summary>
		public List<string> Tag { get; set; }

		/// <summary>コメント</summary>
		public string Comment { get; set; }
	}
}
