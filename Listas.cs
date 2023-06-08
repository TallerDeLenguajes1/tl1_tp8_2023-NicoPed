//crear una lase lista
//addrange concatenear una lista a otra
//remove manda la tarea osea el objeto a sacar
//removeAt Toma un indice
//son como quitar
//find tarea = pendiente.Find(t => t.Id == 3)
//con el true lo va concatenando
namespace Tareas;

public class Tarea
{
    private int duracion;
    private int tareaId;
    private string? descripcion;
    public int Duracion { get => duracion; set => duracion = value; }
    public int TareaId { get => tareaId; set => tareaId = value; }
    public string? Descripcion { get => descripcion; set => descripcion = value; }
    
    public Tarea(){

    }
}