using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMaintenance.Model;
using Microsoft.SharePoint.Client;
using System.Net;

namespace SPMaintenance.DataAccess
{
    class SharePointRepository : ISharePointRepository
    {
        public object SPMWeb { get; private set; }

        public SPMSite getSite(string siteUrl)
        {
            ClientContext ctx = new ClientContext(siteUrl);
            ctx.Credentials = new NetworkCredential("administrator", "test", "PO7");

            Web web = ctx.Web;

            ctx.Load(web);

            ctx.ExecuteQuery();

            SPMSite spmsite = new SPMSite();
            spmsite.ID = web.Id;
            spmsite.Title = web.Title;

            return spmsite;
        }
    }
}
