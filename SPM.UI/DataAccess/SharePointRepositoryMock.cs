using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharePointMaintenance.Model;

namespace SharePointMaintenance.DataAccess
{
    class SharePointRepositoryMock : ISharePointRepository
    {
        public SPMSite getSite(string url)
        {
            SPMSite mySite = new SPMSite();
            mySite.ID = Guid.NewGuid();
            mySite.Title = "Schalke04";
            mySite.MasterUrl = "My own MasterUrl";
            mySite.CustomMasterUrl = "My own CustomMasterUrl";

            return mySite;
        }
    }
}
