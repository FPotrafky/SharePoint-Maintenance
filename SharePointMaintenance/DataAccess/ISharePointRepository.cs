using SharePointMaintenance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointMaintenance.DataAccess
{
    interface ISharePointRepository
    {
        SPMSite getSite(string url);
    }
}
