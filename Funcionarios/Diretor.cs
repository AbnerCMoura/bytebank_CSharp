using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    {

        public override double getBonificacao()
        { 
            return this.Salario * 0.5;
        }

        public override void AumentarSarlario()
        {
            this.Salario *= 1.15; ; 
        }

        public new bool Autenticar(string senha, string login)
        {
            return this.Senha == senha && this.Login == login;
        }

        public Diretor(string cpf) : base(cpf, 5000)
        { 
        }
    }
}
