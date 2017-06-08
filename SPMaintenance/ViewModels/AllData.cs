using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMaintenance.ViewModels
{
    class AllData
    {
        public ObservableCollection<Level1Data> level1DataCol { get; set; }

        public AllData()
        {
            level1DataCol = new ObservableCollection<Level1Data>();

            Level1Data level1Data = new Level1Data() { Title = "Deutschland" };

            Level2Data level2Data = new Level2Data() { Title = "Bayern" };
            level1Data.level2DataCol.Add(level2Data);

            Level3Data level3Data = new Level3Data() { Title = "München" };
            level2Data.level3DataCol.Add(level3Data);

            level3Data = new Level3Data() { Title = "Nürnberg" };
            level2Data.level3DataCol.Add(level3Data);

            level1DataCol.Add(level1Data);



            level1Data = new Level1Data() { Title = "USA" };
            level1DataCol.Add(level1Data);
        }

    }
}
