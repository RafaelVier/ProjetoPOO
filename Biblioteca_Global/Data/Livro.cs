using System.ComponentModel.DataAnnotations;

namespace Biblioteca_Global.Data
{
    public class Livro
    {
        [Key] public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int QuantidadePagina{ get; set; }
        public int Edicao { get; set; }
        public DateTime DataLancamento { get; set; }

        public Livro() { }

        public Livro(int id, string titulo, string genero, int quantidadePagina, int edicao, DateTime dataLancamento) 
        {
            Id = id;
            Titulo = titulo;
            Genero = genero;
            QuantidadePagina = quantidadePagina;
            Edicao = edicao;
            DataLancamento = dataLancamento;
        }
    }
}
