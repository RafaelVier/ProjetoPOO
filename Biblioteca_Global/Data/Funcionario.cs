using Biblioteca_Global.Components.Pages;

namespace Biblioteca_Global.Data
{
    public class Funcionario : Pessoa
    {
        public float Salario { get; set; }
        public string Cargo { get; set; }

        //Construtores
        public Funcionario() { }

        public Funcionario(int id, string nome, DateTime dataNascimento, string endereco, string cidade, string bairro, string email, float salario, string cargo) : 
            base (id, nome, dataNascimento, endereco, cidade, bairro, email)
        {
            Salario = salario;
            Cargo = cargo;
        }
    }
}
