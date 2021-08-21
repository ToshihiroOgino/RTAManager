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
    public partial class Sender : Form
    {
        public Sender()
        {
            InitializeComponent();
        }

        private void Sender_Load(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string when = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
