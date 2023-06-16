public class Episode
{
    private static int counter = 0;

    public Episode(Podcast podcast, string title, int duration)
    {
        Id = ++counter;
        Title = title;
        Duration = duration;
        Description = $"Numero: {Id}\n" +
                      $"Nome: {Title}\n" +
                      $"Duração: {(Duration / 60)}:00";
        podcast.addEpisode(this);
    }

    public int Id { get; }
    public string Title { get; }
    public int Duration { get; }

    public string Description { get; }

    public void AddGuests() { }
}
