using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTAManager
{
	public partial class InputForm : Form
	{
		private int hour;
		private int min;
		private int sec;

		public InputForm()
		{
			InitializeComponent();
		}

		private void InputForm_Load(object sender, EventArgs e)
		{
			//タグ更新
			src.system.DataProcesser.getTagsFromAPI();
			foreach (string tag in src.StaticObj.AllTags)
			{
				disableComboBox.Items.Add(tag);
			}
		}

		private void enableBtn_Click(object sender, EventArgs e)
		{
			//タグ追加
			if (disableComboBox.SelectedItem == null)
				return;

			if (disableComboBox.SelectedItem != null)
			{
				enableComboBox.Items.Add(disableComboBox.SelectedItem);
				disableComboBox.Items.Remove(disableComboBox.SelectedItem);
				disableComboBox.Text = null;
			}
		}

		private void disableBtn_Click(object sender, EventArgs e)
		{
			//タグ削除
			if (enableComboBox.SelectedItem == null)
				return;

			if (enableComboBox.SelectedItem != null)
			{
				disableComboBox.Items.Add(enableComboBox.SelectedItem);
				enableComboBox.Items.Remove(enableComboBox.SelectedItem);
				enableComboBox.Text = null;
			}
		}

		/// <summary>
		/// 新規タグを追加
		/// </summary>
		private void AddTagBtn_Click(object sender, EventArgs e)
		{
			string tag = newTagTextBox.Text;
			if (tag == "")
				return;
			disableComboBox.Items.Add(tag);
			if (src.StaticObj.AllTags == null)//初期化されていない場合の対策
				src.StaticObj.AllTags = new List<string>();
			//タグ追加
			src.StaticObj.AllTags.Add(tag);
			src.api.ConAPI.addTags(tag);
			//テキストボックスを空白にする
			newTagTextBox.Text = null;
		}

		/// <summary>
		/// 情報登録
		/// </summary>
		private void AddBtn_Click(object sender, EventArgs e)
		{
			//入力読み込み
			string name = NameTextBox.Text;
			int record = hour * 60 * 60 + min * 60 + sec;
			List<string> tags = new List<string>();
			foreach (string tagName in enableComboBox.Items)
				tags.Add(tagName);
			string comment = commentRichTextBox.Text;

			if (name != "" && record != 0 && tags.Count != 0)//空白をチェック
			{
				//追加するデータを作成
				src.Record rec = new src.Record();
				rec.name = name;
				rec.score = record.ToString();
				rec.when = DateTime.Now.ToString();
				rec.comment = comment;
				rec.tag = new List<string>();
				foreach (string tagName in enableComboBox.Items)
					rec.tag.Add(tagName);
				if (src.StaticObj.AllRecords == null)//初期化されていない場合の対策
					src.StaticObj.AllRecords = new List<src.Record>();
				//データを追加
				src.StaticObj.AllRecords.Add(rec);
				src.api.ConAPI.addRecord(rec);
				//タグ確認
				src.system.TagManage.ConsistencyChecker();
				//入力フォームの終了
				this.Close();
				MessageBox.Show("情報を追加しました");
			}
			else
			{
				MessageBox.Show("入力されていない項目があります");
			}
		}

		private void hourBox_TextChanged(object sender, EventArgs e)
		{
			int temp = hour;
			if (!int.TryParse(minutsBox.Text, out min))
				minutsBox.Text = null;
			else
				min = temp;
		}

		private void minutsBox_TextChanged(object sender, EventArgs e)
		{
			int temp = min;

			if (!int.TryParse(minutsBox.Text, out min))//数字ではなかった場合
			{
				minutsBox.Text = null;
				min = temp;
			}

			if (0 > min || min >= 60)//ありえない数値だった場合
			{
				minutsBox.Text = null;
				min = temp;
			}
		}

		private void secondBox_TextChanged(object sender, EventArgs e)
		{
			int temp = sec;
			if (!int.TryParse(secondBox.Text, out sec))//数字ではなかった場合
			{
				secondBox.Text = null;
				sec = temp;
			}
			if (0 > sec || sec >= 60)//ありえない数値だった場合
			{
				minutsBox.Text = null;
				sec = temp;
			}
		}
	}
}
