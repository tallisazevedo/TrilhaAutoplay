using System.Text.Json;
using ApiFilmes.Modelos;
Console.Clear();
using (HttpClient cliente = new HttpClient())
{
    try
    {
        string filme = await cliente.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filmes>>(filme)!;
        for (int i = 0; i < filmes.Count; i++)
        {
            Console.Write($"{i + 1} - ");
            filmes[i].ExibirDetalhes();
            Thread.Sleep(1000);
        }
        Console.WriteLine($"\nTotal de filmes: {filmes.Count}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}