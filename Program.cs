namespace indexadorDeCarpetas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutaDeCarpeta = @"C:\Users\Nico Pedraza\Documents\TPs_TLI\carpetaPrueba";
            if (Directory.Exists(rutaDeCarpeta))
            {
                List<string> archivos = Directory.GetFiles(rutaDeCarpeta).ToList();
                foreach (var archivo in archivos)
                {
                    Console.WriteLine(archivo);
                }
            string rutaArchivoCSV = Path.Combine(rutaDeCarpeta, "index.csv");
            if (!File.Exists(rutaArchivoCSV))
            {
                File.Create(rutaArchivoCSV).Close();
            }
            using (StreamWriter writer = new StreamWriter(rutaArchivoCSV)){
                writer.WriteLine("indice;nombre;extension");
                foreach (var archivo in archivos)
                {
                    var infoArchivo = new FileInfo(archivo);
                    writer.WriteLine($"{infoArchivo.Directory};{infoArchivo.Name};{infoArchivo.Extension}");

                }
            }
            }
            else
            {
                Console.WriteLine("No existe la susodicha carpeta");
            }
        }
        
    }
}