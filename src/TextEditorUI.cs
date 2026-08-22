using System;
using src.texteditoroperations;

namespace src.texteditormenu
{
    public static class TextEditorUI
    {
        static void Menu()
        {
            Console.WriteLine("****Bem-vindo ao Editor de Texto****");
            Console.WriteLine("1- Abrir arquivo");
            Console.WriteLine("2- Criar arquivo");
            Console.WriteLine("0- Sair");

           int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Criar(); break;
                default: Console.WriteLine("Escolha uma das opções válidas!"); 
                Menu();
                    break;
            }
        }
    }
}
