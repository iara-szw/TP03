class Album{
    
    string nombre;
    Artista artista;
    string productor;
    string genero;
    List<Cancion>temas;
    string foto;

    public Album(string Nombre, Artista Artista, string Productor,string Genero, List<Cancion> Temas, string Foto){
        nombre = Nombre;
        artista = Artista;
        productor = Productor;
        genero = Genero;
        temas = Temas;
        foto = Foto;
    }

}