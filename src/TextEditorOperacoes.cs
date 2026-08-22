using System;
using src.TextEditorMenu;



namespace src.TextEditorOperacoes
{
    public static class TextEditorOperacoes
    {
        //--Content: Método para abrir arquivo--
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Caminho do arquivo para abrir: ");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine($"{texto}");
            }
        }


        //--Content: Método para criar arquivo--
        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite o texto: "
                + "(clique na tecla ESC para fechar)");
            string texto = "";
            do
            {
                texto += Console.ReadLine();
                texto = Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape); ;

            Salvar(texto);
        }

        //--Content: Método para salvar arquivo--
        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Salvar arquivo em: ");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminho))
            {
                arquivo.Write(texto);
            }

            Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
        }
    }
}
   

