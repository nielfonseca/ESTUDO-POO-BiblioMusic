//Objeto é uma instância da Classe, por exemplo o 'música1' e o 'musica2' são objetos da classe Musica()

Musica musica1 = new Musica();
musica1.Nome = "Radioactive";
musica1.Artista = "Imagine Dragons";
musica1.Duracao = 305;
musica1.Disponivel = true;



Musica musica2 = new Musica();
musica2.Nome = "505";
musica2.Artista = "Arctic Monkeys";
musica2.Duracao = 408;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

