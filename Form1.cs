using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Runtime.Serialization;

namespace RTAManager
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			src.system.DataProcesser.getRedordsFromAPI();
			src.system.DataProcesser.getTagsFromAPI(); //タグ取得

			//表の表示
			UpdateTable(src.StaticObj.AllRecords);

			foreach (string tag in src.StaticObj.AllTags)
			{
				TagCheckBox.Items.Add(tag);
			}

			/* MyCheckedListCombo checkedListCombo = new MyCheckedListCombo();
             checkedListCombo.CheckedListBox.Location.;

             checkedListCombo.SelectedIndexChanged += new EventHandler(checkedListBoxUpdated);
             checkedListCombo.Name = "TagCheckBox";

             foreach(string tag in src.StaticObj.AllTags)
             {
                 checkedListCombo.CheckedListBox.Items.Add(tag);
             }
             checkedListCombo.DropDownStyle = ComboBoxStyle.DropDownList;
             this.Controls.Add(checkedListCombo);*/

		}

		private void checkedListBoxUpdated(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		[SecurityPermissionAttribute(
		SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public class MyCheckedListCombo : ComboBox
		{
			ToolStripControlHost checkedListHost;
			ToolStripDropDown dropDown;
			DateTime listClosedTime;
			public MyCheckedListCombo()
			{
				CheckedListBox checkedListBox = new CheckedListBox();
				checkedListBox.BorderStyle = BorderStyle.None;
				checkedListHost = new ToolStripControlHost(checkedListBox);
				dropDown = new ToolStripDropDown();
				dropDown.Items.Add(checkedListHost);

				dropDown.Opened += DropDown_Opened;
				dropDown.Closed += DropDown_Closed;
			}

			private void DropDown_Closed(object sender, ToolStripDropDownClosedEventArgs e)
			{
				listClosedTime = DateTime.Now;
			}

			private void DropDown_Opened(object sender, EventArgs e)
			{
				System.Diagnostics.Debug.Print("DropDown_Opened: {0} {1}", this.DroppedDown, "");
			}

			public CheckedListBox CheckedListBox
			{
				get { return checkedListHost.Control as CheckedListBox; }
			}

			private void ShowDropDown()
			{
				if (dropDown != null)
				{
					if (DateTime.Now < listClosedTime.AddMilliseconds(300.0))
					{
						/// リストが消えた直後にクリックされた場合は、無視する
						return;
					}
					checkedListHost.Width = DropDownWidth;
					checkedListHost.Height = DropDownHeight;
					dropDown.Show(this, 0, this.Height);

					System.Diagnostics.Debug.Print("ShowDropDown: {0} {1}", this.DroppedDown, dropDown.Visible);
				}
			}
			private const int WM_USER = 0x0400,
						 WM_REFLECT = WM_USER + 0x1C00,
						 WM_COMMAND = 0x0111,
						 WM_LBUTTONDOWN = 0x201,
						 CBN_DROPDOWN = 7;

			public static int HIWORD(int n)
			{
				return (n >> 16) & 0xffff;
			}

			protected override void WndProc(ref Message m)
			{
				if (m.Msg == WM_LBUTTONDOWN)        // WM_LBUTTONDOWN = 0x201
				{
					ShowDropDown();
					return;
				}
				if (m.Msg == (WM_REFLECT + WM_COMMAND))
				{
					if (HIWORD((int)m.WParam) == CBN_DROPDOWN)
					{
						System.Diagnostics.Debug.Print("### message: {0}", m.ToString());
						ShowDropDown();
						return;
					}
				}
				base.WndProc(ref m);
			}

			protected override void Dispose(bool disposing)
			{
				if (disposing)
				{
					if (dropDown != null)
					{
						dropDown.Dispose();
						dropDown = null;
					}
				}
				base.Dispose(disposing);
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			InputForm inputForm = new InputForm();
			inputForm.Show();
		}

		private void reloadButton_Click(object sender, EventArgs e)
		{
			src.system.DataProcesser.getRedordsFromAPI();
			src.system.DataProcesser.getTagsFromAPI();
			src.system.TagManage.ConsistencyChecker();

			//チェックボックスのリストを更新
			TagCheckBox.Items.Clear();
			foreach (string tag in src.StaticObj.AllTags)
				TagCheckBox.Items.Add(tag);

			//表を更新
			UpdateTable(src.StaticObj.AllRecords);
		}

		private void TagCheckBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<string> enableTags = new List<string>();
			foreach (string tag in TagCheckBox.CheckedItems)
				enableTags.Add(tag);

			//表を更新
			UpdateTable(src.system.RecordsOrganizer.perfectMatchRecords(enableTags));
		}

		/// <summary>
		/// 表を更新する関数
		/// </summary>
		/// <param name="Records">参考データ</param>
		private void UpdateTable(List<src.Record> Records)
		{
			List<Tempotags> tags = new List<Tempotags>();
			foreach (src.Record records in Records)
			{
				Tempotags tagsForView = new Tempotags();
				tagsForView.tag = null;
				tagsForView.name = records.name;
				tagsForView.score = records.score;
				tagsForView.when = records.when;
				tagsForView.comment = records.comment;
				foreach (string tag in records.tag)
				{
					tagsForView.tag += tag + ",";
				}
				tags.Add(tagsForView);
			}

			dataGridView1.DataSource = tags;
		}
	}

	class Tempotags
	{
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
		public string tag { get; set; }

		/// <summary>コメント</summary>
		[DataMember]
		public string comment { get; set; }
	}

}
