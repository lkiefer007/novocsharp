using uc12.interfaces;

namespace uc12.classes
{
    public abstract class Pessoa : IPessoa
    {

        public string ?Nome {get;set;}

        public Endereco ?Endereco {get;set;}

        public float ?Rendimento{get;set;}

        public abstract float PagarImposto(float rendimento);
     
    }
}