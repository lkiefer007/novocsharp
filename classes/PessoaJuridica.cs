using uc12.interfaces;
using System.Text.RegularExpressions;

namespace uc12.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? Cnpj { get; set; }

        public string? RazaoSocial { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";

        public string? Fantasia { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //pessoa juridica
        //para rendimentos até R$ 5000,00 - desconto 6%
        //para rendimentos entre R$ 5001,00 e R$10.000,00 - desconto de 8%
        //para rendimentos acima de R$10.000,01 - desconto de 10%


        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 5000)
            {
                //6%

                return rendimento - rendimento / 100 * 6;
            }
            else if (rendimento <= 10000)
            {
                //8%
                return rendimento - rendimento / 100 * 8;
            }
            else
            {
                //rendimento 10%
                return rendimento - rendimento / 100 * 10;
            }
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public bool ValidadeCnpj(string cnpj)
        {
            //novaPj.Cnpj = "62.236.353/0001-42"; 18digitos
            //novaPj.Cnpj = "62236353000142";     14digitos
            //verificar se tem o 0001

            if (Regex.IsMatch(cnpj, @"^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$"))
            {

                if (cnpj.Length == 18)
                {//18 digitos

                    if (cnpj.Substring(11, 4) == "0001")
                    { //0001
                        return true;

                    }
                    else if (cnpj.Length == 14)
                    {//14 digitos

                        if (cnpj.Substring(8, 4) == "0001")
                        { //0001
                            return true;
                        }
                    }

                }

            }
            return false;
        }

        public void Inserir(PessoaJuridica pj)
        {
            Utils.VerificarPastaArquivo(caminho);

            //criando uma coleção de dados string
            string[] pjValores = { $"{pj.Nome}, {pj.Cnpj}, {pj.RazaoSocial}" };

            File.AppendAllLines(caminho, pjValores);
        }

        public List<PessoaJuridica> LerArquivos()
        {
            List<PessoaJuridica> ListaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            //posiçoes no arquivo
            foreach (string cadaLinha in linhas)
            {
                string[] atributo = cadaLinha.Split(",");

                PessoaJuridica novaPj = new PessoaJuridica();

                novaPj.Nome = atributo[0];
                novaPj.Cnpj = atributo[1];
                novaPj.RazaoSocial = atributo[2];

                ListaPj.Add(novaPj);
            }

            return ListaPj;

        }

    }
}