using ProjetoFinalDev1.Domain.Entities;


namespace ProjetoFinalDev1.Domain.Interfaces
{
    public interface ITarefaRepository
    {
        Task<IEnumerable<TarefaItem>> ObterTodos();
        Task <TarefaItem> ObterPorId(int id);
        Task<TarefaItem> Adicionar(TarefaItem tarefaItem);
        Task<TarefaItem> Atualizar(TarefaItem tarefaItem);
        Task<bool> Excluir(int id);
        Task<bool> CriarTabela();
    }
}
