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
        Artista artista = new Artista("Xdinary Heroes");
        string productor = "Xdinary heroes, collapsedone, Hong Ji-sang";
        string genero = "Rock";
        List<Cancion> temas = new List<Cancion> { new Cancion("No Matter", 3.30), new Cancion("Little things", 4.15), new Cancion("UNDEFINED", 2.49), new Cancion("Paint it", 3.23), new Cancion("Money on my mind", 3.28) , new Cancion("Dreaming Girl", 3.37) , new Cancion("Until the end of time", 3.36) , new Cancion("Walking to the moon", 2.46)   };
        int id = 001;
        string foto = "Troubleshooting.jpeg";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

        nombre = "Footloose (Original Soundtrack)";
        artista = new Artista("Varios Artistas");
        productor = "Dean Pitchford, Kenny Loggins, otros";
        genero = "Pop Rock / Soundtrack";
        temas = new List<Cancion> {new Cancion("Footloose - Kenny Loggins", 3.46), new Cancion("Let's Hear It for the Boy - Deniece Williams", 4.20),new Cancion("Almost Paradise - Mike Reno & Ann Wilson", 3.50),new Cancion("Holding Out for a Hero - Bonnie Tyler", 5.50),new Cancion("Dancing in the Sheets - Shalamar", 4.06),new Cancion("I'm Free (Heaven Helps the Man) - Kenny Loggins", 3.46),new Cancion("Somebody's Eyes - Karla Bonoff", 3.29),new Cancion("The Girl Gets Around - Sammy Hagar", 3.23),new Cancion("Never - Moving Pictures", 3.44)};
        id = 002;
        foto ="footloose.jpg";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

              nombre = "Infinitely Ordinary";
        artista = new Artista("The Wrecks");
        productor = "The Wrecks";
        genero = "Indie Rock / Pop Punk";
        temas = new List<Cancion> {new Cancion("Freaking Out", 3.10),new Cancion("Feels So Nice", 3.28),new Cancion("Out of Style", 2.56),new Cancion("Fvck Somebody", 3.03),new Cancion("Four", 3.26), new Cancion("We All Get Lonely", 3.17),new Cancion("This Life I Have", 2.52), new Cancion("Infinitely Ordinary", 2.46)};
        id = 003;
        foto = "infinitelyOrdinary.jpg";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

        nombre = "The Chaos Chapter: FREEZE";
        artista = new Artista("Tomorrow X Together");
        productor = "Slow Rabbit, Aaron Hibell, El Capitxn, entre otros";
        genero = "K-pop / Pop Rock / Synth Pop";
        temas = new List<Cancion> {new Cancion("Anti-Romantic", 3.37), new Cancion("0X1=LOVESONG (I Know I Love You) feat. Seori", 3.22), new Cancion("Magic", 2.59), new Cancion("Ice Cream", 3.33), new Cancion("What If I Had Been That PUMA", 3.30), new Cancion("No Rules", 3.09), new Cancion("Dear Sputnik", 3.16), new Cancion("Frost", 2.49)};
        id = 004;
        foto = "Freeze.jpeg";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);


        nombre = "Disenchanted";
        artista = new Artista("The Anti-Queens");
        productor = "Steve Rizun";
        genero = "Punk Rock / Alternative Rock";
        temas = new List<Cancion> {new Cancion("Outta Luck", 2.41), new Cancion("Disenchanted", 3.12), new Cancion("Worse Than Death", 3.05), new Cancion("Run", 3.18), new Cancion("Fever", 2.59), new Cancion("Overthinking", 3.27), new Cancion("Sick & Tired", 2.51), new Cancion("Dangerous", 2.53), new Cancion("Not What You Think", 3.24), new Cancion("Leave Me Out", 3.34)};
        id = 005;
        foto = "Disenchanted.jpeg";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

        nombre = "13";
        artista = new Artista("Blur");
        productor = "William Orbit";
        genero = "Alternative Rock / Electronic";
        temas = new List<Cancion> {new Cancion("Tender", 7.41), new Cancion("Bugman", 4.48), new Cancion("Coffee & TV", 5.58), new Cancion("Swamp Song", 4.36), new Cancion("1992", 6.20), new Cancion("B.L.U.R.E.M.I.", 3.26), new Cancion("Battle", 7.43), new Cancion("Mellow Song", 4.19), new Cancion("Trailerpark", 4.27), new Cancion("Caramel", 7.38), new Cancion("Trimm Trabb", 5.37), new Cancion("No Distance Left to Run", 3.26), new Cancion("Optigan 1", 2.34)};
        foto = "13.jpg";
        id = 006;
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

        nombre = "Imagine";
        artista = new Artista("John Lennon");
        productor = "John Lennon, Yoko Ono, Phil Spector";
        genero = "Soft Rock / Pop Rock";
        temas = new List<Cancion> {new Cancion("Imagine", 3.03), new Cancion("Crippled Inside", 3.47), new Cancion("Jealous Guy", 4.14), new Cancion("It's So Hard", 2.25), new Cancion("I Don't Wanna Be a Soldier Mama", 6.05), new Cancion("Gimme Some Truth", 3.16), new Cancion("Oh My Love", 2.44), new Cancion("How Do You Sleep?", 5.36), new Cancion("How?", 3.43), new Cancion("Oh Yoko!", 4.20)};
        foto = "imagine.jpeg";
        id = 007;
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

        nombre = "Piano Bar";
        artista = new Artista("Charly García");
        productor = "Charly García";
        genero = "Rock Argentino / New Wave";
        temas = new List<Cancion> {new Cancion("Demoliendo Hoteles", 3.13), new Cancion("Promesas sobre el Bidet", 3.40), new Cancion("Raros Peinados Nuevos", 3.23), new Cancion("Piano Bar", 3.05), new Cancion("No Se Va a Poder", 2.33), new Cancion("Cerca de la Revolución", 4.37), new Cancion("Total Interferencia", 3.16), new Cancion("Canción de 2 x 3", 3.21), new Cancion("Plateado sobre Plateado (Huellas en el Mar)", 3.28)};
        foto = "pianoBar.jpeg";
        id = 008;
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);
   
        nombre = "Pablo Honey";
        artista = new Artista("Radiohead");
        productor = "Paul Kolderie, Sean Slade";
        genero = "Alternative Rock / Grunge";
        temas = new List<Cancion> {new Cancion("You", 3.29), new Cancion("Creep", 3.58), new Cancion("How Do You?", 2.12), new Cancion("Stop Whispering", 5.26), new Cancion("Thinking About You", 2.41), new Cancion("Anyone Can Play Guitar", 3.38), new Cancion("Ripcord", 3.10), new Cancion("Vegetable", 3.13), new Cancion("Prove Yourself", 2.25), new Cancion("I Can't", 4.13), new Cancion("Lurgee", 3.08), new Cancion("Blow Out", 4.40)};
        id = 009;
        foto="pabloHoney.jpeg";
        crearAlbum(nombre, artista, productor, genero, temas, foto, id);

        nombre = "Soyokaze Apartment Room 201";
        artista = new Artista("Lamp");
        productor = "Lamp";
        genero = "City Pop / Indie Pop / Jazz Fusion";
        temas = new List<Cancion> {new Cancion("夏の夜と朝の光", 4.52), new Cancion("二人のいた風景", 4.33), new Cancion("黄昏の月", 4.24), new Cancion("日曜日のお別れ", 3.37), new Cancion("この道", 5.11), new Cancion("美しい人", 3.45), new Cancion("恋は月の蔭に", 4.29), new Cancion("四月の風", 4.07), new Cancion("雨のワルツ", 3.36)};
        id = 010;
        foto="room1.jpeg";
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