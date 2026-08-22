using System;

namespace src
{
    public class TextEditorMenu
    {
        public static void Iniciar()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t****Bem-vindo ao Editor de Texto****");
            Console.WriteLine("1- Abrir arquivo");
            Console.WriteLine("2- Criar arquivo");
            Console.WriteLine("0- Sair");
            Console.Write("Opção: ");

           int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: TextEditorOperacoes.Abrir(); break;
                case 2: TextEditorOperacoes.Criar(); break;
                default: Iniciar(); break;
            }
        }
    }
}
