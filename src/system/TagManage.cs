using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTAManager.src.system
{
	class TagManage
	{
		/// <summary>
		/// タグの整合性を確認し修正する関数
		/// </summary>
		public static void ConsistencyChecker()
		{
			var tags = StaticObj.AllTags;

			bool[] checkList = new bool[tags.Count];//削除するIndexをfalseとする
			for (int i = 0; i < tags.Count; i++)
				checkList[i] = true;
			//重複タグを削除したリストを作成し、アプリ全体に共有する
			List<string> newTagList = new List<string>();
			for (int i = 0; i < tags.Count; i++)
			{
				if (checkList[i])
					newTagList.Add(tags[i]);
			}
			StaticObj.AllTags = newTagList;

			tags = newTagList;
			var records = StaticObj.AllRecords;

			//レコードにしか存在しないタグを検出する
			foreach (Record rec in records) //すべてのレーコード
			{
				foreach (string recTag in rec.tag) //recが内包するすべてのタグ
				{
					bool isExist = false;
					foreach (string existTag in tags) //すでにシートに記載されているすべてのタグ
					{
						if (recTag == existTag)
						{
							isExist = true;
							break;
						}
					}
					//レコードにしかないタグをシートに追加する
					if (!isExist)
					{
						//TODO タグ追加API呼び出し(recTagを引数にする)
					}
				}
			}
		}
	}
}
