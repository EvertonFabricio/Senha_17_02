using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senha
{
    internal class Fila
    {
        public Senha Head { get; set; }
        public Senha Tail { get; set; }
        public Fila()
        {
            Head = null;
            Tail = null;
        }


        public bool empty()
        {
            if (Head == null)
                return true;
            else
                return false;
        }
        public void push(Senha aux)
        {
            if (Head == null && Tail == null)
            {
                Head = aux;
                Tail = aux;
                cont++;
                Console.WriteLine($"\tSua senha é {Tail.Num}.\nPor favor, aguarde ser chamado(a)\n_________________________________\n");
            }
            else
            {
                Tail.Next = aux;
                Tail = aux;
                aux = null;
                cont++;
                Console.WriteLine($"\tSua senha é {Tail.Num}.\nPor favor, aguarde ser chamado(a)\n_________________________________\n");
            }
        }
        public void pop()
        {
            if (empty())
                Console.WriteLine("Não existem senhas para serem chamadas.\n");
            else
            {
                Console.WriteLine($"Próxima senha, número {Head.Num}\n");
                Head = Head.Next;
                cont--;
            }

            if (Head == null)
                Tail = null;
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        int cont;
        public void print()
        {
            if (empty())
            {
                Console.WriteLine("Não existem senhas para serem chamadas!\nPressione ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Senha aux = Head;
                Console.WriteLine($"Faltam {cont} senha(s) para serem chamadas:\n");
                do
                {
                    Console.WriteLine(aux.Num);
                    aux = aux.Next;
                } while (aux != null);
                    Console.WriteLine("Pressione uma ENTER para continuar...");
                    Console.ReadKey(); 
            }
        }
    }
}

