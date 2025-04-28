class Album{
    
    public string nombre{get; private set;}
    public Artista artista{get; private set;}
    public string productor{get; private set;}
    public string genero{get; private set;}
    public List<Cancion>temas{get; private set;}
    public string foto{get; private set;}
    public int id{get; private set;}

    public Album(string Nombre, Artista Artista, string Productor,string Genero, List<Cancion> Temas, string Foto, int Id){
        nombre = Nombre;
        artista = Artista;
        productor = Productor;
        genero = Genero;
        temas = Temas;
        foto = Foto;
        id=Id;
    }

}