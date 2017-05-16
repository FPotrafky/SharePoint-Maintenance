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
            this.contextMenuStripSiteCollections.Size = new System.Drawing.Size(342, 50);
            // 
            // toolStripMenuItemAddSiteCollection
            // 
            this.toolStripMenuItemAddSiteCollection.Name = "toolStripMenuItemAddSiteCollection";
            this.toolStripMenuItemAddSiteCollection.Size = new System.Drawing.Size(341, 46);
            this.toolStripMenuItemAddSiteCollection.Text = "Add SiteCollection";
            // 
            // mainTreeView
            // 
            this.mainTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTreeView.Location = new System.Drawing.Point(130, 174);
            this.mainTreeView.Name = "mainTreeView";
            treeNode1.ContextMenuStrip = this.contextMenuStripSiteCollections;
            treeNode1.Name = "SiteCollection";
            treeNode1.Text = "SiteCollection";
            this.mainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.mainTreeView.Size = new System.Drawing.Size(765, 410);
            this.mainTreeView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 1031);
            this.Controls.Add(this.mainTreeView);
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

