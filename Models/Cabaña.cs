namespace TP01MVC_FINAL.Models;

public class Cabaña;
{
    private int id;
    private string nombre; 
    private string descripción;
    private int capacidad;
    private List<string> fotos;
    private List<string> ambientes;

    public Cabaña (int id, string nombre, string descripcion, int capacidad, List<string> fotos, List<string> ambientes)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.capacidad = capacidad;
        this.fotos = fotos;
        this.ambientes = ambientes;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public int GetId()
    {
        return this.id;
    }

    public string GetNombre()
    {
        return this.nombre;
    }

    public string GetDescripcion()
    {
        return this.descripcion;
    }

    public List<string> Getfotos()
    {
        return this.fotos;
    }

    public List<string> Getambientes()
    {
        return this.ambientes;
    }
}