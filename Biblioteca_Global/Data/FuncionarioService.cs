//using Biblioteca_Global.Context;
//using Microsoft.EntityFrameworkCore;

//namespace Biblioteca_Global.Data
//{
//    public class FuncionarioService
//    {
//        private readonly ApplicationDbContext _applicationDbContext;
//        public FuncionarioService(ApplicationDbContext applicationDbContext)
//        {
//            _applicationDbContext = applicationDbContext;
//        }

//        //Obter uma lista de todos os funcionários
//        public async Task<List<Funcionario>> ObterTodosFuncionarios()
//        {
//            return await _applicationDbContext.Funcionarios.ToListAsync();
//        }

//        //Adicionar novo funcionario
//        public async Task<bool> AddFuncionario(Funcionario funcionario)
//        {
//            await _applicationDbContext.Funcionarios.AddAsync(funcionario);
//            await _applicationDbContext.SaveChangesAsync();
//            return true;
//        }

//        //Obter funcionario pelo ID
//        public async Task<Funcionario> ObterFuncionarioPeloId(int id)
//        {
//            Funcionario funcionario = await _applicationDbContext.Funcionarios.FirstOrDefaultAsync(x => x.Id == id);
//            return funcionario;
//        }

//        //Atualizar registro de funcionario
//        public async Task<bool> AtualizarFuncionario(Funcionario funcionario)
//        {
//            _applicationDbContext.Funcionarios.Update(funcionario);
//            await _applicationDbContext.SaveChangesAsync();
//            return true;
//        }

//        //Remover registro de funcionario
//        public async Task<bool> ExcluirFuncionario(Funcionario funcionario)
//        {
//            _applicationDbContext.Funcionarios.Remove(funcionario);
//            await _applicationDbContext.SaveChangesAsync();
//            return true;
//        }
//    }
//}
