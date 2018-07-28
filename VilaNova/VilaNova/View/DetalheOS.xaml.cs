using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	public partial class DetalheOS : INotifyPropertyChanged
    {
        List<ServiceOS> Lista { get; set; }
		public DetalheOS (ServiceOS serviceOS)
		{
			InitializeComponent ();

            BindingContext = serviceOS;
		}

        public void ExcluirAction(object sender, EventArgs args)
        {
            ServiceOS serviceOS = new ServiceOS();
            Database database = new Database();

            // App.Current.MainPage = new NavigationPage(new ExcluirOS());
            Navigation.PushAsync(new ExcluirOS());
        }
	}
}