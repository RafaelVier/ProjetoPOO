//using Biblioteca_Global.Context;
//using Microsoft.EntityFrameworkCore;

//namespace Biblioteca_Global.Data
//{
//    public class PessoaService
//    {
//        private readonly ApplicationDbContext _applicationDbContext;
//        public PessoaService(ApplicationDbContext applicationDbContext) 
//        {
//            _applicationDbContext = applicationDbContext;
//        }

//        //Obter uma lista de todos os funcionários
//        public async Task<List<Pessoa>> ObterTodasPessoas()
//        {
//            return await _applicationDbContext.Pessoas.ToListAsync();
//        }

//        //Adicionar nova pessoa
//        public async Task<bool> AddNovaPessoa(Pessoa pessoa)
//        {
//            await _applicationDbContext.Pessoas.AddAsync(pessoa);
//            await _applicationDbContext.SaveChangesAsync();
//            return true;
//        }

//        //Obter Pessoa pelo ID
//        public async Task<Pessoa> ObterPessoaPeloId(int id)
//        {
//            Pessoa pessoa = await _applicationDbContext.Pessoas.FirstOrDefaultAsync(x => x.Id == id);
//            return pessoa;
//        }

//        //Atualizar registro de pessoa
//        public async Task<bool> AtualizarPessoa(Pessoa pessoa)
//        {
//            _applicationDbContext.Pessoas.Update(pessoa);
//            await _applicationDbContext.SaveChangesAsync();
//            return true;
//        }

//        //Remover registro de pessoa
//        public async Task<bool> ExcluirPessoa(Pessoa pessoa)
//        {
//            _applicationDbContext.Pessoas.Remove(pessoa);
//            await _applicationDbContext.SaveChangesAsync();
//            return true;
//        }
//    }
//}
