﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMaintenance.ViewModels
{
    class Level3Data : LevelDataBase
    {
        public List<Level4Data> level4DataCol { get; set; }

        public Level3Data()
        {
            this.level4DataCol = new List<Level4Data>();
        }
    }
}
