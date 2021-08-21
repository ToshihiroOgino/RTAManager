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
		public InputForm()
		{
			InitializeComponent();
		}

		private void InputForm_Load(object sender, EventArgs e)
		{
			//タグ更新
			src.system.DataProcesser.getTagsFromAPI();
			foreach(string tag in src.StaticObj.AllTags)
			{
				disableComboBox.Items.Add(tag);
			}
		}

		private void enableBtn_Click(object sender, EventArgs e)
		{
			if (disableComboBox.SelectedItem == null)
				return;
		}

		private void disableBtn_Click(object sender, EventArgs e)
		{
			if (enableComboBox.SelectedItem == null)
				return;
		}

		/// <summary>
		/// 新規タグを追加
		/// </summary>
		private void AddTagBtn_Click(object sender, EventArgs e)
		{
			string tag = newTagTextBox.Text;
			if (!(tag == ""))
				src.api.ConAPI.addTags(tag);
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{

		}
	}
}
