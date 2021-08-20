using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTAManager.src.system
{
	class RecordsOrganizer
	{
		/// <summary>
		/// 指定したタグの一部を持つRecordを返す関数
		/// </summary>
		/// <param name="tags">指定したいタグ</param>
		/// <returns>指定したタグの一部を持つRecord</returns>
		public static List<Record> partialMatchRecords(List<string> tags)
		{
			List<Record> records = StaticObj.AllRecords;
			List<Record> result = new List<Record>();

			foreach (Record rec in records) //すべてのレーコード
			{
				foreach (string recTag in rec.tag) //recが内包するすべてのタグ
				{
					//recTagがtagsに含まれているかを確認
					if (tags.Contains(recTag))
					{
						result.Add(rec);
						break;
					}
				}
			}

			return result;
		}

		/// <summary>
		/// 指定したすべてのタグを持つRecordを返す関数
		/// </summary>
		/// <param name="tags">指定したいタグ</param>
		/// <returns>指定したすべてのタグを持つRecord</returns>
		public static List<Record> perfectMatchRecords(List<string> tags)
		{
			List<Record> records = StaticObj.AllRecords;
			List<Record> result = new List<Record>();

			foreach (Record rec in records) //すべてのレーコード
			{
				bool enable = true;
				foreach (string checkingTag in tags) //引数で指定されたすべてのタグ
				{
					if (!rec.tag.Contains(checkingTag))
					{
						enable = false;
						break;
					}
				}
				if (enable)
					result.Add(rec);
			}

			return result;
		}
	}
}
