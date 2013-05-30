using System.Collections.Generic;
using Autohaus.Data;
using Autohaus.Data.Models;
using Glass.Mapper.Sc.Razor.Web.Ui;

namespace Autohaus.Web.Layouts.Glass.Controls
{
	public class MainNav : AbstractRazorControl<IEnumerable<NavigationItem>>
	{             
		public override IEnumerable<NavigationItem> GetModel()
		{
		    return NavigationService.GetNavigationItems();
		}
	}
}
