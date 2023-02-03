using bytebank.SistemaInterno;
using bytebank.Funcionarios;
using bytebank.Conta;
using bytebank.Titular;
using System;
using bytebank.Util;
using bytebank.Parceria;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //ContaCorrente contaDoAndre = new();
            //contaDoAndre.titular = "André Silva";
            //contaDoAndre.numero_agencia = 15;
            //contaDoAndre.conta = "1010-X";
            //contaDoAndre.setSaldo(100);

            //ContaCorrente contaDaMaria = new();
            //contaDaMaria.titular = "Maria Jureba";
            //contaDaMaria.numero_agencia = 43;
            //contaDaMaria.conta = "1010-3";
            //contaDaMaria.setSaldo(1000);

            //Console.WriteLine("Valor em conta: " + contaDoAndre.getSaldo());

            //*
            //contaDoAndre.Depositar(400);

            //Console.WriteLine("Valor em conta: " + contaDoAndre.getSaldo());

            // if (contaDoAndre.Sacar(300) == true)
            //{
            //    Console.WriteLine("Valor em conta: " + contaDoAndre.getSaldo());
            //}
            //else
            //{
            //    Console.WriteLine("Valor insuficiente");
            //}
            //*/
            //contaDaMaria.Tranferir(2000, contaDoAndre);

            //Console.WriteLine("Valor na conta da maria: " + contaDaMaria.getSaldo());
            //Console.WriteLine("Valor na conta do André: " + contaDoAndre.getSaldo());

            //DadosCliente cliente = new();
            //cliente.nome = "André Silva";
            //cliente.cpf = "000.000.000-00";
            //cliente.profissao = "Analista";

            //ContaCorrente conta = new();
            //conta.titular = cliente;
            //conta.Numero_agencia = 15;
            //conta.conta = "1010-X";
            //conta.setSaldo(100);

            ////Console.WriteLine("Nome do Titular: "+conta.titular.nome);
            ////Console.WriteLine("Profissão: "+conta.titular.profissao);
            ////Console.WriteLine("CPF: "+conta.titular.cpf);
            ////Console.WriteLine("Conta: "+conta.conta);
            ////Console.WriteLine("Agencia: "+conta.numero_agencia);
            ////Console.WriteLine("Saldo em conta: " + conta.getSaldo());

            //conta.Depositar(100);

            //Console.WriteLine("Saldo em conta André: " + conta.getSaldo());

            //DadosCliente cliente1 = new("Maria Silva", "111.111.111-11", "Babá");
            //ContaCorrente conta1 = new(17, "1017-10", 1000);
            //conta1.Titular = cliente1;
            //Console.WriteLine("Nome do titular: " + conta1.Titular.Nome);
            //Console.WriteLine("Saldo conta Maria: " + conta1.Saldo);
            //Console.WriteLine("Número da agência: " + conta1.Numero_agencia);
            //Console.WriteLine("Número da conta: " + conta1.Conta);

            //DadosCliente cliente2 = new("Abner Costa", "123.132.133-23", "Dev Júnior");
            //ContaCorrente conta2 = new(18, "1210-3", 1500);
            //conta2.Titular = cliente2;



            //Console.WriteLine("Nome do titular: " + conta2.Titular.Nome);
            //Console.WriteLine("Saldo conta Abner: " + conta2.Saldo);
            //Console.WriteLine("Número da agência: " + conta2.Numero_agencia);
            //Console.WriteLine("Número da conta: " + conta2.Conta);

            //conta2.Tranferir(500, conta1);

            //Console.WriteLine("saldo pós tranferencia conta2: " + conta2.Saldo);
            //Console.WriteLine("saldo pós tranferencia conta1: " + conta1.Saldo);

            //conta1.Depositar(500);
            //Console.WriteLine("Saldo pós deposito conta1: " + conta1.Saldo);
            #endregion

            CalcularTotalBonificacao();

            //usarSistema();

            void CalcularTotalBonificacao() { 
            GerenciadorDeBonificacao gerenciador = new();

            Diretor roberta = new("123456789");
            roberta.Nome = "Roberta";
            
            Console.WriteLine("Nome do diretor: " + roberta.Nome); // Mostra nome
            Console.WriteLine("Bonificação: " + roberta.getBonificacao().ToString("N2"));
            gerenciador.Registrar(roberta);

            roberta.AumentarSarlario();
            Console.WriteLine("Novo salário Roberta: " + roberta.Salario.ToString("N2"));


            Designer jhon = new("102.123.123-54");
            jhon.Nome = "Jhon Previtera";

            Console.WriteLine("Nome do designer: "+jhon.Nome); // Mostra nome
            Console.WriteLine("Salário: "+jhon.Salario.ToString("N2"));
            Console.WriteLine("Bonificação: " + jhon.getBonificacao().ToString("N2"));
            gerenciador.Registrar(jhon);

            jhon.AumentarSarlario();
            Console.WriteLine("Novo salário Jhon: " + jhon.Salario.ToString("N2"));

            GerenteDeContas carla = new("659.239.403-34");
            carla.Nome = "Ana Carla";
            Console.WriteLine("Nome do Gerente de Contas: " + carla.Nome); // Mostra nome
            Console.WriteLine("Salário: " + carla.Salario.ToString("N2"));
            Console.WriteLine("Bonificação: " + carla.getBonificacao().ToString("N2"));
            gerenciador.Registrar(carla);

            carla.AumentarSarlario();
            Console.WriteLine("Novo salário Jhon: " + carla.Salario.ToString("N2"));






            Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacao.ToString("N2"));
            Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionariosCad);
        }

            void usarSistema()
            {
                SisInterno sistema = new();

                Diretor abner = new("1231313");
                abner.Nome = "Abner";
                abner.Senha = "123";
                abner.Login = "AbnerCo";

                GerenteDeContas jhon = new("12388483");
                jhon.Nome = "jhonjhon";
                jhon.Senha = "321";
                jhon.Login = "JhonPri";

                
                sistema.Logar(abner, "123","AbnerCo");
                sistema.Logar(jhon, "321", "JhonPrev");

                ParceiroComercial marisa = new();
                marisa.Senha = "000";
                marisa.Login = "MarisaCorp";

                sistema.Logar(marisa, "000","MarisaCorp");
            }
        }
    }
}
