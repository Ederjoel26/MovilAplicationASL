using AsLogic.Models;
using FireSharp.Response;
using Newtonsoft.Json;
using System.Text;
using FireSharp.Config;
using FireSharp.Interfaces;
using AsLogic.ViewModels;

namespace AsLogic.Views;

public partial class Site2 : ContentPage
{
    Site2ViewModel viewModel = new Site2ViewModel();
    public Site2(Site2ViewModel vm)
    {
        InitializeComponent();
        viewModel = vm;
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.AsignarValoresRack1();
        viewModel.AsignarValoresRack2();
        viewModel.AsignarValoresRack3();
        viewModel.AsignarValoresRack4();
    }
}