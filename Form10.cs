using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm3
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbNode.Text == "")
            {
                MessageBox.Show("텍스트 박스에 입력하세요.");
                return;
            }
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add(tbNode.Text);
                tbNode.Text = "";
            }
            else
            {
                treeView1.Nodes.Add(tbNode.Text);
                tbNode.Text = "";
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            treeView1 .CollapseAll();
        }
    }
}
