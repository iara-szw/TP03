class Catalogo
{

    static public Dictionary<int, Album> albumes { get; set; }

    static Catalogo()
    {
        albumes = new Dictionary<int, Album>();
    }

    static public void InicializarCatalogo()
    {

        string nombre = "Album1";
        Artista artista = new Artista("nombreArtista", "descripcion");
        string productor = "Productor";
        string genero = "Genero1";
        List<Cancion> temas = new List<Cancion> { new Cancion("nombre", 3.15), new Cancion("nombre2", 3.15), new Cancion("nombre3", 3.15) };
        int id = 123;
        string foto = "roca.jpg";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

        nombre = "Album2";
        artista = new Artista("nombreArtista2", "descripcion2");
        productor = "Productor2";
        genero = "Genero2";
        temas = new List<Cancion> { new Cancion("nombre", 3.15), new Cancion("nombre2", 3.15), new Cancion("nombre3", 3.15) };
        id = 124;
        foto = "AlbumPortada2.png";
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