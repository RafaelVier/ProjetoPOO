using Microsoft.VisualBasic;

using System.ComponentModel.DataAnnotations;

namespace Biblioteca_Global.Data
{
    public abstract class Pessoa
    {
        //Atributos
        [Key] public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Email { get; set;}
        //public int Idade { get {
        //      DateOnly dataAtual = DateOnly.FromDateTime(DateTime.Now);
        //    int idade = dataAtual.Year - DataNascimento.Year;

        //    if (dataAtual < DataNascimento.AddYears(idade))
        //  {
        //    idade--;
        //}

        //  return idade;

        // } }

        //Construtor da classe

        public Pessoa() { }

        public Pessoa(int id, string nome, DateTime dataNascimento, string endereco, string cidade, string bairro, string email)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Cidade = cidade;
            Bairro = bairro;
            Email = email;
        }

        // Métodos
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade:");
        }
    }
}
