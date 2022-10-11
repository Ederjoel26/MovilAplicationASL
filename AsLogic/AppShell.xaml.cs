using AsLogic.Views;
using Microsoft.SharePoint.Client;

namespace AsLogic;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("PaginaPrincipal", typeof(AsLogic.Views.Principal));
        Routing.RegisterRoute("PaginaSite1", typeof(Site1));
        Routing.RegisterRoute("PaginaSite2", typeof(Site2));
        Routing.RegisterRoute("PaginaSite3", typeof(Site3));
    }
}