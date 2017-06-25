using SPMaintenance.Model;
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

            allData.SiteToAddUrl = "http://work02";

            DetailsPage.DataContext = null;
        }


        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            LevelDataBase selectedNode = e.NewValue as LevelDataBase;

            if (selectedNode != null)
            {
                DetailsPage.DataContext = selectedNode.SPMData;
            }

            //if (selectedItem != null)
            //{
            //    SPMNodeInfo nodeInfo = selectedItem.Tag as SPMNodeInfo;
            //    if (nodeInfo != null)
            //    {
            //        if (nodeInfo.NodeType == SPMNodeType.Site)
            //        {
            //            //DataContext = new SiteViewModel();
            //        }
            //        else if (nodeInfo.NodeType == SPMNodeType.List)
            //        {
            //            //DataContext = new ListViewModel();
            //        }
            //    }
            //}
        }

        private void treeView_Expanded(object sender, RoutedEventArgs e)
        {
            string sss = "";
        }
    }
}
