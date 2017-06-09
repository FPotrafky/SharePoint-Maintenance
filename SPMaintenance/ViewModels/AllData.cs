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
        }

    }
}
