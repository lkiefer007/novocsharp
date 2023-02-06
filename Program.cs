using uc12.classes;
using System.Text.RegularExpressions;



// cadastro da pessoa fisica
//Endereço pessoa fisica

// Endereco endPf1 = new Endereco();
// endPf1.Logradouro = "Rua Prest";
// endPf1.Numero = 16;
// endPf1.Comercial = false;

// //pessoa fisica 1
// PessoaFisica Pf1 = new PessoaFisica();
// Pf1.Nome = "Leandro";
// Pf1.DataNascimento = new DateTime(1989,06,27);
// Pf1.Cpf = "125.959.497-13";
// Pf1.Rendimento = 3629;
// Pf1.Endereco = endPf1;


// //pessoa fisica 2
// PessoaFisica thePeople = new PessoaFisica("20915749788");
// thePeople.Nome = "Jo";
// //thePeople.Cpf = "125.959.497-13";
// thePeople.Rendimento = 3629;
// thePeople.Endereco = endPf1;









// //exibição dos dados
// Console.WriteLine($"PESSOA FISICA 1");

// Console.WriteLine($"Nome:{Pf1.Nome}");
// Console.WriteLine($"CPF:{Pf1.Cpf}");
// Console.WriteLine($"Rendimento:{Pf1.Rendimento}");
// Console.WriteLine($"Data Nascimento:{Pf1.DataNascimento}");
// Console.WriteLine($"Maior de Idade?:{Pf1.ValidarDataNascimento(Pf1.DataNascimento)}");
// Console.WriteLine($"Rua:{Pf1.Endereco.Logradouro}");
// Console.WriteLine($"N:{Pf1.Endereco.Numero}");
// Console.WriteLine($"Endereço Comercial?:{Pf1.Endereco.Comercial}");

// Console.WriteLine();


// Console.WriteLine($"PESSOA FISICA 2");

// Console.WriteLine($"Nome:{thePeople.Nome}");
// Console.WriteLine($"CPF:{thePeople.Cpf}");
// Console.WriteLine($"Rendimento:{thePeople.Rendimento}");
// Console.WriteLine($"Data Nascimento:{thePeople.DataNascimento}");
// Console.WriteLine($"Maior de Idade?:{thePeople.ValidarDataNascimento(thePeople.DataNascimento)}");
// Console.WriteLine($"Rua:{thePeople.Endereco.Logradouro}");
// Console.WriteLine($"N:{thePeople.Endereco.Numero}");
// Console.WriteLine($"Endereço Comercial?:{thePeople.Endereco.Comercial}");





//*****************cadastro de pessoa Jurídica***************************

Endereco endPj = new Endereco();
endPj.Logradouro = "Rua Niteroi";
endPj.Numero = 180;
endPj.Comercial = true;

PessoaJuridica novaPj = new PessoaJuridica();

novaPj.Nome = "Paulo";
novaPj.Endereco = endPj;
novaPj.Rendimento = 100000;
//novaPj.Cnpj = "62.236.353/0001-42";
novaPj.Cnpj = "62236353000142";
novaPj.Fantasia = "SENAI";
novaPj.RazaoSocial = "Serviço Nacional de Aprendizagem Industrial";

// Console.WriteLine($"Qual é o Rendimento?");
// Console.WriteLine($"Text");
//Console.WriteLine($"Nome Fantasia?");
//novaPj.Fantasia = Console.writeLine($"Nome Fantasia?")

//Exibição dos Dados
Console.WriteLine(@$"
Razão Social: {novaPj.RazaoSocial}
Nome Fantasia: {novaPj.Fantasia}
Representate: {novaPj.Nome}
CNPJ:{novaPj.Cnpj}
CNPJ Válido: {novaPj.ValidadeCnpj(novaPj.Cnpj)}
Rendimento Anual: {novaPj.Rendimento}
Endereço: {novaPj.Endereco.Logradouro},{novaPj.Endereco.Numero}
Endereço Comercial? {novaPj.Endereco.Comercial}
");




// DateTime data = new DateTime(1989,06,27);
// Console.WriteLine( thePeople.ValidarDataNascimento(data));

//Substring
// string nome = "Leandro Kiefer";
// Console.WriteLine(nome.Substring(3));
// Console.WriteLine(nome.Substring(8));


// Console.WriteLine(nome.Substring(0, 7));
// Console.WriteLine(nome.Length);
// Console.WriteLine (nome.Substring(4, nome.Length - 4));








