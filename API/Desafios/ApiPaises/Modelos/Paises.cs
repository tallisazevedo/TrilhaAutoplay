using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiPaises.Modelos;

public class Paises
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }

    [JsonPropertyName("capital")]
    public string? Capital { get; set; }

    [JsonPropertyName("cotinente")]
    public string? Continente { get; set; }

    [JsonPropertyName("Idioma")]
    public string? Idioma { get; set; }

    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nPaís: {Nome}");
        Console.WriteLine($"Capital do País: {Capital}");
        Console.WriteLine($"Continente: {Continente}");
        Console.WriteLine($"Idioma falado: {Idioma}");
        Console.WriteLine($"População do País: {Populacao}");

    }
}
