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
            //Para ver si arga correctamente
            // for (int i = 0; i < cantTarea; i++)
            // {
            //     Console.WriteLine("-->"+pendiente[i].Duracion);
            // }
            int opcion = 0;
            do
            {
                
            } while (opcion != 0);
        }
        private static void cargarAleatoriamente(List<Tarea> Lista){
            for (int i = 0; i < cantTarea; i++)
            {
                var nuevaTarea = new Tarea();
                nuevaTarea.TareaId = i;
                nuevaTarea.Duracion = i*3+5;
                nuevaTarea.Descripcion = "Desripicion "+ i;
                Lista.Add(nuevaTarea);            
            }
        }
    }
}