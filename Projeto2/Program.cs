//Objeto é uma instância da Classe, por exemplo o 'música1' e o 'musica2' são objetos da classe Musica()

Album albumDoImagineDragons = new Album();
albumDoImagineDragons.Nome = "Envolve";

Musica musica1 = new Musica();
musica1.Nome = "Believer";
musica1.Duracao = 204;


Musica musica2 = new Musica();
musica2.Nome = "Thunder";
musica2.Duracao = 187;

albumDoImagineDragons.AdicionarMusica(musica1);
albumDoImagineDragons.AdicionarMusica(musica2);

albumDoImagineDragons.ExibirMusicasDoAlbum();