using System.Text.Json;
using System.Text.Json.Nodes;
using ApiPaises.Modelos;

using (HttpClient cliente = new())
{
    var pais = await cliente.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
    // Console.WriteLine($"{pais}");
    var paises = JsonSerializer.Deserialize<List<Paises>>(pais)!;
    for (int i = 0; i < paises.Count; i++)
    {
        paises[i].ExibirDetalhes();
        Thread.Sleep(1000);
    }

}