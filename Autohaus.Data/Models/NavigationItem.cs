using System.Collections.Generic;
using System.Linq;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace Autohaus.Data.Models
{
    [SitecoreType]
    public class NavigationItem 
    {
        [SitecoreId]
        public virtual ID Id { get; set; }

        [SitecoreField("NavTitle")]
        public virtual string Title { get; private set; }

        [SitecoreField("Title")]
        public virtual string PageTitle { get; private set; }

        [SitecoreField("Text")]
        public virtual string PageText { get; private set; }

        [SitecoreField("ShowInNavBar")]
        public virtual bool Show { get; private set; }


        [SitecoreField("Navigatable")]
        public virtual bool Navigatable { get; private set; }

        [SitecoreIgnore]
        public bool IsActive
        {
            get
            {
                return Context.Item.ID.Equals(this.Id) || SubItems.Any(s => s.IsActive);
            }
        }

        [SitecoreQuery("./*[@ShowInNavBar='1']", IsRelative = true)]
        public virtual  IEnumerable<NavigationItem> SubItems { get; set; }

        [SitecoreIgnore]
        public string Url
        {
            get { return Navigatable ? ItemUrl : "#"; }
        }

        [SitecoreInfo(SitecoreInfoType.Url)]
        protected virtual string ItemUrl { get; set; }
    }
}