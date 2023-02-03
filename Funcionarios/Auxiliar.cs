using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    class Auxiliar:Funcionario
    {
        public override double getBonificacao()
        {
            return this.Salario * 0.2;
        }
        public override void AumentarSarlario()
        {
            this.Salario *= 1.1;
        }



        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }
    }
}
