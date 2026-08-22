using System;

namespace src
{
    public  class TextEditorOperacoes
    {
        //--Content: Método para abrir arquivo--
       public  static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Caminho do arquivo para abrir: ");
            var caminho = Console.ReadLine();

            if(File.Exists(caminho) && !string.IsNullOrEmpty(caminho))
            using (var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine("-------------------------Conteúdo do arquivo-------------------------");
                Console.WriteLine(texto);
                Console.WriteLine("---------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("\nArquivo não encontrado!\nVerifique se o caminho está correto.");
            }

        }

        //--Content: Método para criar arquivo--
        public static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite o texto abaixo da linha: (ou aperte a tecla ESC para fechar)");
            Console.WriteLine("---------------------------------------------------------------------");
            string texto = "";
            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Salvar(texto);
        }

        //--Content: Método para salvar arquivo--
        public static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Salvar arquivo em: ");
            var caminho = Console.ReadLine();

            if (!string.IsNullOrEmpty(caminho))
            {
                using (var arquivo = new StreamWriter(caminho))
                {
                    arquivo.Write(texto);
                }

                Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
            }
            else
            {
                Console.WriteLine("O caminho não pode ser vazio!");
            }
        }
    }
}
   

