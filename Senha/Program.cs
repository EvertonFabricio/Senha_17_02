using System;
using System.Threading;
namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            Random random = new Random();




            int senha;
            
            do
            {
                Console.WriteLine("**Sistema de senhas automaticas**\n\tEscolha uma opção\n");
                Console.WriteLine("1 - Gerar uma nova senha\n2 - Chamar a proxima senha\n3 - Ver senhas à serem chamadas\n0 - Sair do sistema de senhas");
                string menu = Console.ReadLine();

                Console.Clear();

                switch (menu)
                {
                    case "1":
                        senha = random.Next(111, 999);
                        fila.push(new Senha(senha));
                        Thread.Sleep(2500);
                        break;

                    case "2":
                        fila.pop();
                        break;

                    case "3":
                        fila.print();
                        break;

                    case "0":
                        Console.WriteLine("Obrigado por utilizar nossos serviços");
                        break;
                        
                    default:
                        Console.WriteLine("Opção inválida. Pressione ENTER para voltar ao menu...");
                        Console.Clear();
                        break;
                }
                        if (menu == "0")
                            break;
            }while(true);
            




        }
    }
}
