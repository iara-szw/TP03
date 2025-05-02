class Catalogo
{

    static public Dictionary<int, Album> albumes { get; set; }

    static Catalogo()
    {
        albumes = new Dictionary<int, Album>();
    }

    static public void InicializarCatalogo()
    {

        string nombre = "TroubleShooting";
        Artista artista = new Artista("Xdinary Heroes", "'Troubleshooting' es el primer album completo de 'Xdinary Heroes', estrenado el 30 de Abril de 2024. Con una duración total de 33:08 minutos y un total de 10 canciones." );
        string productor = "Xdinary heroes, collapsedone, Hong Ji-sang";
        string genero = "Rock";
        List<Cancion> temas = new List<Cancion> { new Cancion("No Matter", 3.30), new Cancion("Little things", 4.15), new Cancion("UNDEFINED", 2.49), new Cancion("Paint it", 3.23), new Cancion("Money on my mind", 3.28) , new Cancion("Dreaming Girl", 3.37) , new Cancion("Until the end of time", 3.36) , new Cancion("Walking to the moon", 2.46)   };
        int id = 001;
        string foto = "Troubleshooting.jpeg";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

        nombre = "Footloose (Original Soundtrack)";
        artista = new Artista("Varios Artistas", "La banda sonora de 'Footloose', película de 1984, es un ícono del pop rock de los años 80. Incluye éxitos de Kenny Loggins, Bonnie Tyler, y otros.");
        productor = "Dean Pitchford, Kenny Loggins, otros";
        genero = "Pop Rock / Soundtrack";
        temas = new List<Cancion> {new Cancion("Footloose - Kenny Loggins", 3.46), new Cancion("Let's Hear It for the Boy - Deniece Williams", 4.20),new Cancion("Almost Paradise - Mike Reno & Ann Wilson", 3.50),new Cancion("Holding Out for a Hero - Bonnie Tyler", 5.50),new Cancion("Dancing in the Sheets - Shalamar", 4.06),new Cancion("I'm Free (Heaven Helps the Man) - Kenny Loggins", 3.46),new Cancion("Somebody's Eyes - Karla Bonoff", 3.29),new Cancion("The Girl Gets Around - Sammy Hagar", 3.23),new Cancion("Never - Moving Pictures", 3.44)};
        id = 002;
        foto ="footloose.jpg";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

        nombre = "Album3";
        artista = new Artista("nombreArtista3", "descripcion3");
        productor = "Productor3";
        genero = "Genero3";
        temas = new List<Cancion> { new Cancion("nombre", 3.15), new Cancion("nombre2", 3.15), new Cancion("nombre3", 3.15) };
        id = 125;
        foto = "AlbumPortada2.png";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

        nombre = "Album4";
        artista = new Artista("nombreArtista3", "descripcion3");
        productor = "Productor3";
        genero = "Genero3";
        temas = new List<Cancion> { new Cancion("nombre", 3.15), new Cancion("nombre2", 3.15), new Cancion("nombre3", 3.15) };
        id = 126;
        foto = "AlbumPortada2.png";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);
                nombre = "Album5";
        artista = new Artista("nombreArtista3", "descripcion3");
        productor = "Productor3";
        genero = "Genero3";
        temas = new List<Cancion> { new Cancion("nombre", 3.15), new Cancion("nombre2", 3.15), new Cancion("nombre3", 3.15) };
        id = 127;
        foto = "AlbumPortada2.png";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);
    }

    static public Dictionary<int, Album> devolverCatalogo()
    {
        return albumes;
    }

    static public void crearAlbum(string Nombre, Artista artista, string productor, string genero, List<Cancion> temas, string foto, int id)
    {
        bool yaExiste = false;
        foreach (Album alb in albumes.Values)
        {
            if (alb.nombre == Nombre)
            {
                yaExiste = true;
            }
        }
        if (!yaExiste)
        {
            albumes.Add(id, new Album(Nombre, artista, productor, genero, temas, foto, id));
        }

    }
}