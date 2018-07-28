using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VilaNova.Banco;
using VilaNova.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VilaNova.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExcluirOS : ContentPage
	{
        List<ServiceOS> Lista { get; set; }
		public ExcluirOS ()
		{
			InitializeComponent ();

            TelaInicial();
		}

        private void TelaInicial()
        {
            Database database = new Database();
            Lista = database.Consultar();
            ListaClientes.ItemsSource = Lista;

            lblCount.Text = Lista.Count.ToString();

        }

        public void ExcluirAction(object sender, EventArgs args)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            ServiceOS serv = tapGest.CommandParameter as ServiceOS;           

            if (true)
            {
                Database database = new Database();
                database.Exclusao(serv);

                App.Current.MainPage = new NavigationPage(new TelaInicial());
            }

            InitializeComponent();
            App.Current.MainPage.DisplayAlert("Atenção", "Dados Excluídos com sucesso", "Ok");


        }
    }
}