using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMaintenance.ViewModels
{
    class Level1Data : LevelDataBase
    {
        public ObservableCollection<Level2Data> level2DataCol { get; set; }

        public Level1Data()
        {
            this.level2DataCol = new ObservableCollection<Level2Data>();
        }
    }
}
