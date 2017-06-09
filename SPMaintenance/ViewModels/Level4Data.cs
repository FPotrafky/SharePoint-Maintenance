using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMaintenance.ViewModels
{
    class Level4Data : LevelDataBase
    {
        public List<Level5Data> level5DataCol { get; set; }

        public Level4Data()
        {
            this.level5DataCol = new List<Level5Data>();
        }
    }
}
