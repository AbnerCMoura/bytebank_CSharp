using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    class Designer:Funcionario
    {

        public override double getBonificacao()
        {
            return this.Salario * 0.17;
        }

        public override void AumentarSarlario()
        {
            this.Salario *= 1.11;
        }



        public Designer(string cpf):base(cpf, 3000)
        {
        }
    }
}
