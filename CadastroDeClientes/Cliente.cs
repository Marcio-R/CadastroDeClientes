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
        public int Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal RendaMensal { get; set; }
        public EnumEstadoCivil EstadoCivil { get; set; }
        public bool TemFilhos { get; set; }
        public string Nacionalidade { get; set; }
        public string PlacaVeiculo { get; set; }
        public static List<Cliente> ListClientes { get; set; }

        public Cliente(string nome, int cpf, DateTime dataNascimento, decimal rendaMensal, EnumEstadoCivil estadoCivil, bool temFilhos, string nacionalidade, string placaVeiculo)
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

        public Cliente(int codigo)
        {
            Codigo = codigo;
        }

        public static Cliente Insert(Cliente cliente)
        {
            int codigo = ListClientes.Count > 0 ? ListClientes.Max(c => c.Codigo) + 1 : 1;
            cliente.Codigo = codigo;
            ListClientes.Add(cliente);
            return cliente;
        }

    }

}
