using uc12.classes;
using System.Text.RegularExpressions;

PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();


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
            Console.Clear();
            Console.WriteLine($"***********CADASTRO DE PESSOA FISICA**********");
            Console.WriteLine("");//PULA UMA LINHA

            //*********Endereço pessoa fisica************

            Endereco endPf1 = new Endereco();
            endPf1.Logradouro = "Rua Prest";
            endPf1.Numero = 16;
            endPf1.Comercial = false;

            //pessoa fisica 1
            PessoaFisica Pf1 = new PessoaFisica();
            Pf1.Nome = "Leandro";
            Pf1.DataNascimento = new DateTime(1989, 06, 27);
            Pf1.Cpf = "125.959.497-13";
            Pf1.Rendimento = 3659;
            Pf1.Endereco = endPf1;


            //exibição dos dados
            Console.WriteLine($"PESSOA FISICA 1");

            Console.WriteLine($"Nome:{Pf1.Nome}");
            Console.WriteLine($"CPF:{Pf1.Cpf}");
            Console.WriteLine($"Rendimento:{Pf1.Rendimento}");
            Console.WriteLine($"Rendimento Liquido:{metodosPf.PagarImposto(Pf1.Rendimento)}");
            Console.WriteLine($"Data Nascimento:{Pf1.DataNascimento}");
            Console.WriteLine($"Maior de Idade?:{Pf1.ValidarDataNascimento(Pf1.DataNascimento)}");
            Console.WriteLine($"Rua:{Pf1.Endereco.Logradouro}");
            Console.WriteLine($"N:{Pf1.Endereco.Numero}");
            Console.WriteLine($"Endereço Comercial?:{Pf1.Endereco.Comercial}");
            Console.WriteLine($"Pessoa Física");


            Utils.ParadaNoConsole("Pessoa Física cadastrada com sucesso!");
            Console.ReadKey(); //parada no sistema

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
            Console.WriteLine(@$"
Razão Social: {novaPj.RazaoSocial}
Nome Fantasia: {novaPj.Fantasia}
Representate: {novaPj.Nome}
CNPJ:{novaPj.Cnpj}
CNPJ Válido: {metodosPj.ValidadeCnpj(novaPj.Cnpj)}
Rendimento Anual: {novaPj.Rendimento}
Rendimento Liquido: {metodosPj.PagarImposto(novaPj.Rendimento)}
Endereço: {novaPj.Endereco.Logradouro},{novaPj.Endereco.Numero}
Endereço Comercial? {novaPj.Endereco.Comercial}
");



            Utils.ParadaNoConsole("Pessoa Jurídica cadastrada com sucesso!");
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

