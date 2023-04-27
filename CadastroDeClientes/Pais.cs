using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes
{
    class Pais
    {
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public static List<Pais> GetPais { get; set; }

        public Pais(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;
        }

        static Pais()
        {
            GetPais = new List<Pais>();
            GetPais.Add(new Pais("BR", "Brasil"));
            GetPais.Add(new Pais("EUA", "Estados Unidos"));
            GetPais.Add(new Pais("AR", "Argentina"));
            GetPais.Add(new Pais("EC", "Equador"));
            GetPais.Add(new Pais("BO", "Bolivia"));
            GetPais.Add(new Pais("PY", "Paraguay"));
            GetPais.Add(new Pais("VE", "Venezuela"));
        }
    }
}
