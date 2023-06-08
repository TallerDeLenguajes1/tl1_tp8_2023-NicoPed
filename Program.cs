using System;
using Tareas;
namespace ToDo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        const int cantTarea = 5;
        static void Main(string[] args)
        {
            var pendiente = new List<Tarea>();
            var realizadas = new List<Tarea>();
            cargarAleatoriamente(pendiente);
            
        }
        private static void cargarAleatoriamente(List<Tarea> Lista){
            var nuevaTarea = new Tarea();
            for (int i = 0; i < cantTarea; i++)
            {
                nuevaTarea.TareaId = i;
                nuevaTarea.Duracion = i*3+5;
                nuevaTarea.Descripcion = "Desripicion"+ i;
                Lista.Insert(0,nuevaTarea);            
            }
        }
    }
}