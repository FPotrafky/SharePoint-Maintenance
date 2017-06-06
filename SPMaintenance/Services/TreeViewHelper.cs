using SPMaintenance.DataAccess;
using SPMaintenance.Model;
using SPMaintenance.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SPMaintenance.Services
{
    class TreeViewHelper
    {
        public void addSiteToTreeView(TreeView inTreeView, string siteUrl)
        {
            SharePointRepository SPRepo = new SharePointRepository();
            SPMSite site = SPRepo.getSite(siteUrl);


            TreeViewItem treeViewItemSite = new TreeViewItem() { Header = site.Title };
            treeViewItemSite.IsExpanded = true;
            treeViewItemSite.Expanded += NewTreeViewItem_Expanded;
            treeViewItemSite.Tag = new SPMNodeInfo() { NodeType = SPMNodeType.Site };

            TreeViewItem treeViewItemLists = new TreeViewItem()
            {
                Header = "Lists",
                Tag = new SPMNodeInfo()
                {
                    NodeType = SPMNodeType.Lists,
                    Init = true
                }
            };
            treeViewItemLists.Items.Add(new TreeViewItem() { Header = "dummy" });
            treeViewItemSite.Items.Add(treeViewItemLists);

            TreeViewItem treeViewItemProperties = new TreeViewItem()
            {
                Header = "Properties",
                Tag = new SPMNodeInfo()
                {
                    NodeType = SPMNodeType.SiteProperties,
                    Init = true
                }
            };
            treeViewItemProperties.Items.Add(new TreeViewItem() { Header = "dummy" });
            treeViewItemSite.Items.Add(treeViewItemProperties);

            inTreeView.Items.Add(treeViewItemSite);
        }

        private void NewTreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem originator = e.OriginalSource as TreeViewItem;

            if (originator != null)
            {
                MessageBox.Show("Hallo. Ich wurde angestossen durch: " + originator.Header);

            }
        }






    }
}
