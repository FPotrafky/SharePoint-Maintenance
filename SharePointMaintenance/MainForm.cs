using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharePointMaintenance
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode clickedNode = this.mainTreeView.GetNodeAt(e.X, e.Y);
            if (clickedNode.Bounds.Contains(e.X, e.Y))
            {
                this.mainTreeView.SelectedNode = clickedNode;
            }
        }

    }
}
