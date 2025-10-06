using System.Text.Json;
using ScreenSound.Modelos;

using (HttpClient cliente = new HttpClient())
{
    try
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.WriteLine($"{resposta}");

        // for (int i = 0; i < musicas.Count; i++)
        // {
        //     musicas[i].ExibirDetalhesDaMusica();
        //     Thread.Sleep(1000);
        // }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problemas: {ex.Message}");
    }
}