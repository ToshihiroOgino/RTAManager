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

namespace RTAManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyCheckedListCombo checkedListCombo = new MyCheckedListCombo();
            checkedListCombo.CheckedListBox.Items.Add("one");
            checkedListCombo.CheckedListBox.Items.Add("two");
            checkedListCombo.CheckedListBox.Items.Add("three");
            checkedListCombo.CheckedListBox.Location.Offset(13,36);

            checkedListCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(checkedListCombo);
        }

        private void Form1_Load(object sender, EventArgs e)
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

		private void AddRecBtn_Click(object sender, EventArgs e)
		{
			InputForm inputForm = new InputForm();
			inputForm.Show();
		}
	}
}
