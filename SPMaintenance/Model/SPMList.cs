﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMaintenance.Model
{
    class SPMList
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public bool ShowInDisplayForm { get; set; }
        public bool ShowInNewForm { get; set; }
        public bool ShowInEditForm { get; set; }
        public bool Hidden { get; set; }
    }
}
