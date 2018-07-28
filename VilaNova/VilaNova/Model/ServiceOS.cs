using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using VilaNova.Banco;
using Xamarin.Forms;

namespace VilaNova.Model
{
    [Table("ServiceOS")]
    public class ServiceOS
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public double Valor { get; set; }
        public string Descricao { get; set; }
        public string Instrumento { get; set; }
        public string Observacao { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataEntrega { get; set; }
        public string EmailCliente { get; set; }
        public double NumeroCliente { get; set; }
        public double CPFcliente { get; set; }
        public string EntregueCli { get; set; }
        public string CidadeCliente { get; set; }
    }
}
