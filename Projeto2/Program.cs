//Objeto é uma instância da Classe, por exemplo o 'música1' e o 'musica2' são objetos da classe Musica()

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
imagineDragons.ExibirDiscografia();