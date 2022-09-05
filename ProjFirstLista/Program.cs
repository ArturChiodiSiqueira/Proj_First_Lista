using System;
using System.Reflection.Metadata;

namespace ProjFirstLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaAluno MinhaLista = new ListaAluno();
            MinhaLista.Push(new Aluno(123, "Baratão", 34, "Turismo"));
            MinhaLista.Push(new Aluno(124, "Baratão", 44, "Engenharia Civil"));
            MinhaLista.Push(new Aluno(456, "Moranguinho", 27, "Agronomia"));
            MinhaLista.Push(new Aluno(345, "Celso Xaropinho", 33, "Telemarketing"));
            MinhaLista.Push(new Aluno(777, "Artur", 84, "Administração"));
            MinhaLista.Push(new Aluno(435, "Mussarela", 22, "Veterinária"));
            MinhaLista.Push(new Aluno(129, "Alexandre", 55, "Eletrica"));
            MinhaLista.Push(new Aluno(999, "Celso Xaropinho", 66, "Pos - Telemarketing"));

            MinhaLista.Print();

            MinhaLista.Length();

            Console.Clear();

            Console.Write("\nInforme o nome que deseja localizar: ");
            string nome = Console.ReadLine();
            MinhaLista.Find(nome);

            Console.Write("\nInforme o nome que deseja remover: ");
            string nomeremovido = Console.ReadLine();
            MinhaLista.Pop(nomeremovido);

            Console.Clear();

            MinhaLista.Print();

            MinhaLista.Length();
        }
    }
}
