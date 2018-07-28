using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VilaNova.Model;
using Xamarin.Forms;

namespace VilaNova.Banco
{
    public class Database
    {
        private SQLiteConnection _conexao;

        public Database()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.CaminhoBanco("database.sqlite");

            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable<ServiceOS>();
        }

        public List<ServiceOS> Consultar()
        {
            return _conexao.Table<ServiceOS>().ToList();
        }
        public List<ServiceOS> Pesquisar(string palavra)
        {
            return _conexao.Table<ServiceOS>().Where(a => a.NomeCliente.Contains(palavra)).ToList();
        }
        public ServiceOS ObterVagaPorId(int id)
        {
            return _conexao.Table<ServiceOS>().Where(a => a.Id == id).FirstOrDefault();
        }
        public void Cadastro(ServiceOS servOS)
        {
            _conexao.Insert(servOS);
        }
        public void Atualizacao(ServiceOS servOS)
        {
            _conexao.Update(servOS);
        }
        public void Exclusao(ServiceOS servOS)
        {
            _conexao.Delete(servOS);
        }
    }
}
