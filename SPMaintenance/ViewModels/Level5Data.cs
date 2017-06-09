using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMaintenance.ViewModels
{
    class Level5Data : LevelDataBase
    {
        public List<Level6Data> level6DataCol { get; set; }

        public Level5Data()
        {
            this.level6DataCol = new List<Level6Data>();
        }
    }
}
