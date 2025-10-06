using System.Text.Json;
using ScreenSound.Modelos;

using (HttpClient cliente = new HttpClient())
{
    try
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        Console.WriteLine($"{musicas}");


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problemas: {ex.Message}");
    }
}