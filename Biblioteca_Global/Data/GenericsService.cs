using Biblioteca_Global.Context;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca_Global.Data
{
    public class GenericsService <T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly ApplicationDbContext _applicationDbContext;

        //public GenericsService() { }
        public GenericsService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _dbSet = _applicationDbContext.Set<T>();
        }

        //Obter uma lista de todos os registros
        public async Task<List<T>> ObterTodos()
        {
            return await _dbSet.ToListAsync();
        }

        //Adicionar novo funcionario
        public async Task Add(T entidade)
        {
            //if (entidade is Funcionario funcionario)
            //{
            //    if (string.IsNullOrEmpty(funcionario.Bairro))
            //    {
            //        throw new ArgumentException("O campo Bairro é obrigatório.");
            //    }
            //}

            _dbSet.Add(entidade);
            await _applicationDbContext.SaveChangesAsync();

        }

        ////Obter funcionario pelo ID
        //public async Task<Funcionario> ObterFuncionarioPeloId(int id)
        //{
        //    Funcionario funcionario = await _applicationDbContext.Funcionarios.FirstOrDefaultAsync(x => x.Id == id);
        //    return funcionario;
        //}

        // Obter registro pelo ID - new
        public async Task<T> ObterPorId(object id)
        {
            var keyProperty = _applicationDbContext.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties.FirstOrDefault();

            if (keyProperty == null)
                throw new InvalidOperationException("A entidade não possui uma chave primária.");

            var parameter = EF.Property<object>(await _dbSet.FindAsync(id), keyProperty.Name);
            return await _dbSet.FindAsync(parameter);
        }

        //Atualizar registro
        public async Task<bool> Atualizar(T entidade)
        {
            _applicationDbContext.Update(entidade);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Remover registro
        public async Task<bool> Excluir(T entidade)
        {
            _applicationDbContext.Remove(entidade);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
