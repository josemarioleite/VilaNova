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
	public partial class AddOS : ContentPage
	{
		public AddOS ()
		{
			InitializeComponent ();

            BindingContext = new ServiceOS();
            
		}

        public void SalvarAction(object sender, EventArgs args)
        {
                       
            ServiceOS serviceOS = new ServiceOS();                

            serviceOS.NomeCliente = nomeCliente.Text;
            serviceOS.EmailCliente = emailCliente.Text;

            if (cpfCliente != null)
            {
                serviceOS.CPFcliente = double.Parse(cpfCliente.Text);
            }


            if (numeroCliente != null)
            {
                serviceOS.NumeroCliente = double.Parse(numeroCliente.Text);
            }

            //serviceOS.CPFcliente = double.Parse(cpfCliente.Text);
            //serviceOS.NumeroCliente = double.Parse(numeroCliente.Text);
            serviceOS.Instrumento = instruCliente.Text;
            serviceOS.Descricao = descInstru.Text;
            serviceOS.Observacao = obsInstru.Text;
            serviceOS.DataEntrega = dateEntrega.Date;
            //serviceOS.DataEntrega = DateTimeOffset.Parse(dateEntrega.Text);
            serviceOS.Valor = double.Parse(valorServ.Text);

            // nomeCliente.Text = serviceOS.NomeCliente;
            // emailCliente.Text = serviceOS.EmailCliente;
            // cpfCliente.Text = serviceOS.CPFcliente.ToString();
            // numeroCliente.Text = serviceOS.NumeroCliente.ToString();
            // instruCliente.Text = serviceOS.Instrumento;
            // descInstru.Text = serviceOS.Descricao;
            // obsInstru.Text = serviceOS.Observacao;
            // dateEntrega.Text = serviceOS.DataEntrega;
            // valorServ.Text = serviceOS.Valor.ToString();
            //servEntregue.IsToggled ? "NÃO" : "SIM" = serviceOS.EntregueCli;



            Database database = new Database();
            database.Cadastro(serviceOS);

            App.Current.MainPage.DisplayAlert("Atenção", "Dados salvo com Sucesso!", "Ok");            
            App.Current.MainPage = new NavigationPage(new TelaInicial());
        }
    }
}