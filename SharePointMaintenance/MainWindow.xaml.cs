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

namespace SharePointMaintenance
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

        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem treeViewItem = e.OriginalSource as TreeViewItem;
            
            MessageBox.Show("Hallo: " + treeViewItem.Header);
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    TreeViewItem newTreeViewItem = new TreeViewItem() { Header = "Neue Site" };
        //    newTreeViewItem.IsExpanded = true;

        //    TreeViewItem newTreeViewItemLists = new TreeViewItem() { Header = "Lists", Tag = "init" };
        //    newTreeViewItemLists.Expanded += NewTreeViewItemLists_Expanded;
        //    newTreeViewItemLists.Items.Add(new TreeViewItem() { Header = "dummy" });
        //    newTreeViewItem.Items.Add(newTreeViewItemLists);

        //    TreeViewItem newTreeViewItemProperties = new TreeViewItem() { Header = "Properties" };
        //    newTreeViewItemProperties.Items.Add(new TreeViewItem() { Header = "dummy" });
        //    newTreeViewItem.Items.Add(newTreeViewItemProperties);


        //    this.treeView.Items.Add(newTreeViewItem);
        //}

        //private void NewTreeViewItemLists_Expanded(object sender, RoutedEventArgs e)
        //{
        //    TreeViewItem treeViewItem = (TreeViewItem)sender;
        //    if (treeViewItem.Tag.ToString() == "init")
        //    {
        //        // Daten müssen aus SharePoint geladen werden
        //        treeViewItem.Items.Clear();

        //        treeViewItem.Items.Add(new TreeViewItem() { Header = "Documents 1" });
        //        treeViewItem.Items.Add(new TreeViewItem() { Header = "Documents 2" });
        //        treeViewItem.Items.Add(new TreeViewItem() { Header = "Documents 3" });

        //        treeViewItem.Header = string.Format("Lists [{0}]", 3);
        //    }
        //    else
        //    {
        //        // Daten sind bereits einmal geladen worden
        //    }
        //}
    }
}
