using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFirstLista
{
    internal class ListaAluno
    {
        public Aluno HEAD { get; set; }
        public Aluno TAIL { get; set; }

        public ListaAluno()
        {
            HEAD = TAIL = null;
        }

        public bool Vazia()
        {
            if ((HEAD == null) && (TAIL == null))
                return true;
            else
                return false;
        }

        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("impossivel imprimir, Lista Vazia!");
            }
            else
            {
                Aluno auxiliar = HEAD;

                Console.WriteLine("DADOS DA LISTA DE ALUNOS");
                do
                {
                    Console.WriteLine("\n" + auxiliar.ToString() + "\n");
                    auxiliar = auxiliar.Proximo;
                } while (auxiliar != null);
                Console.WriteLine("FIM DA IMPRESSÃO.\n");
            }
            Console.ReadKey();
        }

        public void Push(Aluno auxiliar)
        {
            if (Vazia())                                     //inserção lista vazia
            {
                HEAD = TAIL = auxiliar;
            }
                                                             //inserção apos a tail (novo ultimo elemento)
            else                                             //lembrando que a inserção deve seguir uma ordenação
            {
                if (auxiliar.Nome.CompareTo(TAIL.Nome) >= 0) //neste exemplo faremos a ordem alfabetica por nome do aluno
                {
                    TAIL.Proximo = auxiliar;                 //inserido novo objeto como ultimo - encadeamento
                    TAIL = auxiliar;                         //ajustando a tail para o novo ultimo elemento
                }
                                                             //inserção antes do head (novo primeiro elemento)
                else
                {
                    if (auxiliar.Nome.CompareTo(HEAD.Nome) < 0)
                    {
                        auxiliar.Proximo = HEAD;             //faco o encadeamento do novo primeiro elemento na lista
                        HEAD = auxiliar;                     //ajustando a head para o novo primeiro elemento da lista
                    }

                    else                                     //incersao no meio da lista
                    {
                        Aluno aux1, aux2;
                        aux1 = HEAD;
                        aux2 = HEAD;

                        do
                        {
                            if (auxiliar.Nome.CompareTo(aux1.Nome) >= 0)
                            {                                //procurando a posição para inserir o novo objeto
                                aux2 = aux1;                 //controlar o anterior
                                aux1 = aux1.Proximo;         //controlar o proximo
                            }
                            else                             //posso inserir o novo objeto na lista
                            {
                                aux2.Proximo = auxiliar;     //encadeamento do objeto anterior
                                auxiliar.Proximo = aux1;     //encadeamento do objeto proximo
                                break;
                            }
                        } while (true);
                    }
                }
            }
        }

        public void Pop(string nomeRemovido)
        {
            if (Vazia())
                Console.WriteLine("Lista Vazia! Impossivel remover.");

            else
            {
                if (HEAD.Nome == nomeRemovido)
                {
                    HEAD = HEAD.Proximo;
                    Console.WriteLine("Aluno: " + nomeRemovido + " removido!");
                }
                else
                {
                    Aluno aux1, aux2;
                    aux1 = HEAD;
                    aux2 = HEAD;
                    do
                    {
                        if (aux1.Nome != nomeRemovido)
                        {
                            aux2 = aux1;
                            aux1 = aux1.Proximo;

                            if(aux1 == null)
                            {
                                Console.WriteLine("nome nao encontrado.");
                                break;
                            }
                        }
                        else
                        {
                            if(aux1 == TAIL)
                            {
                                TAIL = aux2;
                                Console.WriteLine("Aluno: " + nomeRemovido + " removido!");
                                break;
                            }
                            else
                            {
                                aux2.Proximo = aux1.Proximo;
                                Console.WriteLine("Aluno: " + nomeRemovido + " removido!");
                                break;
                            }
                        }
                    } while (true);
                }
            }
            Console.WriteLine("\nAperte qualquer coisa para seguir.");
            Console.ReadKey();
        }

        public void Length()
        {
            int contador = 0;
            if (Vazia())
                Console.WriteLine("Lista Vazia!");
            else
            {
                Aluno auxiliar = HEAD;
                do
                {
                    contador++;
                    auxiliar = auxiliar.Proximo;

                } while (auxiliar != null);
                Console.WriteLine("A Lista tem " + contador + " aluno(s).");
            }
            Console.ReadKey();
        }

        public void Find(string nome)
        {
            if (Vazia())
                Console.WriteLine("Lista Vazia!");
            else
            {
                Aluno auxiliar = HEAD;
                bool achou = false;
                do
                {
                    if (auxiliar.Nome == nome)
                    {
                        Console.WriteLine("Aluno localizado!\n");
                        Console.WriteLine(auxiliar.ToString());
                        Console.WriteLine("\n");
                        achou = true;
                    }
                    auxiliar = auxiliar.Proximo;
                } while (auxiliar != null);
                if (!achou)
                    Console.WriteLine("Aluno nao localizado com esse nome: " + nome + "\n");
                else
                    Console.WriteLine("\nFim da busca.");

                Console.WriteLine("\nAperte qualquer coisa para seguir.");
                Console.ReadKey();
            }
        }
    }
}
