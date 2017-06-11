using SPMaintenance.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SPMaintenance.ViewModels
{
    class AllData
    {
        public ObservableCollection<Level1Data> level1DataCol { get; set; }

        public ICommand AddSiteCommand { get; set; }

        public AllData()
        {
            level1DataCol = new ObservableCollection<Level1Data>();
            LoadCommands();
        }

        private void LoadCommands()
        {
            AddSiteCommand = new CustomCommand(AddSite, null);
        }
        private void AddSite(object obj)
        {
            Level2Data level2Data = new Level2Data() { Title = "Schalke04", DataLoaded = false, NodeType = SPMNodeType.Site };
            level1DataCol[0].level2DataCol.Add(level2Data);
        }
    }
}
