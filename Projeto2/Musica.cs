class Musica
{
    public string Nome {  get; set; }
    public string Artista {  get; set; }
    public int Duracao {  get; set; }
    public bool Disponivel {  get; set; }

    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista} e a duração é: {Duracao} segundos";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine(DescricaoResumida);
        if (Disponivel)
        {
            Console.WriteLine("Disponível no seu plano Plus+.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+ para escuta-lá.");
        }
    }
}