//Objeto é uma instância da Classe, por exemplo o 'música1' e o 'musica2' são objetos da classe Musica()
/*
Banda imagineDragons = new Banda("Imagine Dragons");

Album albumDoImagineDragons = new Album("Envolve");

Genero generoRock = new Genero("Rock");


Musica musica1 = new Musica(imagineDragons, "Believer")
{
    Duracao = 204,
    Genero = generoRock,
    Disponivel = true,
};


Musica musica2 = new Musica(imagineDragons, "Thunder")
{
    Duracao = 187,
    Genero = generoRock,
    Disponivel = false,
};


albumDoImagineDragons.AdicionarMusica(musica1);
albumDoImagineDragons.AdicionarMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
imagineDragons.AdicionarAlbum(albumDoImagineDragons);
imagineDragons.ExibirDiscografia();*/


Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("João");

Episodio ep2 = new(2, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("José");
ep2.AdicionarConvidados("Alice");
ep2.AdicionarConvidados("Igor");

Podcast podcast = new("PodCast Amigos", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();

