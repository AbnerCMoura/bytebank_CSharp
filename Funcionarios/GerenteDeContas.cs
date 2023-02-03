using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{   
    class GerenteDeContas: FuncionarioAutenticavel
    {

        public override double getBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSarlario()
        {
            this.Salario *= 1.05;
        }

        public new bool Autenticar(string senha, string login)
        {
            return this.Senha == senha && this.Login == login;
        }

        public GerenteDeContas(string cpf) :base(cpf, 4000)
        {
        }
    }
}
