using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppGuiaCurso.Views;

namespace AppGuiaCurso
{

    [DesignTimeVisible(false)]

    public partial class MainPage : MasterDatailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(inicial)));
        }
    }

    private async void Open_Inical(object sender, EventArgs e)
    {
        try
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(inicial)));
            IsPresented = false;
        }
        catch (Expection ex)
        {
            await DisplayAlert("Ops!", ex.Message, "OK");
        }
    }

    private async void Open_Primeiro(object sender, EventArgs e)
    {
        try
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(inicial)));
            IsPresented = false;
        }
        catch (Expection ex)
        {
            await DisplayAlert("Ops!", ex.Message, "OK");
        }
    }

    private async void Open_Segundo(object sender, EventArgs e)
    {
        try
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(inicial)));
            IsPresented = false;
        }
        catch (Expection ex)
        {
            await DisplayAlert("Ops!", ex.Message, "OK");
        }
    }

    private async void Open_Terceiro(object sender, EventArgs e)
    {
        try
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(inicial)));
            IsPresented = false;
        }
        catch (Expection ex)
        {
            await DisplayAlert("Ops!", ex.Message, "OK");
        }
    }

    private async void Open_Vestibular(object sender, EventArgs e)
    {
        try
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(inicial)));
            IsPresented = false;
        }
        catch (Expection ex)
        {
            await DisplayAlert("Ops!", ex.Message, "OK");
        }
    }

    private async void Open_Contato(object sender, EventArgs e)
    {
        try
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(inicial)));
            IsPresented = false;
        }
        catch (Expection ex)
        {
            await DisplayAlert("Ops!", ex.Message, "OK");
        }
    }
}
