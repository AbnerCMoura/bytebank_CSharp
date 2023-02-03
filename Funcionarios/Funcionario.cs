using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public abstract class Funcionario: IBonificacao
    {
        
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalFuncionariosCad { get; private set; }


        public abstract void AumentarSarlario();

        public abstract double getBonificacao();

        public Funcionario(string cpf, double salario)
        {
            Salario = salario;
            Cpf = cpf;
            TotalFuncionariosCad++;
        }
    }
}
