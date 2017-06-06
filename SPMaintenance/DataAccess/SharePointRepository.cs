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
        public List<SPMList> getLists(string siteUrl)
        {
            List<SPMList> spmlists = new List<SPMList>();

            ClientContext ctx = new ClientContext(siteUrl);
            ctx.Credentials = new NetworkCredential("administrator", "test", "PO7");

            ListCollection lists = ctx.Web.Lists;
            ctx.Load(lists);

            ctx.ExecuteQuery();

            foreach (Microsoft.SharePoint.Client.List list in lists)
            {
                SPMList spmlist = new SPMList();
                spmlist.ID = list.Id;
                spmlist.Title = list.Title;

                spmlists.Add(spmlist);
            }

            return spmlists;
        }
    }
}
