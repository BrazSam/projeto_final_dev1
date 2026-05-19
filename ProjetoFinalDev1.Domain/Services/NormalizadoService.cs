using System.Text.RegularExpressions;

namespace ProjetoFinalDev1.Domain.Services
{
    public static partial class NormalizadoService
    {
        //verifica se o texto é nulo ou vazio
        public static bool TextoVazioOuNulo(string? texto) =>  string.IsNullOrWhiteSpace(texto);

        //remove espaços repetidos e espaços no início e no fim do texto
        public static string LimparEspacos(string? texto) => string.IsNullOrWhiteSpace(texto) ? string.Empty : EspacosRegex().Replace(texto, " ").Trim();

        //converte o texto para maiusculo
        public static string ParaMaiusculo(string? texto) => string.IsNullOrEmpty(texto) ? string.Empty : texto.ToUpperInvariant();

        [GeneratedRegex(@"\s+")]
        private static partial Regex EspacosRegex();
    }
}
