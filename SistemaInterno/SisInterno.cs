using bytebank.Funcionarios;
using bytebank.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.SistemaInterno
{
    public class SisInterno
    {
        public bool Logar(FuncionarioAutenticavel funcionario, string senha, string login) 
        {
            if (funcionario.Autenticar(senha, login))
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha e/ou Login incorreto!");
                return false;
            }
        }

        public bool Logar(ParceiroComercial parceiro, string senha, string login)
        {
            if (parceiro.Autenticar(senha, login))
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha e/ou Login incorreto!");
                return false;
            }
        }

    }
}
