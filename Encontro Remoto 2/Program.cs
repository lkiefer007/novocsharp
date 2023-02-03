using uc12.classes;

PessoaFisica obj_Pf = new PessoaFisica ();
PessoaFisica obj_Pf2 = new PessoaFisica();



obj_Pf.nome = "Leandro";
obj_Pf.cpf = "125.959.497-13";
obj_Pf.rendimento = 3629;

obj_Pf2.nome = "Jo";

//Console.WriteLine(obj_Pf.nome);
Console.WriteLine($"Nome:{obj_Pf.nome} recebe {obj_Pf.rendimento} de salário");

