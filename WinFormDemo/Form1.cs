using System;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“testDataSet.User”中。您可以根据需要移动或删除它。
            userTableAdapter.Fill(testDataSet.User);

        }
    }
}
