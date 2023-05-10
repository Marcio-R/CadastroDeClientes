using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes
{
    enum EnumEstadoCivil
    {
        Solteiro,
        Casado,
        Divorciado,
        Viuvo
    }

    class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal RendaMensal { get; set; }
        public EnumEstadoCivil EstadoCivil { get; set; }
        public bool TemFilhos { get; set; }
        public string Nacionalidade { get; set; }
        public string PlacaVeiculo { get; set; }
        public static List<Cliente> ListClientes { get; set; }


        public Cliente(string nome, string cpf, DateTime dataNascimento, decimal rendaMensal, EnumEstadoCivil estadoCivil, bool temFilhos, string nacionalidade, string placaVeiculo)
        {
            Codigo = 0;
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            RendaMensal = rendaMensal;
            EstadoCivil = estadoCivil;
            TemFilhos = temFilhos;
            Nacionalidade = nacionalidade;
            PlacaVeiculo = placaVeiculo;
        }

        public Cliente()
        {
            this.Codigo = 0;
        }

        public static List<Cliente> Listagem { get; set; }

        static Cliente()
        {
            Listagem = new List<Cliente>();
        }

        public static Cliente Insert(Cliente cliente)
        {
            int codigo = Listagem.Count > 0 ? Listagem.Max(c => c.Codigo) + 1 : 1;
            cliente.Codigo = codigo;
            Listagem.Add(cliente);
            return cliente;
        }

    }

}
