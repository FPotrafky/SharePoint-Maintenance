using SPMaintenance.DataAccess;
using SPMaintenance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMaintenance.Services
{
    class DataService
    {
        private SharePointRepository sharePointRepository;

        public DataService()
        {
            sharePointRepository = new SharePointRepository();
        }
        public SPMSite getSite(string url)
        {
            SPMSite site = sharePointRepository.getSite(url);

            return site;
        }
    }
}
