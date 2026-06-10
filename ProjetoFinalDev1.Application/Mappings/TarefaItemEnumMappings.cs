using ProjetoFinalDev1.Application.Enums;
using ProjetoFinalDev1.Domain.Enums;
namespace ProjetoFinalDev1.Application.Mappings;

public static class TarefaItemEnumMappings
{
    public static ETarefaTipo ToDomain(this EAppTarefaTipo appTipo)
    {
        return (ETarefaTipo)appTipo;
    }
    public static EAppTarefaTipo ToApp(this ETarefaTipo domainTipo)
    {
        return (EAppTarefaTipo)domainTipo;
    }
    public static ETarefaStatus ToDomain(this EAppTarefaStatus appStatus)
    {
        return (ETarefaStatus)appStatus;
    }
    public static EAppTarefaStatus ToApp(this ETarefaStatus domainStatus)
    {
        return (EAppTarefaStatus)domainStatus;
    }
}