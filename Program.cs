using uc12.classes;
using System.Text.RegularExpressions;

PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();
//listas de PF e PJ
List<PessoaFisica> listaPf = new List<PessoaFisica>(); //inicializa uma lista vazia Pessoa Fisica
List<PessoaJuridica> listaPj = new List<PessoaJuridica>(); //inicializa uma lista vazia Pessoa Juridica


//cabeçalho do sistema

Console.WriteLine(@$"

======================================
|   Bem vindo ao sistema de cadastro |
|   de Pessoa Fisica e Jurídica      |
======================================
");



Utils.Loading($"Iniciando ", 4, 500, ConsoleColor.DarkYellow, ConsoleColor.DarkGreen);

Console.ResetColor();
Console.WriteLine(); //pula uma linha

string? opcao; //null

do
{

    Console.WriteLine(@$"

======================================
|   Escolha uma das opções abaixo    | 
|------------------------------------|
|        1- Pessoa Física            |
|        2- Pessoa Jurídica          |
|                                    |
|        0- Sair                     |       
======================================
");

    opcao = Console.ReadLine(); //espera o usuário digitar a opção
    switch (opcao)
    {
        case "1": //*********pessoa fisica*********
            string opcaoPf;
            do
            {


                //desenhar sub-menu
                Console.WriteLine(@$"

=============================================
|   Escolha uma das opções abaixo           | 
|-------------------------------------------|
|        1- Cadastrar Pessoa Fisica         |
|        2- Listar Pessoa Física            |
|                                           |
|        0- Voltar ao menu anterior         |       
=============================================
");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        // Utils.ParadaNoConsole("Opção Cadastrar Pessoa Física");
                        // Console.Clear();
                        // Console.WriteLine($"***********CADASTRO DE PESSOA FISICA**********");
                        // Console.WriteLine("");//PULA UMA LINHA

                        // //*********Endereço pessoa fisica************

                        // Endereco enderecoPf = new Endereco();
                        // Console.WriteLine($"Digite o endereço:");
                        // enderecoPf.Logradouro = Console.ReadLine();
                        // Console.WriteLine($"Digite o Numero:");
                        // enderecoPf.Numero = int.Parse(Console.ReadLine());
                        // Console.WriteLine($"Endereço Comercial? S/N:");

                        // //string Comercial = Console.ReadLine();
                        // if (Console.ReadLine() == "S")
                        // {
                        //     enderecoPf.Comercial = true;
                        // }
                        // else
                        // {
                        //     enderecoPf.Comercial = false;
                        // }
                        // enderecoPf.Comercial = false;

                        // //pessoa fisica 1
                        PessoaFisica novaPf = new PessoaFisica();
                        Console.WriteLine($"Digite o Nome:");
                        novaPf.Nome = Console.ReadLine();
                        // novaPf.DataNascimento = new DateTime(1989, 06, 27);
                        // Console.WriteLine($"Digite o CPF:");
                        // novaPf.Cpf = Console.ReadLine();
                        // Console.WriteLine($"Informe o Rendimento bruto:");
                        // novaPf.Rendimento = float.Parse(Console.ReadLine());
                        // novaPf.Endereco = enderecoPf;

                        // //Cadastrando na Lista

                        // //listaPf.Add(novaPf); //guarda uma pessoa fisica na lista


                        //Escrevendo uma informação dentro do arquivo



                        // //Instanciar no objeto sw o conteudo da Classe StreamWriter
                        using (StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt"))
                        {
                            sw.WriteLine(novaPf.Nome);
                        }

                        Utils.ParadaNoConsole("Pessoa Física cadastrada com sucesso!");



                        break;
                    case "2":
                        Console.Clear();
                        // Console.WriteLine($"******* Listagem de Pessoas Fisica*********");


                        //  foreach (var pessoa in listaPf);
                        // {
                        //     Console.WriteLine();
                        //     Console.WriteLine($"Nome: {pessoa.Nome}");
                        //     Console.WriteLine($"CPF: {pessoa.Cpf}");
                        //     Console.WriteLine($"Rendimento: {pessoa.Rendimento}");
                        //     Console.WriteLine($"Rendimento Liquido: {metodosPf.PagarImposto(pessoa.Rendimento)}");
                        //     Console.WriteLine($"Data Nascimento: {pessoa.DataNascimento}");
                        //     Console.WriteLine($"Maior de Idade?: {pessoa.ValidarDataNascimento(pessoa.DataNascimento)}");
                        //     Console.WriteLine($"Rua: {pessoa.Endereco.Logradouro}");
                        //     Console.WriteLine($"N: {pessoa.Endereco.Numero}");
                        //     //Console.WriteLine($"Endereço Comercial?: {pessoa.Endereco.Comercial}");
                        //     //string endComercial = (pessoa.Endereco.Comercial) ? "Endereço Comercial: Sim" : "Endereço Comercial: Não";
                        //     Console.WriteLine((pessoa.Endereco.Comercial) ? "Endereço Comercial: Sim" : "Endereço Comercial Não");
                        //     Console.WriteLine();
                        // }

                        // Console.WriteLine();
                        // Utils.ParadaNoConsole("******* Listagem de Pessoas Fisica*********");

                        using (StreamReader sr = new StreamReader("Leandro Kiefer.txt"))
                        {
                            //criando variavel linha
                            string linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }

                            Console.WriteLine($"Tecle <ENTER> para continuar");
                            Console.ReadLine();
                        }



                        break;
                    case "0":
                        Console.Clear();
                        Utils.ParadaNoConsole("**********Voltando ao Menu Antenterior*********");

                        break;


                    default:
                        Console.Clear();
                        Utils.ParadaNoConsole("Opção Inválida!");
                        break;
                }

            } while (opcaoPf != "0");














            //exibição dos dados
            Console.WriteLine($"PESSOA FISICA 1");

            // 



            break;

        case "2"://******Pessoa Jurídica*******
            Console.Clear();
            Console.WriteLine($"************CADASTRO DE PESSOA JURIDICA****************");


            //Endereco

            Endereco endPj = new Endereco();
            endPj.Logradouro = "Rua Niteroi";
            endPj.Numero = 180;
            endPj.Comercial = true;


            PessoaJuridica novaPj = new PessoaJuridica();

            novaPj.Nome = "Paulo";
            novaPj.Endereco = endPj;
            novaPj.Rendimento = 100000;
            novaPj.Cnpj = "62.236.353/0001-42";
            //novaPj.Cnpj = "62236353000142";
            novaPj.Fantasia = "SENAI";
            novaPj.RazaoSocial = "Serviço Nacional de Aprendizagem Industrial";


            //Exibição dos Dados
            //             Console.WriteLine(@$"
            // Razão Social: {novaPj.RazaoSocial}
            // Nome Fantasia: {novaPj.Fantasia}
            // Representate: {novaPj.Nome}
            // CNPJ:{novaPj.Cnpj}
            // CNPJ Válido: {metodosPj.ValidadeCnpj(novaPj.Cnpj)}
            // Rendimento Anual: {novaPj.Rendimento}
            // Rendimento Liquido: {metodosPj.PagarImposto(novaPj.Rendimento)}
            // Endereço: {novaPj.Endereco.Logradouro},{novaPj.Endereco.Numero}
            // Endereço Comercial? {novaPj.Endereco.Comercial}
            // ");

            //inserindo dados em metodosPj
            metodosPj.Inserir(novaPj);

            List<PessoaJuridica> listaexibicaoPj = metodosPj.LerArquivos();
            //Console.Write(listaexibicaoPj);

            foreach (PessoaJuridica cadaItem in listaexibicaoPj)
            {
                Console.WriteLine(@$"
                            Razão Social: {cadaItem.RazaoSocial}
                          
                            Representate: {cadaItem.Nome}
                            CNPJ:{cadaItem.Cnpj}
                            
                
                            
                            Endereço: {novaPj.Endereco.Logradouro},{novaPj.Endereco.Numero}
                            Endereço Comercial? {novaPj.Endereco.Comercial}
                            ");

                Utils.ParadaNoConsole("Pessoa Jurídica cadastrada com sucesso!");

            }


            break;

        case "0":
            Console.Clear();
            Utils.ParadaNoConsole("Obrigado por utilizar nosso sistema!");
            break;
        default:
            Console.Clear();
            Utils.ParadaNoConsole("Opção Inválida", ConsoleColor.DarkRed);
            break;
    }
    //desenhar menu
    //escolher opção
    //faz algo, e só depois pergunta se é para continuar
} while (opcao != "0");



//loading
Utils.Loading("Finalizando ", 3, 300);




// Console.WriteLine();


// //*****************cadastro de pessoa Jurídica***************************

// Endereco endPj = new Endereco();
// endPj.Logradouro = "Rua Niteroi";
// endPj.Numero = 180;
// endPj.Comercial = true;





// DateTime data = new DateTime(1989,06,27);
// Console.WriteLine( thePeople.ValidarDataNascimento(data));

//Substring
// string nome = "Leandro Kiefer";
// Console.WriteLine(nome.Substring(3));
// Console.WriteLine(nome.Substring(8));


// Console.WriteLine(nome.Substring(0, 7));
// Console.WriteLine(nome.Length);
// Console.WriteLine (nome.Substring(4, nome.Length - 4));


// Console.WriteLine($"Qual é o Rendimento?");
// Console.WriteLine($"Text");
//Console.WriteLine($"Nome Fantasia?");
//novaPj.Fantasia = Console.writeLine($"Nome Fantasia?")



// Console.WriteLine($"PESSOA FISICA 2");

// Console.WriteLine($"Nome:{thePeople.Nome}");
// Console.WriteLine($"CPF:{thePeople.Cpf}");
// Console.WriteLine($"Rendimento:{thePeople.Rendimento}");
// Console.WriteLine($"Data Nascimento:{thePeople.DataNascimento}");
// Console.WriteLine($"Maior de Idade?:{thePeople.ValidarDataNascimento(thePeople.DataNascimento)}");
// Console.WriteLine($"Rua:{thePeople.Endereco.Logradouro}");
// Console.WriteLine($"N:{thePeople.Endereco.Numero}");
// Console.WriteLine($"Endereço Comercial?:{thePeople.Endereco.Comercial}");


//pessoa fisica 2
// PessoaFisica thePeople = new PessoaFisica("20915749788");
// thePeople.Nome = "Jo";
// //thePeople.Cpf = "125.959.497-13";
// thePeople.Rendimento = 3629;
// thePeople.Endereco = endPf1;

