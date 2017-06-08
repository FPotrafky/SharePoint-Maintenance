using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMaintenance.ViewModels
{
    class Level2Data : LevelDataBase
    {
        public List<Level3Data> level3DataCol { get; set; }

        public Level2Data()
        {
            this.level3DataCol = new List<Level3Data>();
        }
    }
}
