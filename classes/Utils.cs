namespace uc12.classes
{
    public static class Utils
    {
        public static void Loading(string texto, int qtdPontos, int tempo, ConsoleColor corFonte = ConsoleColor.White, ConsoleColor corFundo = ConsoleColor.Black)
        {
            //loading
            Console.BackgroundColor = corFundo;//cor de fundo
            Console.ForegroundColor = corFonte;//cor da fonte

            Console.Write(texto);

            for (int i = 1; i <= qtdPontos; i++)
            {

                Thread.Sleep(500);//1000 ms = 1 segundo
                Console.Write($". ");

            }

            Console.ResetColor();// reseta a cor
            Console.WriteLine();

        }

        public static void ParadaNoConsole(string texto, ConsoleColor corFonte = ConsoleColor.White)
        {
            Console.ForegroundColor = corFonte;
            Console.WriteLine(texto);
            Console.WriteLine($"Tecle <ENTER> para continuar");
            Console.ResetColor();
            Console.ReadLine(); //parada no sistema
        }


        //caminho  = "Database/PessoaJuridica.csv";

        public static void VerificarPastaArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];
            //se a pasta não existe
            if (!Directory.Exists(pasta))
            {
                //criar pasta
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                using(File.Create(caminho)){}
            }
        }

    }



}