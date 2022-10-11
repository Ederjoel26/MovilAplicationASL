using AsLogic.Models;
using Newtonsoft.Json;
using System.Text;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Collections.Concurrent;
using Microsoft.SharePoint.News.DataModel;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using AsLogic.ViewModels;

namespace AsLogic.Views;

public partial class Site1 : ContentPage
{
    Site1ViewModel viewModel = new Site1ViewModel();
    public Site1(Site1ViewModel vm)
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