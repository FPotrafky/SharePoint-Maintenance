using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointMaintenance.Model
{
    class SPMSite
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string CustomMasterUrl { get; set; }
        public string MasterUrl { get; set; }

        public List<SPMList> Lists { get; set; }

        public SPMSite()
        {
            this.Lists = new List<SPMList>();
        }
    }
}
