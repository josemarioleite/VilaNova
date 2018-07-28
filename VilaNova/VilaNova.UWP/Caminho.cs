using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VilaNova.Banco;
using VilaNova.UWP;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(Caminho))]
namespace VilaNova.UWP
{
    public class Caminho : ICaminho
    {
        public string CaminhoBanco(string NomeArquivoBanco)
        {
            string caminhoDaPasta = ApplicationData.Current.LocalFolder.Path;

            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}
