using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca_Global.Data
{
    public class Emprestimo
    {
        [Key] public int Id { get; set; }
        //Foreing key + navegação até a classe
        public int PessoaId { get; set; }  
        public Funcionario Funcionario { get; set; } = new Funcionario();
    }
}
