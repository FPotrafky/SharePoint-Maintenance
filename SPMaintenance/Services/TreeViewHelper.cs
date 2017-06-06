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
        private SharePointRepository _repo = null;
        public TreeViewHelper()
        {
            _repo = new SharePointRepository();
        }

        public void addSiteToTreeView(TreeView inTreeView, string siteUrl)
        {
            SPMSite site = this._repo.getSite(siteUrl);

            if (site != null)
            {
                TreeViewItem treeViewItemSite = new TreeViewItem() { Header = site.Title };
                treeViewItemSite.IsExpanded = true;
                treeViewItemSite.Expanded += NewTreeViewItem_Expanded;
                treeViewItemSite.Tag = new SPMNodeInfo() {
                    NodeType = SPMNodeType.Site,
                    ID = site.ID,
                    SiteUrl = siteUrl
                };

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
            else
            {

            }

        }

        private void NewTreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem originator = e.OriginalSource as TreeViewItem;

            if (originator != null)
            {
                //MessageBox.Show("Hallo. Ich wurde angestossen durch: " + originator.Header);

                SPMNodeInfo nodeInfo = originator.Tag as SPMNodeInfo;
                if (nodeInfo != null)
                {
                    if (nodeInfo.NodeType == SPMNodeType.Lists && nodeInfo.Init == true)
                    {
                        // Wir brauchen den SiteNode. Der ist genau einen ueber dem Lists Knoten, also der Parent
                        TreeViewItem siteNode = originator.Parent as TreeViewItem;
                        if (siteNode != null)
                        {
                            SPMNodeInfo siteNodeInfo = siteNode.Tag as SPMNodeInfo;
                            if (siteNodeInfo != null)
                            {
                                string siteUrl = siteNodeInfo.SiteUrl;
                                List<SPMList> lists = this._repo.getLists(siteUrl);

                                originator.Items.Clear();

                                foreach (SPMList list in lists)
                                {
                                    TreeViewItem treeViewItemList = new TreeViewItem()
                                    {
                                        Header = list.Title,
                                        Tag = new SPMNodeInfo()
                                        {
                                            NodeType = SPMNodeType.List,
                                            ID = list.ID,
                                            SiteUrl = string.Empty,
                                            Init = true
                                        }
                                    };

                                    TreeViewItem treeViewItemFields = new TreeViewItem()
                                    {
                                        Header = "Fields",
                                        Tag = new SPMNodeInfo()
                                        {
                                            NodeType = SPMNodeType.ListFields,
                                            Init = true
                                        }
                                    };

                                    // Creating the dummy item under Fields
                                    treeViewItemFields.Items.Add(new TreeViewItem() { Header = "dummy" });

                                    // Adding the fields node to the list node
                                    treeViewItemList.Items.Add(treeViewItemFields);

                                    // Adding the list node to the lists node
                                    originator.Items.Add(treeViewItemList);
                                }
                            }
                        }
                    }
                    nodeInfo.Init = false;
                }
            }
        }
    }
}
