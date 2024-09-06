namespace Biblioteca_Global.Data
{
    public interface IRepository <T>
    {
        public Task<List<T>> ObterTodos();
        public Task Add(T entidade);
        public Task<T> ObterPorId(object id);
        public Task<bool> Atualizar(T entidade);
        public  Task<bool> Excluir(T entidade);

    }
}
