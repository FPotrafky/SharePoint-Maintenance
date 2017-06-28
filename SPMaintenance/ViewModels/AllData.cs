using SPMaintenance.Model;
using SPMaintenance.Services;
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
    class AllData : AllDataBase
    {
        public DataService dataService;
        
        public ObservableCollection<Level1Data> level1DataCol { get; set; }

        public ICommand AddSiteCommand { get; set; }

        public AllData()
        {
            dataService = new DataService();
            
            LoadCommands();

            level1DataCol = new ObservableCollection<Level1Data>();

        }

        public string SiteToAddUrl { get; set; }

        private void LoadCommands()
        {
            AddSiteCommand = new CustomCommand(AddSite, null);
        }
        private void AddSite(object obj)
        {
            try
            {
                SPMSite siteToAdd = dataService.getSite(SiteToAddUrl);
                Level2Data level2Data = new Level2Data() { Title = siteToAdd.Title, DataLoaded = true, NodeType = SPMNodeType.Site };
                // Adds the SPMSite Object to the level2Data object
                level2Data.SPMData = siteToAdd;

                // Wir fügen dem Site-Knoten jetzt automatisch einen Properties- und einen Lists Knoten hinzu
                // Erst den Properties-Knoten
                Level3Data level3Data = new Level3Data() { Title = "Properties", DataLoaded = false, NodeType = SPMNodeType.SiteProperties, Parent = level2Data };
                level2Data.level3DataCol.Add(level3Data);

                Level4Data level4Data = new Level4Data() { Title = "Dummy", DataLoaded = false, NodeType = SPMNodeType.None, Parent = level3Data };
                level3Data.level4DataCol.Add(level4Data);

                // Dann den Lists-Knoten
                level3Data = new Level3Data() { Title = "Lists", DataLoaded = false, NodeType = SPMNodeType.Lists, Parent = level2Data };
                level2Data.level3DataCol.Add(level3Data);

                level4Data = new Level4Data() { Title = "Dummy", DataLoaded = false, NodeType = SPMNodeType.None, Parent = level3Data };
                level3Data.level4DataCol.Add(level4Data);

                // Wir fügen dem Level1, der ja immer der fixe Sites-Knoten ist, einen Site-Knoten hinzu
                level1DataCol[0].level2DataCol.Add(level2Data);

            }
            catch(Exception ex)
            {
                MessageColor = "Red";
                Message = "Die angegebene Site kann nicht geöffnet werden.";
            }
        }
    }
}
