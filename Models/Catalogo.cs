class Catalogo{

    static public Dictionary<int,Album> albumes{get; set;}

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
        albumes.Add(id,new Album(nombre, artista, productor, genero, temas, foto, id));

         nombre = "Album2";
         artista = new Artista("nombreArtista2","descripcion");
         productor = "Productor2";
         genero = "Genero2";
         temas = new List<Cancion> { new Cancion("nombre", 3.15), new Cancion("nombre2", 3.15),new Cancion("nombre3", 3.15)};
         id = 124;
         foto = "AlbumPortada2.png";
        albumes.Add(id,new Album(nombre, artista, productor, genero, temas, foto, id));

    }

    static public Dictionary<int,Album> devolverCatalogo(){
        return albumes;
    }
}