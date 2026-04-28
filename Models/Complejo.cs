namespace TP01MVC_FINAL.Models;

public class Complejo
{
    Dictionary<int, Cabaña> cabañas;

    public Complejo()
    {
        this.cabañas = CargaDatosManual();
    }

    public Dictionary<int, Cabaña> CargaDatosManual()
    {
        Dictionary<int, Cabaña> cabañas = new Dictionary<int, Cabaña>();
        List<string> fotos1 = new List<string>(){"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6eohP8mqpbCD8liOr9GKOdFLACbEOj5CK6A&s", "https://www.arkitectureonweb.com/o/adaptive-media/image/11036242/preview-1000px-lite/Cedar+Cabin-4.jpg?t=1620730248418"};
        List<string> ambientes1 = new List<string>(){"Sala de ensayo amplia", "Cuarto de pool", "Cocina de marmol"};
        Cabaña Cabaña1 = new Cabaña(502, "Cabaña macho", "Cabaña para salir con amigos", 8, fotos1, ambientes1);
        cabañas.Add(Cabaña1.GetId(), Cabaña1);

        Dictionary<int, Cabaña> cabañas = new Dictionary<int, Cabaña>();
        List<string> fotos2 = new List<string>(){"https://www.ecosdeargentina.com/casas-cabanas-en-cuyo-con-aire-acondicionado", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTiR5ejzmnnRR9c1Lhw-4QOtW1lk043nJkLag&s"};
        List<string> ambientes2 = new List<string>(){"baño completo", "patio con pileta", "Cuarto con cama matrimonial"};
        Cabaña Cabaña2 = new Cabaña(502, "Cabaña fausta", "Cabaña para salir con gedes", 22, fotos2, ambientes2);
        cabañas.Add(Cabaña2.GetId(), Cabaña2);
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
