using System;
using System.Collections.Generic;
using System.Linq;
using Autohaus.Data.Models;
using Glass.Mapper.Sc;
using Sitecore;
using Sitecore.Collections;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;

namespace Autohaus.Data
{
    public static class NavigationService
    {
        static readonly Guid _rootId = new Guid("{D70CBEED-6DCF-483F-978F-6FC3C8049512}");

        public static IEnumerable<NavigationItem> GetNavigationItems()
        {
            var service = new SitecoreService(Context.ContentDatabase ?? Context.Database);

            var root = service.GetItem<NavigationItem>(_rootId);

            

            var navItems = new List<NavigationItem>();
            
            if(root.Show)
                navItems.Add(root);

            navItems.AddRange(root.SubItems);

            //we have to reset the subitems on root to stop the 
            //rendering thinking that it should be active with child items
            root.SubItems = new NavigationItem[]{};

            return navItems;
        }
    }
}