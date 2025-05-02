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

              nombre = "Infinitely Ordinary";
        artista = new Artista("The Wrecks", "Álbum debut de la banda estadounidense The Wrecks, lanzado en 2020. Combina elementos del indie rock y pop punk con letras sobre juventud y ansiedad moderna.");
        productor = "The Wrecks";
        genero = "Indie Rock / Pop Punk";
        temas = new List<Cancion> {new Cancion("Freaking Out", 3.10),new Cancion("Feels So Nice", 3.28),new Cancion("Out of Style", 2.56),new Cancion("Fvck Somebody", 3.03),new Cancion("Four", 3.26), new Cancion("We All Get Lonely", 3.17),new Cancion("This Life I Have", 2.52), new Cancion("Infinitely Ordinary", 2.46)};
        id = 003;
        foto = "infinitelyOrdinary.jpg";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

        nombre = "The Chaos Chapter: FREEZE";
        artista = new Artista("Tomorrow X Together", "También conocido como TXT, este grupo de K-pop presenta en su segundo álbum de estudio una mezcla de géneros con letras que exploran el amor, la desesperación y la juventud en tiempos modernos.");
        productor = "Slow Rabbit, Aaron Hibell, El Capitxn, entre otros";
        genero = "K-pop / Pop Rock / Synth Pop";
        temas = new List<Cancion> {new Cancion("Anti-Romantic", 3.37), new Cancion("0X1=LOVESONG (I Know I Love You) feat. Seori", 3.22), new Cancion("Magic", 2.59), new Cancion("Ice Cream", 3.33), new Cancion("What If I Had Been That PUMA", 3.30), new Cancion("No Rules", 3.09), new Cancion("Dear Sputnik", 3.16), new Cancion("Frost", 2.49)};
        id = 004;
        foto = "Freeze.jpeg";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);


        nombre = "Speak Now (Taylor’s Version)";
        artista = new Artista("Taylor Swift", "Regrabación del álbum original de 2010. En esta versión de 2023, Taylor recupera el control de sus masters e incluye temas 'From The Vault' con nuevos colaboradores.");
        productor = "Taylor Swift, Jack Antonoff";
        genero = "Country Pop / Pop Rock";
        temas = new List<Cancion> {new Cancion("Mine", 3.50), new Cancion("Sparks Fly", 4.21), new Cancion("Back to December", 4.55), new Cancion("Speak Now", 4.01), new Cancion("Dear John", 6.44), new Cancion("Mean", 3.57), new Cancion("The Story of Us", 4.25), new Cancion("Never Grow Up", 4.50), new Cancion("Enchanted", 5.52), new Cancion("Better Than Revenge", 3.37), new Cancion("Innocent", 5.01), new Cancion("Haunted", 4.02), new Cancion("Last Kiss", 6.07), new Cancion("Long Live", 4.19), new Cancion("Ours", 3.58), new Cancion("Superman", 4.42), new Cancion("Electric Touch (feat. Fall Out Boy)", 3.53), new Cancion("When Emma Falls in Love", 4.14), new Cancion("I Can See You", 4.05), new Cancion("Castles Crumbling (feat. Hayley Williams)", 4.56), new Cancion("Foolish One", 3.44), new Cancion("Timeless", 4.30)};
        id = 005;
        foto = "speakNow.jpg";
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