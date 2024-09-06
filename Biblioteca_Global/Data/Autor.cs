namespace Biblioteca_Global.Data
{
    public class Autor : Pessoa
    {
        public string Nacionalidade { get; set; }
        public Autor(int id, string nome, DateTime dataNascimento, string endereco, string cidade, string bairro, string email, string nacionalidade) :
            base(id, nome, dataNascimento, endereco, cidade, bairro, email)
        {
            Nacionalidade = nacionalidade;
        }
    }
}
