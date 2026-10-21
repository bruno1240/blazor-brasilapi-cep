namespace BlazorWasmBrasilApiCep.Models
{
    public class Ibge
    {
        // Anuláveis (string?) para eliminar os avisos CS8618 mostrados na aula:
        // o desserializador cria o objeto vazio e só depois preenche os campos.
        public string? city { get; set; }
        public string? state { get; set; }
    }
}
