using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManejoArchivos
{
 class Program
 {
  static void Main(string[] args)
  {
   // Creamos una carpeta para el manejo de directorio
   // C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo

   // Creamos un directorio(carpeta) // Tenemos que hacer uso de
   string ruta = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\Estudiantes";
   Directory.CreateDirectory(ruta);

   // Eliminar un directorio // No se elimina cuando tiene alguna informacion la carpeta
   //Directory.Delete(ruta);
   // Eliminar un directorio aun con archivos con el true
   Directory.Delete(ruta,true);

   // Saber que directorios hay dentro de un directorio 
   string rutaExaminar = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\Profesores";
   //Directory.EnumerateDirectories(rutaExaminar); // esto nos devuelve una lista
   // lo metemos en una lista
   //List<string> listaDirectorios = Directory.EnumerateDirectories(rutaExaminar).ToList();

   // Para filtrar seria asi, asi filtramos por ejemplo, las capertas que inicien con la letra C
   // Para poner el que termina en la a es al reves osea *A
   List<string> listaDirectorios = Directory.EnumerateDirectories(rutaExaminar, "C*").ToList();
   foreach (string item in listaDirectorios)
   {
    Console.WriteLine(item);
   }

   Console.WriteLine("===========================");

   // Listamos los archivos dentro de un directorio
   string rutaArchivos = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\Alumnos";
   // Para el filto es igual al ejemplo de arriba
   List<string> ListaArchivos = Directory.EnumerateFiles(rutaArchivos).ToList();
   foreach (string item in ListaArchivos)
   {
    Console.WriteLine(item);
   }

   Console.WriteLine("===========================");

   // Listar archivos y directorios (Todo completo)
   // Todos se pueden filtrar igual como se ha hecho arriba 
   string rutaTodo = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\Alumnos";
   List<string> ListaTodo = Directory.EnumerateFileSystemEntries(rutaTodo).ToList();
   foreach (string item in ListaTodo)
   {
    Console.WriteLine(item);
   }

   Console.WriteLine("===========================");

   // Obtener el directorio donde se esta ejecutando nuestra aplicacion 
   Console.WriteLine(Directory.GetCurrentDirectory());

   // Saber en que unidad estamos
   Console.WriteLine(Directory.GetDirectoryRoot(rutaTodo));

   Console.WriteLine("===========================");

   // Mover archivos a nuevos directorios 
   // string rutaInicio = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\Alumnos";
   // string rutaFinal = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\RutaMover";

   // Directory.Move(rutaInicio, rutaFinal);

   // Obtener informacion de un directorio 
   DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo");
   if (dir.Exists)
   {
    Console.WriteLine("Existe el directorio");
   }
   else
   {
    Console.WriteLine("No existe");
   }

   // EL parent solos nos devuelve la el nomnbre del directorio parent no toda la ruta
   // Con el dirP.Root podemos obtener el disco donde esta la carpeta
   DirectoryInfo dirP = new DirectoryInfo(@"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\Cursos");
   Console.WriteLine(dirP.Parent);

   // Creamos un directorio
   DirectoryInfo dirCre = new DirectoryInfo(@"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\Cursos\Curso para aprender a hablar");
   dirCre.Create();

   // Eliminamos un directorio
   // dirCre.Delete(true);

   Console.WriteLine("===========================");
   string nombreArch = "texto.txt";
   string rutaArc = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\" + nombreArch;
   // File.Create(rutaArc);

   // Llenar de informacion un archivo (En este caso un txt)
   List<string> Nombres = new List<string>();
   Nombres.Add("Rodolfo");
   Nombres.Add("Carlos");
   Nombres.Add("Andres");

   // File.AppendAllLines(rutaArc, Nombres);

   // COn este metodo, enviamos todo con un texto plano
   File.AppendAllText(rutaArc, "\nAlzare mis ojos a los montes\nde donde vendra mi socorro.");

   //Console.WriteLine("===========================");

   // Copiar un archivo de un directorio a otro 
   string nombreMov = "examen.txt";
   string rutaOrigen = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\"+ nombreMov;
   string rutaEnvio = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\Mover\"+ nombreMov;

   // File.Copy(rutaOrigen, rutaEnvio);

   // Crear y llenar un archivo a la misma ves 
   string nombreRap = "escribiendo.txt";
   string rutaArcRap = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\" + nombreRap;

   using (StreamWriter sw = File.CreateText(rutaArcRap))
   {
    sw.Write("Esto puede servir para el proyecto\nPero ojo, no tengo ni idea de como vamos hacer jajaaj");
   };

   // Para mover archivos, hay que tener en cuenta que se borra de uno y se pasa al otro
   // File.Move(rutaOrigen, rutaEnvio);

   // Console.WriteLine("===========================");
   // Sacar los bytes de un archivo
   string archivoBy = "qr.png";
   string rutaBy = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\Imagenes" + archivoBy;
   // string rutaByDestino = @"ruta";

   //byte[] archivo = File.ReadAllBytes(rutaBy);

   // Para mover la imagen de un rato a rato
   // File.WriteAllBytes(rutaByDestino, archivo);

   //Console.WriteLine("===========================");

   // Escribir contenido a un archivo 
   string archCont = "examen.txt";
   string rutaCont = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\"+ archCont;

   string contenido = "Me voy a tomar la maruchan en unos minutos, para tomarme la maruchan";

   File.WriteAllText(rutaCont, contenido);

   // Leer la informacion de un archivo y pasarlo a otro archivo 

   string rutaDestinoCopy = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\contenido.txt";

   string ContenidoArch = File.ReadAllText(rutaCont);

   // File.WriteAllText(rutaDestinoCopy, ContenidoArch);

   // Leer los contenidos de un archivo

   string rutaLeer = @"C:\Users\Fernando\Documents\Servidor\aSeguir\MaestroCsharp\ClaseArchivo\contenido.txt";

   string[] ContArchi = File.ReadAllLines(rutaLeer);

   foreach (string item in ContArchi)
   {
    Console.WriteLine(item);
   }


   Console.WriteLine("===========================");

   // Obtener una informacion del un archivo 
   FileInfo f = new FileInfo(rutaLeer);

   Console.WriteLine(f.Exists); // SI existe el archivo
   Console.WriteLine(f.Length); // El peso en KB
   Console.WriteLine(f.Directory); // Nos da el directorio
   Console.WriteLine(f.Name); // El nombre del archivo

   DirectoryInfo d = f.Directory;
   Console.WriteLine(d.Root); // La unidad donde tenemos el archivo


   Console.ReadKey();
  }
 }
}
