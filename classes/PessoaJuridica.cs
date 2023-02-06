using uc12.interfaces;
using System.Text.RegularExpressions;

namespace uc12.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? Cnpj { get; set; }

        public string? RazaoSocial { get; set; }

        public string? Fantasia { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
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
    }
}