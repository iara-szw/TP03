class Catalogo{

    static public Dictionary<int,Album> albumes;

    static Catalogo(){
        albumes = new Dictionary<int, Album>();
    }

    static public void InicializarCatalogo(){

        string nombre = "Album1";
        Artista artista = new Artista("nombreArtista","descripcion");
        string productor = "Productor";
        string genero = "Genero1";
        List<Cancion> temas = new List<Cancion> { new Cancion("nombre", 3.15), new Cancion("nombre2", 3.15),new Cancion("nombre3", 3.15)};
        int id = 123;
        string foto = "AlbumPortada.png";
        albumes.Add(id,new Album(nombre, artista, productor, genero, temas, foto));

    }
}