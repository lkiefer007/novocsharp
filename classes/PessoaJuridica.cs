using uc12.interfaces;

namespace uc12.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string ?Cnpj {get;set;}

        public string ?RazaoSocial {get;set;}

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidadeCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}