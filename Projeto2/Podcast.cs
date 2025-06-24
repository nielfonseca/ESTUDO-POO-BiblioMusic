class Podcast
{
    public string Host {  get; set; }
    public string Nome { get; set; }
    public int TotalEpisodios { get; set; }

    public void AdicionarEpisodio()
    {
        TotalEpisodios = 0;
    }

    public void ExibirDetalhes()
    {

    }
}