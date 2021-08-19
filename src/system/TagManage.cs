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

			/*x
			bool[] checkList = new bool[tags.Count];//削除するIndexをfalseとする
			for (int i = 0; i < tags.Count; i++)
				checkList[i] = true;
			//タグの重複を確認する
			for (int i = 0; i < tags.Count; i++)
			{
				if (checkList[i])//すでに削除予定とされているIndexでは探索を行わない
					for (int j = i; i < tags.Count; i++)
					{
						//消去予定のIndexはtrueにする
						if (tags[i] == tags[j])
						{
							checkList[j] = false;
							//TODOタグ削除API呼び出し
						}
					}
			}
			//重複タグを削除したリストを作成する
			List<string> newTagList = new List<string>();
			for (int i = 0; i < tags.Count; i++)
			{
				if (checkList[i])
					newTagList.Add(tags[i]);
			}
			//アプリ全体に新しいタグのリストを共有する
			StaticObj.AllTags = newTagList;
			tags = newTagList;
			*/

			//レコードにしか存在しないタグを検出する
			var records = StaticObj.AllRecords;
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