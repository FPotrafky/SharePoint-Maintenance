using SPMaintenance.Services;
using SPMaintenance.Utils;
using SPMaintenance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SPMaintenance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddSiteButton_Click(object sender, RoutedEventArgs e)
        {
            //string siteUrl = this.txtSiteUrl.Text;
            //TreeViewHelper treeViewHelper = new TreeViewHelper();
            //treeViewHelper.addSiteToTreeView(this.treeView, siteUrl);

            AllData allData = new AllData();
            DataContext = allData;
        }

        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem selectedItem = e.NewValue as TreeViewItem;
            if (selectedItem != null)
            {
                SPMNodeInfo nodeInfo = selectedItem.Tag as SPMNodeInfo;
                if (nodeInfo != null)
                {
                    if (nodeInfo.NodeType == SPMNodeType.Site)
                    {
                        //DataContext = new SiteViewModel();
                    }
                    else if (nodeInfo.NodeType == SPMNodeType.List)
                    {
                        //DataContext = new ListViewModel();
                    }
                }
            }
        }
    }
}
