using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void etMenu_Click(object sender, EventArgs e)
        {
            Console.WriteLine("你点击了{0}按钮，出发了{1}事件",sender.ToString(),e.ToString());
            base.Dispose(true);
        }

        private void importMenu_Click(object sender, EventArgs e)
        {
            Console.WriteLine("你点击了{0}按钮，出发了{1}事件", sender.ToString(), e.ToString());
            importForm importForm = new importForm(this);
            importForm.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
}
