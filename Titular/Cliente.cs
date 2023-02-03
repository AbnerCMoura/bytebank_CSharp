using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class DadosCliente
    {
        public static int TotalClientes { private set; get; }
        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public DadosCliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
            TotalClientes++;
        }
    }
}
