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
        AllData allData = null;

        public MainWindow()
        {
            InitializeComponent();

            allData = new AllData();
            DataContext = allData;

            allData.level1DataCol.Add(new Level1Data() { Title = "Sites" });
            allData.level1DataCol[0].IsExpanded = true;
        }

        private void AddSiteButton_Click(object sender, RoutedEventArgs e)
        {
            //string siteUrl = this.txtSiteUrl.Text;
            //TreeViewHelper treeViewHelper = new TreeViewHelper();
            //treeViewHelper.addSiteToTreeView(this.treeView, siteUrl);
            
            Level2Data level2Data = new Level2Data() { Title = "Schalke04", DataLoaded = false, NodeType = SPMNodeType.Site };

            Level3Data level3Data = new Level3Data() { Title = "Lists", NodeType = SPMNodeType.Lists };
            level3Data.level4DataCol.Add(new Level4Data() { Title = "dummy" });
            level2Data.level3DataCol.Add(level3Data);

            level3Data = new Level3Data() { Title = "Properties", NodeType = SPMNodeType.SiteProperties };
            level3Data.level4DataCol.Add(new Level4Data() { Title = "dummy" });
            level2Data.level3DataCol.Add(level3Data);

            allData.level1DataCol[0].level2DataCol.Add(level2Data);
            
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

        private void treeView_Expanded(object sender, RoutedEventArgs e)
        {
            string sss = "";
        }
    }
}
