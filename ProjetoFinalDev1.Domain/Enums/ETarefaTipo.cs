namespace ProjetoFinalDev1.Domain.Enums
{
    [Flags]
    public enum ETarefaTipo
    {
        None = 0,
        Trabalho = 1,
        Estudo = 2,
        Casa = 4,
        Saude = 8,
        Financeiro = 16,
        Compras = 32,
        Lazer = 64,
        Familia = 128,
        Pessoal = 256,
    }
}
