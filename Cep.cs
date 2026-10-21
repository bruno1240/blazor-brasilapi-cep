namespace BlazorWasmBrasilApiCep.Models
{
    // Representa o JSON de https://brasilapi.com.br/api/cep/v1/{cep}.
    // Os nomes em minúsculo seguem o JSON da API (gerados pelo conversor JSON → C# da aula).
    public class Cep
    {
        public string? cep { get; set; }
        public string? state { get; set; }
        public string? city { get; set; }
        public string? neighborhood { get; set; }
        public string? street { get; set; }
        public string? service { get; set; }
        public Ibge? ibge { get; set; }
    }
}
