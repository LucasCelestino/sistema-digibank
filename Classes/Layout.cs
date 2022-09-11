using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace digibank.Classes
{
    public class Layout
    {
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

            Console.WriteLine(nome);
            Console.WriteLine(cpf);
            Console.WriteLine(senha);
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
        }

    }
}