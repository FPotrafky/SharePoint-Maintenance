using SPMaintenance.DataAccess;
using SPMaintenance.Model;
using SPMaintenance.Utils;
using SPMaintenance.ViewModels;
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

        public List<SPMList> getLists(LevelDataBase selectedNode)
        {
            // Der selectedNode muss hier eigentlich ein Lists-Knoten sein
            // Dessen Parent muss ein Site-Knoten sein, aus dem wir die Site-Informationen
            // holen, die notwendig sind um die Listen zu finden

            if (selectedNode.NodeType == SPMNodeType.Lists)
            {
                LevelDataBase siteNode = selectedNode.Parent;

                if (siteNode.NodeType == SPMNodeType.Site)
                {
                    SPMSite site = siteNode.SPMData as SPMSite;

                    if (site != null)
                    {
                        
                    }
                }
            }

            List<SPMList> lists = new List<SPMList>();

            lists.Add(new SPMList() { Title = "Schalke 04" });
            lists.Add(new SPMList() { Title = "BVB 09" });
            lists.Add(new SPMList() { Title = "1. FC Köln" });
            lists.Add(new SPMList() { Title = "RW Essen" });


            return lists;
        }
    }
}
