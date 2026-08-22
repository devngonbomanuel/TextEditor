using System;



namespace src.texteditoroperations
{
    public static class TextEditorOperations
    {
        //--Content: Método para abrir arquivo--
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Caminho do arquivo para abrir: ");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamReader(caminho))
            {
                string texto = File.ReadToEnd();
            }
        }


        //--Content: Método para criar arquivo--
        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite o texto: "
                + "(clique em na tecla ESC para fechar)");
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
        }
    }
}
