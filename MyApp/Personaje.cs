

public enum Tipos
{
    Vuela,
    PiedaDelInfinito,
    SueroSupersoldado,
    Magia,
    ArtesMarciales
}

public enum Nombres
{
    SteveRogers,
    TonyStark,
    NatashaRomanoff,
    BruceBanner,
    StephenStrange,
    WandaMaximoff,
    ClintBarton,
    PeterParker
}

public enum Apodos
{
    CaptainAmerica,
    IronMan,
    BlackWidow,
    Hulk,
    DrStrange,
    ScarletWich,
    Hawkeye,
    SpiderMan
}

public class Caracteristicas
{
    private int velocidad;
    private int destreza;
    private int fuerza;
    private int nivel;
    private int armadura;

    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Destreza { get => destreza; set => destreza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public int Armadura { get => armadura; set => armadura = value; }
}

public class Datos
{
    private Tipos tipo;
    private Nombres nombre;
    private Apodos apodo;
    private DateTime fechaNac;
    private int edad;
    private int salud;
    string apodoBusquedaApi;

    public Tipos Tipo { get => tipo; set => tipo = value; }
    public Nombres Nombre { get => nombre; set => nombre = value; }
    public Apodos Apodo { get => apodo; set => apodo = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Salud { get => salud; set => salud = value; }
    public string ApodoBusquedaApi { get => apodoBusquedaApi; set => apodoBusquedaApi = value; }
}


public class Personaje
{
    private Datos datos = new Datos();
    private Caracteristicas caracteristicas = new Caracteristicas();
    DateTime now = DateTime.Today;
    private int edad = 0;

    public Datos Datos { get => datos; set => datos = value; }
    public Caracteristicas Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
    public DateTime Now { get => now; set => now = value; }
    public int Edad { get => edad; set => edad = value; }


    public int calcularEdad(DateTime fechaNac)
    {
        Edad = Now.Year - fechaNac.Year;

        if(fechaNac.Month > Now.Month)
        {
            Edad = Edad-1;
        }

        return Edad;
    }

    public Personaje cargarPersonajes()
    {
        Personaje NPersonaje = new Personaje();
        Random rand = new Random();

        NPersonaje.caracteristicas.Velocidad = rand.Next(1, 11);
        NPersonaje.caracteristicas.Destreza = rand.Next(1, 6);
        NPersonaje.caracteristicas.Fuerza = rand.Next(1, 11);
        NPersonaje.caracteristicas.Nivel = rand.Next(1, 11);
        NPersonaje.caracteristicas.Armadura = rand.Next(1, 11);
        
        int dato = rand.Next(1, 9);

        switch (dato)
        {
        case 1:
            NPersonaje.datos.Tipo = Tipos.SueroSupersoldado;
            NPersonaje.datos.Nombre = Nombres.SteveRogers;
            NPersonaje.datos.Apodo = Apodos.CaptainAmerica;
            NPersonaje.datos.ApodoBusquedaApi = "Captain America";
            break;
        case 2:
            NPersonaje.datos.Tipo = Tipos.Vuela;
            NPersonaje.datos.Nombre = Nombres.TonyStark;
            NPersonaje.datos.Apodo = Apodos.IronMan;
            NPersonaje.datos.ApodoBusquedaApi = "Iron Man";
            break;
        case 3:
            NPersonaje.datos.Tipo = Tipos.ArtesMarciales;
            NPersonaje.datos.Nombre = Nombres.NatashaRomanoff;
            NPersonaje.datos.Apodo = Apodos.BlackWidow;
            NPersonaje.datos.ApodoBusquedaApi = "Black Widow";
            break;
        case 4:
            NPersonaje.datos.Tipo = Tipos.SueroSupersoldado;
            NPersonaje.datos.Nombre = Nombres.BruceBanner;
            NPersonaje.datos.Apodo = Apodos.Hulk;
            NPersonaje.datos.ApodoBusquedaApi = "Hulk";
            break;
        case 5:
            NPersonaje.datos.Tipo = Tipos.Magia;
            NPersonaje.datos.Nombre = Nombres.StephenStrange;
            NPersonaje.datos.Apodo = Apodos.DrStrange;
            NPersonaje.datos.ApodoBusquedaApi = "Stephen";
            break;
        case 6:
            NPersonaje.datos.Tipo = Tipos.PiedaDelInfinito;
            NPersonaje.datos.Nombre = Nombres.WandaMaximoff;
            NPersonaje.datos.Apodo = Apodos.ScarletWich;
            NPersonaje.datos.ApodoBusquedaApi = "Scarlet Witch";
            break;
        case 7:
            NPersonaje.datos.Tipo = Tipos.ArtesMarciales;
            NPersonaje.datos.Nombre = Nombres.ClintBarton;
            NPersonaje.datos.Apodo = Apodos.Hawkeye;
            NPersonaje.datos.ApodoBusquedaApi = "Hawkeye";
            break;
        case 8:
            NPersonaje.datos.Tipo = Tipos.ArtesMarciales;
            NPersonaje.datos.Nombre = Nombres.PeterParker;
            NPersonaje.datos.Apodo = Apodos.SpiderMan;
            NPersonaje.datos.ApodoBusquedaApi = "Spider-Man (Peter Parker)";
            break;
        default:
            break;
        }

        NPersonaje.datos.FechaNac = new DateTime(rand.Next(1710, 2011), rand.Next(1, 13), rand.Next(1, 29));

        NPersonaje.datos.Edad = NPersonaje.calcularEdad(NPersonaje.datos.FechaNac);

        NPersonaje.datos.Salud = 100;

        return NPersonaje;
    }

    public void mostrarDatos()
    {
        Console.WriteLine("\n\n----------PERSONAJE----------");
        Console.WriteLine("Tipo: " + Datos.Tipo);
        Console.WriteLine("Nombre: " +  Datos.Nombre);
        Console.WriteLine("Apodo: " + Datos.Apodo);
        Console.WriteLine("Fecha de nacimiento: " + Datos.FechaNac.ToShortDateString());
        Console.WriteLine($"Edad: [{Datos.Edad}] años");
        Console.WriteLine($"Salud: [{Datos.Salud}] vida/s");
        Console.WriteLine($"Velocidad: [{Caracteristicas.Velocidad}] km/h");
        Console.WriteLine($"Destreza: [{Caracteristicas.Destreza}]");
        Console.WriteLine($"Fuerza: [{Caracteristicas.Fuerza}]");
        Console.WriteLine($"Nivel: [{Caracteristicas.Nivel}]");
        Console.WriteLine($"Armadura: [{Caracteristicas.Armadura}]");
    } 

    public void mostrarApodo()
    {
        Console.WriteLine(Datos.Apodo);
    }

    public void mejoraDeHabilidades(Personaje ganador){
        if (ganador.Datos.Salud == 100)
        {
            Random rand = new Random();
            int agregarFuerza = rand.Next(5, 11);
            ganador.caracteristicas.Fuerza = ganador.Caracteristicas.Fuerza + (ganador.Caracteristicas.Fuerza / agregarFuerza);
        } else
        {
            ganador.datos.Salud = ganador.Datos.Salud + (ganador.Datos.Salud / 10);
            if (ganador.Datos.Salud > 100)
            {
                ganador.datos.Salud = 100;
            }
        }
    }

}