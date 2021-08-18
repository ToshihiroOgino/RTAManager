// 参考:http://tryerror.net/tryerror/wordpress/post-201

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace RTAManager.src.system
{
	public class DataProcesser
	{
		/// <summary>
		/// APIから取得したJsonをリストに変換する関数
		/// </summary>
		/// <returns>Record</returns>
		public static List<Record> JsonToList(List<string> tags)
		{
			string jsonString = null;
			//TODO:API呼び出し

			//デシリアライズ
			List<TempRecord> tempList = (List<TempRecord>)getObjectFromJson(jsonString, typeof(List<TempRecord>));

			//Record型に変換する
			List<Record> result = new List<Record>();
			foreach (TempRecord temp in tempList)
			{
				var rec = new Record();
				//タグをリストに変換
				while (temp.tag.Length != 0)
				{
					//カンマまでtemp.tagを抜き出してリストに加える。もしカンマがなかった場合は全体をリストに加える
					int length = temp.tag.IndexOf(",") != -1 ? temp.tag.IndexOf(",") : temp.tag.Length;
					rec.tag.Add(temp.tag.Substring(0, length));
					
					//抜き出した部分を切り捨てる
					temp.tag = temp.tag.Substring(length);
					//1文字目がカンマだった場合はカンマを取り除く
					if (temp.tag.Substring(0, 1) == ",")
						temp.tag = temp.tag.Substring(1);
				}
				//その他はString型のまま情報を複製
				rec.score = temp.score;
				rec.name = temp.name;
				rec.when = temp.when;
				rec.comment = temp.comment;
				//戻り値に抽出した情報を追加
				result.Add(rec);
			}
			return result;
		}

		/// <summary>
		/// Jsonをデシリアライズする関数
		/// </summary>
		private static Object getObjectFromJson(string jsonString, Type type)
		{
			var serializer = new DataContractJsonSerializer(type);
			var jsonBytes = Encoding.Unicode.GetBytes(jsonString);
			var sr = new MemoryStream(jsonBytes);
			return serializer.ReadObject(sr);
		}
	}

	[DataContract]
	class TempRecord
	{
		[DataMember]
		public string name { get; set; }

		[DataMember]
		public string score { get; set; }

		[DataMember]
		public string when { get; set; }

		[DataMember]
		public string tag { get; set; }

		[DataMember]
		public string comment { get; set; }
	}
}
