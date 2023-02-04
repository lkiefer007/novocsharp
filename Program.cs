using uc12.classes;




// cadastro da pessoa fisica
//Endereço pessoa fisica

Endereco endPf1 = new Endereco();
endPf1.Logradouro = "Rua Prest";
endPf1.Numero = 16;
endPf1.Comercial = false;

//pessoa fisica 1
PessoaFisica Pf1 = new PessoaFisica();
Pf1.Nome = "Leandro";
Pf1.DataNascimento = new DateTime(1989,06,27);
Pf1.Cpf = "125.959.497-13";
Pf1.Rendimento = 3629;
Pf1.Endereco = endPf1;


//pessoa fisica 2
PessoaFisica thePeople = new PessoaFisica("20915749788");
thePeople.Nome = "Jo";
//thePeople.Cpf = "125.959.497-13";
thePeople.Rendimento = 3629;
thePeople.Endereco = endPf1;









//exibição dos dados
Console.WriteLine($"PESSOA FISICA 1");

Console.WriteLine($"Nome:{Pf1.Nome}");
Console.WriteLine($"CPF:{Pf1.Cpf}");
Console.WriteLine($"Rendimento:{Pf1.Rendimento}");
Console.WriteLine($"Data Nascimento:{Pf1.DataNascimento}");
Console.WriteLine($"Maior de Idade?:{Pf1.ValidarDataNascimento(Pf1.DataNascimento)}");
Console.WriteLine($"Rua:{Pf1.Endereco.Logradouro}");
Console.WriteLine($"N:{Pf1.Endereco.Numero}");
Console.WriteLine($"Endereço Comercial?:{Pf1.Endereco.Comercial}");

Console.WriteLine();


Console.WriteLine($"PESSOA FISICA 2");

Console.WriteLine($"Nome:{thePeople.Nome}");
Console.WriteLine($"CPF:{thePeople.Cpf}");
Console.WriteLine($"Rendimento:{thePeople.Rendimento}");
Console.WriteLine($"Data Nascimento:{thePeople.DataNascimento}");
Console.WriteLine($"Maior de Idade?:{thePeople.ValidarDataNascimento(thePeople.DataNascimento)}");
Console.WriteLine($"Rua:{thePeople.Endereco.Logradouro}");
Console.WriteLine($"N:{thePeople.Endereco.Numero}");
Console.WriteLine($"Endereço Comercial?:{thePeople.Endereco.Comercial}");


// DateTime data = new DateTime(1989,06,27);
// Console.WriteLine( thePeople.ValidarDataNascimento(data));

