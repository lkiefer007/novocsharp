using uc12.interfaces;

namespace uc12.classes
{
    public class PessoaFisica : Pessoa,  IPessoaFisica
    {

        public string ?cpf {get;set;}
        public DateTime ?dataNascimento {get;set;}

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime dataNesc)
        {
            throw new NotImplementedException();
        }
    }
}