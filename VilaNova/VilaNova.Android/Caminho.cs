using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using VilaNova.Banco;
using Xamarin.Forms;
using VilaNova.Droid;

[assembly:Dependency(typeof(VilaNova.Droid.Caminho))]
namespace VilaNova.Droid
{
    public class Caminho : ICaminho
    {

        public string CaminhoBanco(string NomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);

            return caminhoBanco;
        }

    }
}