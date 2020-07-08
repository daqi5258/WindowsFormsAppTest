using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace WindowsFormsAppTest
{
    public partial class importForm : Form
    {
        private mainForm mainForm;
       
        public importForm(mainForm mainForm)
        {
            
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fileText_TextChanged(object sender, EventArgs e)
        {

        }

        private void xzButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(fileText.ToString());
            //System.Diagnostics.Process.Start("Explorer.exe", SelectPath());
            fileText.Text = SelectPath();
            
            //Console.WriteLine(Environment.CurrentDirectory);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            FileManager file = new FileManager();
           String str= file.readFile2(fileText.Text);
            RichTextBox richTextBox = (RichTextBox)mainForm.Controls.Find("textArea",false)[0];
            richTextBox.Text = str;
            this.Dispose(true);
        }

        //获取文件所在的文件夹
        private string SelectPath()
        {
            string path = null;
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Files (*.*)|*.txt"//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            };
            var result = openFileDialog.ShowDialog();
            //Console.WriteLine("点击结果："+result);
            if (result.Equals("OK") || result == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
            //Console.WriteLine("路径为{0}",path);
            return path;
        }
    }
}
