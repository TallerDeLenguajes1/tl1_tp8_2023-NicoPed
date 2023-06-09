﻿using Tareas;
namespace ToDo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        const int cantTarea = 7;
        static void Main(string[] args)
        {
            var pendientes = new List<Tarea>();
            var realizadas = new List<Tarea>();
            cargarAleatoriamente(pendientes);
            int opcion = 0;
            string? buffer;
            string? descripcionBuscada;
            var tareaAux = new Tarea();
            //Interfaz para pedir
            do
            {
                Console.WriteLine("========================");
                Console.WriteLine("1- Mover Tarea a Realizada");
                Console.WriteLine("2- Buscar Tarea");
                Console.WriteLine("0- Salir");
                Console.WriteLine("========================");
                Console.Write("Ingrese una opcion: ");
                buffer = Console.ReadLine();
                if (!int.TryParse(buffer ,out opcion))
                {
                    opcion = 9999;
                }
                switch (opcion)
                {
                    case 1: 
                        mostrarLista(pendientes);
                        Console.WriteLine("--------------------");
                        Console.Write("Ingrese la descripcion de la clase a mover: ");
                        descripcionBuscada = Console.ReadLine(); 
                        tareaAux = pendientes.Find(t => t.Descripcion == descripcionBuscada);
                        if (tareaAux != null)
                        {
                            realizadas.Add(tareaAux);
                            pendientes.Remove(tareaAux);
                        }else
                        {
                            Console.WriteLine("\n===== Tarea NO Enontrada =====");
                        }
                        break;
                    case 2:
                        Console.Write("Ingrese para buscar un descripcion: ");
                        descripcionBuscada = Console.ReadLine(); 
                        tareaAux = pendientes.Find(t => t.Descripcion == descripcionBuscada);
                        if (tareaAux != null)
                        {
                            Console.WriteLine("\n===== Tarea Enontrada =====");
                            mostrarTarea(tareaAux);
                        }else
                        {
                            Console.WriteLine("\n===== Tarea NO Enontrada =====");
                        }
                        break;
                    case 0:
                        Console.WriteLine("========================");
                        Console.WriteLine("======= SALIENDO =======");
                        Console.WriteLine("========================");
                        break;
                    default:
                        Console.WriteLine("========================");
                        Console.WriteLine("Ingrese una opcion correta");
                        Console.WriteLine("========================");
                        break;
                }    
            } while (opcion != 0);

            //PUNTO 4
            string RutaArchivo = @"C:\Users\Nico Pedraza\Documents\TPs_TLI\Tps\tl1_tp8_2023-NicoPed\sumario.txt";
            if (!File.Exists(RutaArchivo))
            {
                File.Create(RutaArchivo).Close();
                
            }
            //FileStream Fstream = new FileStream(RutaArchivo, FileMode.Open);
            
            int sumarioTareas = 0;
            mostrarLista(realizadas);
            using(StreamWriter writer = new StreamWriter(RutaArchivo)){
                
                foreach (var tarea in realizadas)
                {
                    writer.WriteLine($"---Tarea: {tarea.TareaId} --- duración: {tarea.Duracion}");
                    sumarioTareas += tarea.Duracion;
                }
                writer.WriteLine("-------------------Total: "+sumarioTareas);
            }
        }
        private static void cargarAleatoriamente(List<Tarea> lista){
            for (int i = 0; i < cantTarea; i++)
            {
                var nuevaTarea = new Tarea();
                nuevaTarea.TareaId = i;
                nuevaTarea.Duracion = i*3+5;
                nuevaTarea.Descripcion = "D "+ i;
                lista.Add(nuevaTarea);            
            }
        }
        
        private static void mostrarLista(List<Tarea> lista){
            foreach (var tarea in lista)
            {
                mostrarTarea(tarea);
            }
        }
        private static void mostrarTarea(Tarea tarea){
            Console.WriteLine("------------------------------");
            Console.WriteLine("TareaID: "+tarea.TareaId);
            Console.WriteLine("Descripcion: "+tarea.Descripcion);
            Console.WriteLine("Duracion: "+tarea.Duracion);
            Console.WriteLine("------------------------------");
        }   
    }
}