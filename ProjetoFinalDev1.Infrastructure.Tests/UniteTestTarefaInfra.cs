using ProjetoFinalDev1.Domain.Entities;
using ProjetoFinalDev1.Domain.Enums;
using ProjetoFinalDev1.Infrastructure.Repositories;

namespace ProjetoFinalDev1.Infrastructure.Tests;

    public class UniteTestTarefaInfra
    {
        [Fact]
        public async Task Tarefa_ObterTodos()
        {
            // ObterTodos
            var repoTarefaTodos = new TarefaRepository();
            var resultado = await repoTarefaTodos.ObterTodos();
            Assert.NotNull(resultado);
        }


        [Fact]
        public async Task Tarefa_Adicionar()
        {
            // cria objeto do tipo TarefaItem
            ETarefaTipo tipos = ETarefaTipo.Casa | ETarefaTipo.Trabalho;
            TarefaItem tarefa = TarefaItem.Criar(0, "Título da Tarefa2", "Descrição da Tarefa2", ETarefaStatus.Pendente, tipos, DateTime.Now, DateTime.Now.AddDays(7));
            
            // cria repositório e adiciona a tarefa
            var repoTarefaAdd = new TarefaRepository();
            var TarefaInserido = await repoTarefaAdd.Adicionar(tarefa);
            Assert.NotNull(TarefaInserido);
            Assert.True(TarefaInserido.Id > 0);
        }


        [Fact]
        public async Task Tarefa_ObterId_Atualizar()
        {
            var _id = 2;

            // ObterPorId - existente para edição
            var repoTarefaBuscaId = new TarefaRepository();
            var TarefaPorId = await repoTarefaBuscaId.ObterPorId(_id);
            Assert.NotNull(TarefaPorId);

            // devido ao principio da imutabilidade, não devemos alterar o objeto atual
            // criar um novo objeto com os dados atualizados
            var TarefaAtualizado = TarefaItem.Criar(TarefaPorId.Id, "Título atualizado", "Descrição atualizada", TarefaPorId.Status, TarefaPorId.Tipo,
            TarefaPorId.DataCriacao, DateTime.Now.AddDays(20));
            
            // atualizar a tarefa no repositório
            var repoTarefaEdit = new TarefaRepository();
            var resultadoAtualizacao = await repoTarefaEdit.Atualizar(TarefaAtualizado);
            Assert.NotNull(resultadoAtualizacao);
            Assert.Equal("TÍTULO ATUALIZADO", resultadoAtualizacao.Titulo);
            Assert.Equal("Descrição atualizada", resultadoAtualizacao.Descricao);
        }


        [Fact]
        public async Task Tarefa_Excluir_ObterId()
        {
            int _id = 3;

            var repoTarefaExcluir = new TarefaRepository();
            var resultadoExcluir = await repoTarefaExcluir.Excluir(_id);
            Assert.True(resultadoExcluir);
        }
    }

