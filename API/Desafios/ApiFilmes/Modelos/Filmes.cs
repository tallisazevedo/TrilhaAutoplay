using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiFilmes.Modelos;

public class Filmes
{
    // Titulo Simples
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }
    // Titulo completo
    [JsonPropertyName("fullTitle")]
    public string? TituloCompleto { get; set; }
    // Ano
    [JsonPropertyName("year")]
    public string? AnoLancamento { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Ano de Lançamento: {AnoLancamento}");
        Console.WriteLine($"Título completo: {TituloCompleto}");
        Console.WriteLine($" ");
    }
}