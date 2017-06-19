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
            Web web = null;
            try
            {
                ClientContext ctx = new ClientContext(siteUrl);
                ctx.Credentials = new NetworkCredential("administrator", "test", "PO7");
                web = ctx.Web;
                ctx.Load(web);

                ctx.ExecuteQuery();
            }
            catch(Exception ex)
            {
                // TODO: Hier wegschreiben des Fehlers in Textdatei

                // Dann weitergeben des Fehlers. Aber aufrufende Stelle gibt eine für den Benutzer verständliche Info raus.
                throw ex;
            }
   
            SPMSite spmsite = new SPMSite();
            spmsite.ID = web.Id;
            spmsite.Title = web.Title;
            spmsite.MasterUrl = web.MasterUrl;
            spmsite.CustomMasterUrl = web.CustomMasterUrl;

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
