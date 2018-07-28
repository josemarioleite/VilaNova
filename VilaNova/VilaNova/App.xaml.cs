using System;
using System.Threading.Tasks;
using VilaNova.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace VilaNova
{
	public partial class App : Application
	{       

		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new TelaInicial());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
