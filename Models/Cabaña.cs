namespace TP01MVC_FINAL.Models;

public class Cabaña
{
    private int id;
    private string nombre; 
    private string descripcion;
    private int capacidad;
    private string foto;
    private List<string> ambientes;

    public Cabaña (int id, string nombre, string descripcion, int capacidad, string foto, List<string> ambientes)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.capacidad = capacidad;
        this.foto = foto;
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

    public string GetFoto()
    {
        return this.foto;
    }

    public List<string> GetAmbientes()
    {
        return this.ambientes;
    }

    public int GetCapacidad(){
        return this.capacidad;
    }
}