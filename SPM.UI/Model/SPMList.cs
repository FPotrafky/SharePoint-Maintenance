using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM.UI.Model
{
    class SPMList
    {
        public Guid ID { get; }
        public string Title { get; set; }
        public bool ShowInDisplayForm { get; set; }
        public bool ShowInNewForm { get; set; }
        public bool ShowInEditForm { get; set; }
        public bool Hidden { get; set; }
    }
}
