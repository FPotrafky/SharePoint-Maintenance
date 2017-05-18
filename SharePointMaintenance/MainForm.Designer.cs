namespace SharePointMaintenance
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("SiteCollection");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node2");
            this.contextMenuStripSiteCollections = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddSiteCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuStripSiteCollections.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripSiteCollections
            // 
            this.contextMenuStripSiteCollections.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStripSiteCollections.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddSiteCollection});
            this.contextMenuStripSiteCollections.Name = "contextMenuStripSiteCollections";
            this.contextMenuStripSiteCollections.Size = new System.Drawing.Size(173, 26);
            // 
            // toolStripMenuItemAddSiteCollection
            // 
            this.toolStripMenuItemAddSiteCollection.Name = "toolStripMenuItemAddSiteCollection";
            this.toolStripMenuItemAddSiteCollection.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemAddSiteCollection.Text = "Add SiteCollection";
            // 
            // mainTreeView
            // 
            this.mainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTreeView.Location = new System.Drawing.Point(49, 73);
            this.mainTreeView.Margin = new System.Windows.Forms.Padding(1);
            this.mainTreeView.Name = "mainTreeView";
            treeNode1.ContextMenuStrip = this.contextMenuStripSiteCollections;
            treeNode1.Name = "SiteCollection";
            treeNode1.Text = "SiteCollection";
            treeNode2.ContextMenuStrip = this.contextMenuStripSiteCollections;
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Node1";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Node2";
            this.mainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.mainTreeView.Size = new System.Drawing.Size(289, 174);
            this.mainTreeView.TabIndex = 0;
            this.mainTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainTreeView_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 432);
            this.Controls.Add(this.mainTreeView);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.contextMenuStripSiteCollections.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSiteCollections;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddSiteCollection;
    }
}

