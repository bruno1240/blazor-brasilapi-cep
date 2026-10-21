# blazor-brasilapi-cep

Aula de Blazor WebAssembly + IA — Desenvolvimento Web (Prof. Daniel Henrique Matos de Paiva).

Aplicação **Blazor WebAssembly Standalone** (.NET 10) que consulta endereços pelo CEP usando a
[BrasilAPI](https://brasilapi.com.br/docs#tag/CEP) (`GET https://brasilapi.com.br/api/cep/v1/{cep}`).

## Funcionalidades

- Campo para digitar o CEP (aceita `30130000` ou `30130-000`); consulta pelo botão ou com Enter.
- Validação: CEP vazio ou com quantidade de dígitos diferente de 8 exibe mensagem de erro.
- Exibe CEP, Logradouro, Bairro, Cidade/UF, serviço de origem e os códigos IBGE.
- CEP inexistente (404), falha de conexão ou timeout exibem alerta na tela.

## Estrutura

| Arquivo                                     | Responsabilidade                              |
|---------------------------------------------|-----------------------------------------------|
| `BlazorWasmBrasilApiCep/Models/Cep.cs`      | Modelo da resposta da API                     |
| `BlazorWasmBrasilApiCep/Models/Ibge.cs`     | Objeto aninhado `ibge` da resposta            |
| `BlazorWasmBrasilApiCep/Program.cs`         | Registro do `HttpClient`                      |
| `BlazorWasmBrasilApiCep/Pages/Home.razor`   | Formulário, validação, chamada e exibição     |

## Como rodar

Requer .NET SDK 10.0.

```bash
cd BlazorWasmBrasilApiCep
dotnet run
```

Acesse `http://localhost:5062` e teste com o CEP `30130000` (Av. Afonso Pena, Belo Horizonte).
