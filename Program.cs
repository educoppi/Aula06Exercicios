using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = "";
            string senha = "";

            int opcao;

            string usuarioLogin;
            string senhaLogin;

            Console.WriteLine("Bem-vindo ao Dudu Bank");
            Console.WriteLine("Opções: ");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Login");

            Console.WriteLine("\n\nDigite uma das opções:");
            opcao = int.Parse(Console.ReadLine());

            if ((opcao == 1) || (opcao == 2))
            {
                if (opcao == 1)
                {
                    //CADASTRAR
                    Console.WriteLine("___CADASTRO___");

                    Console.Write("Digite o nome do novo usuário: ");
                    usuario = Console.ReadLine();

                    Console.Write("Digite a senha do novo usuário: ");
                    senha = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Usuário cadastrado com sucesso!");
                }

                //LOGIN

                Console.WriteLine("___LOGIN___");

                Console.Write("Digite o usuário: ");
                usuarioLogin = Console.ReadLine();

                Console.Write("Digite a senha: ");
                senhaLogin = Console.ReadLine();

                if ((usuarioLogin == usuario) && (senhaLogin == senha))
                {
                    Console.WriteLine("Você entrou na sua conta!");
                }
                else
                {
                    Console.WriteLine("\n\nUsuário ou senha invalido!\n\n");
                    Main(null);
                    return;
                }

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n\nOpcao invalida!\n\n");
                Main(null);
                return;
            }
        }

        void IntroducaoMainReturn()
        {

            int numero;

            Console.WriteLine("Digite um número de 1 a 10");
            numero = int.Parse(Console.ReadLine());

            if ((numero >= 1) && (numero <= 10))
            {
                Console.WriteLine(":)");
            }
            else
            {
                Console.WriteLine(":(");
                Console.WriteLine("Opa! Digite um número válido...\n\n");
                Main(null);
                return;
            }
            Console.WriteLine("- FIM DO PROGRAMA");
            Console.ReadKey();
        }
    }
}
