using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMaintenance.Utils
{
    class SPMNodeInfo
    {
        public SPMNodeType NodeType { get; set; }

        public Guid ID { get; set; }

        public bool Init { get; set; }
    }
}
