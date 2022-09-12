using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace digibank.Classes
{
    public class Layout
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
        private static int opcao = 0;
        public static void telaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("                                                        ");
            Console.WriteLine("                 Digite a opção desejada:               ");
            Console.WriteLine("                 ============================           ");
            Console.WriteLine("                 1 - Criar Conta                        ");
            Console.WriteLine("                 ============================           ");
            Console.WriteLine("                 2 - Entrar com CPF e Senha             ");
            Console.WriteLine("                 ============================           ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    telaCriarConta();
                    break;
                case 2:
                    telaLogin();
                    break;
                default:
                    Console.WriteLine("Opção não disponível");
                    break;
            }
            
        }

        private static void telaCriarConta()
        {
            Console.Clear();

            Console.WriteLine("                                                        ");
            Console.WriteLine("                 Digite o nome:                         ");
            string nome = Console.ReadLine();
            Console.WriteLine("                 Digite o CPF:                          ");
            string cpf = Console.ReadLine();
            Console.WriteLine("                 Digite a senha:                        ");
            string senha = Console.ReadLine();
            Console.WriteLine("                 ============================           ");

            ContaCorrente contaCorrente = new ContaCorrente();

            Pessoa pessoa = new Pessoa();

            pessoa.setNome(nome);
            pessoa.setCPF(cpf);
            pessoa.setSenha(senha);
            pessoa.conta = contaCorrente;

            pessoas.Add(pessoa);
            
            Console.Clear();

            Console.WriteLine("                 Conta cadastrada com sucesso!:                        ");
            Console.WriteLine("                 ==============================                        ");

            Thread.Sleep(1800);

            telaContaLogada(pessoa);
        }

        private static void telaLogin()
        {
            Console.Clear();

            Console.WriteLine("                                                        ");
            Console.WriteLine("                 Digite o seu CPF:                      ");
            string cpf = Console.ReadLine();
            Console.WriteLine("                 Digite a sua senha:                    ");
            string senha = Console.ReadLine();
            Console.WriteLine("                 ============================           ");

            Pessoa pessoa = pessoas.FirstOrDefault(p => p.cpf == cpf && p.senha == senha);

            if(pessoa != null)
            {
                telaContaLogada(pessoa);
            }
        }

        private static void telaBoasVindas(Pessoa pessoa)
        {
            string msgTelaBemVindo = $"{pessoa.nome} | Banco: {pessoa.conta.getCodigoBanco()} | Agencia: {pessoa.conta.getNumeroAgencia()} | Conta: {pessoa.conta.getNumeroConta()}";
            Console.WriteLine("                                                        ");
            Console.WriteLine($"Seja bem vindo, {msgTelaBemVindo}");
        }

        private static void telaContaLogada(Pessoa pessoa)
        {
            Layout.telaBoasVindas(pessoa);

            Console.WriteLine("                 Digite a opção desejada:                        ");
            Console.WriteLine("                 ===============================                 ");
            Console.WriteLine("                 1 - Realizar um Deposito                        ");
            Console.WriteLine("                 ===============================                 ");
            Console.WriteLine("                 2 - Realizar um Saque                           ");
            Console.WriteLine("                 ===============================                 ");
            Console.WriteLine("                 3 - Cosultar Saldo                              ");
            Console.WriteLine("                 ===============================                 ");
            Console.WriteLine("                 4 - Extrato                                     ");
            Console.WriteLine("                 ===============================                 ");
            Console.WriteLine("                 5 - Sair                                        ");
            Console.WriteLine("                 ===============================                 ");
            
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Layout.telaRealizarDeposito(pessoa);
                    break;
                case 2:
                    Layout.telaRealizarSaque(pessoa);
                    break;
                case 3:
                    Layout.telaMostrarSaldo(pessoa);
                    break;
                case 4:
                    Layout.telaMostrarExtrato(pessoa);
                    break;
                case 5:
                    Layout.telaPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção não disponível");
                    break;
            }
        }

        public static void telaMostrarSaldo(Pessoa pessoa)
        {
            Console.WriteLine("                                                                         ");
            Console.WriteLine($"                 Saldo atual:  R${pessoa.conta.consultaSaldo()}           ");
            Console.WriteLine("                 ==============================                          ");

            Layout.telaContaLogada(pessoa);
        }

        public static void telaRealizarDeposito(Pessoa pessoa)
        {
            Console.WriteLine("                                                                       ");
            Console.WriteLine("                Digite o valor que deseja depositar:                  ");
            double valor = double.Parse(Console.ReadLine());
            
            pessoa.conta.deposita(valor);

            Console.WriteLine("                                                                       ");
            Console.WriteLine($"                O valor de R${valor} foi depositado com sucesso!:     ");
            Console.WriteLine("                 ==============================                        ");

            Thread.Sleep(1800);

            Console.Clear();

            Layout.telaContaLogada(pessoa);
        }

        public static void telaRealizarSaque(Pessoa pessoa)
        {
            Console.WriteLine("                                                                       ");
            Console.WriteLine("                Digite o valor que deseja sacar:                  ");
            double valor = double.Parse(Console.ReadLine());

            if(!pessoa.conta.saca(valor))
            {
                Console.Write("O valor de saque é maior que o dinheiro em conta.");
                Layout.telaRealizarSaque(pessoa);
            }
            
            Console.WriteLine($"                O valor de R${valor} foi sacado com sucesso!:     ");
            Console.WriteLine("                 ==============================                        ");

            Thread.Sleep(1800);

            Console.Clear();

            Layout.telaContaLogada(pessoa);
        }

        public static void telaMostrarExtrato(Pessoa pessoa)
        {
            
        }
    }
}