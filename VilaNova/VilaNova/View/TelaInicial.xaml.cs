using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VilaNova.Banco;
using VilaNova.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite.Extensions;
using SQLite;
using SQLitePCL;
using System.ComponentModel;

namespace VilaNova.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TelaInicial : INotifyPropertyChanged
	{
        List<ServiceOS> Lista { get; set; }
		public TelaInicial ()
		{
			InitializeComponent ();

            Database database = new Database();
           Lista = database.Consultar();
           ListaClientes.ItemsSource = Lista;
           

           lblCount.Text = Lista.Count.ToString();
		}



        //public void AdicionarAction (object sender, EventArgs args)
        //{
        //    //FUNCIONANDO
        //    Label lblAdicionar = (Label)sender;
        //    TapGestureRecognizer tapGest = (TapGestureRecognizer)lblAdicionar.GestureRecognizers[0];
        //    ServiceOS serviceOS = tapGest.CommandParameter as ServiceOS;

        //    App.Current.MainPage = new NavigationPage(new AddOS(serviceOS));
        //}

        public void DetalheAction(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            ServiceOS serviceOS = tapGest.CommandParameter as ServiceOS;

            //  App.Current.MainPage = new NavigationPage(new DetalheOS(serviceOS));
            Navigation.PushAsync(new DetalheOS(serviceOS));
        }

        public void pageADD(object sender, EventArgs args)
        {
            // App.Current.MainPage = new NavigationPage(new AddOS());
            Navigation.PushAsync(new AddOS());
        }

        public void PesquisarAction(object sender, TextChangedEventArgs args)
        {
            ListaClientes.ItemsSource = Lista.Where(a => a.NomeCliente.Contains(args.NewTextValue)).ToList();
        }

    }
}