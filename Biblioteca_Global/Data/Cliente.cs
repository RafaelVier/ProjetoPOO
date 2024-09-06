namespace Biblioteca_Global.Data
{
    public class Cliente : Pessoa
    {
        public float Divida { get; set; }
        public int Telefone { get; set; }

        //Construtores
        public Cliente() { }
        public Cliente(int id, string nome, DateTime dataNascimento, string endereco, string cidade, string bairro, string email, float divida, int telefone) :
            base(id, nome, dataNascimento, endereco, cidade, bairro, email)
        {
            Divida = divida;
            Telefone = telefone;
        }
    }
}
