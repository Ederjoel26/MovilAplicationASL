using Firebase.Database;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using AsLogic.Models;
using Microsoft.SharePoint.News.DataModel;
using AsLogic.ViewModels;

namespace AsLogic.Views;
public partial class Site3 : ContentPage
{
    Site3ViewModel viewModel = new Site3ViewModel();
    public Site3(Site3ViewModel vm)
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