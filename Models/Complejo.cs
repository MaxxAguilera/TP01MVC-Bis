namespace TP01MVC_FINAL.Models;

public class Complejo
{
    Dictionary<int, Cabaña> cabañas;

    public Complejo()
    {
        this.cabañas = CargaDatosManual();
    }

    private Dictionary<int, Cabaña> CargaDatosManual()
    {
        Dictionary<int, Cabaña> cabañas = new Dictionary<int, Cabaña>();
        string foto1 = "/imagenes/FotoCabaña1.avif";
        List<string> ambientes1 = new List<string>(){"Sala de ensayo amplia", "Cuarto de pool", "Cocina de marmol"};
        Cabaña cabaña1 = new Cabaña(6767, "Cabaña macho", "Cabaña para salir con amigos", 8, foto1, ambientes1);
        cabañas.Add(cabaña1.GetId(), cabaña1);

        string foto2 = "/imagenes/FotoCabaña2.avif";
        List<string> ambientes2 = new List<string>(){"baño completo", "patio con pileta", "Cuarto con cama matrimonial"};
        Cabaña cabaña2 = new Cabaña(369, "Cabaña fausta", "Cabaña para salir con gedes", 22, foto2, ambientes2);
        cabañas.Add(cabaña2.GetId(), cabaña2);
        return cabañas;
    } 

    public Dictionary<int, Cabaña> DevolverCabañas()
    {
        return this.cabañas;
    }

    public Cabaña GetCabaña(int dni)
    {    
        if(cabañas.ContainsKey(dni)) return cabañas[dni];
        return null;
    }
}
