using SharePointMaintenance.DataAccess;
using SharePointMaintenance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointMaintenance.Services
{
    class SharePointDataService
    {
        ISharePointRepository repository = new SharePointRepository();
        public SharePointDataService()
        {
            
        }

        public SPMSite getSite(string url)
        {
            return repository.getSite(url);
        }
    }
}
