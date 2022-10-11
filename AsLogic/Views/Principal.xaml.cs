using AsLogic.ViewModels;
using System.Diagnostics;

namespace AsLogic.Views;

public partial class Principal : ContentPage
{

    public Principal(PrincipalViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}