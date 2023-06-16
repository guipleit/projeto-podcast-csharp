using System.Runtime.CompilerServices;

public class Podcast
{
    public Podcast(string name, string Hostname)
    {
        Name = name;
        Host = Hostname;
        episodes = new List<Episode>();

    }

    public string Name { get; }
    public string Host { get; }

    public List<Episode> episodes { get; set; }

    public int TotalEpisodes => episodes.Count;

    public void addEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void showDetails() 
    {
        Console.WriteLine($"Nome do Podcast: {Name}\nNome do host: {Host}");
        var sortEpisodes = episodes.OrderBy((e) => e.Id);

        foreach (var episode in sortEpisodes)
        {
            Console.WriteLine($"Episódio: {episode.Id}");
            Console.WriteLine($"Title: {episode.Title}");
            Console.WriteLine($"Duration: {episode.Duration}");
            Console.WriteLine($"Description: {episode.Description}");
            Console.WriteLine();
        }
    }
}