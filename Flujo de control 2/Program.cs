using System;

namespace Flujo_de_control_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            Console.Write("Cantidad de estudiantes a ingresar: ");
            cantidad = int.Parse(Console.ReadLine());

            Estudiantes[] estudiantes = new Estudiantes[cantidad];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i] = new Estudiantes();
                Console.WriteLine($"Estudiante #{i + 1}");
                Console.Write($"Ingrese el nombre del estudiante #{i + 1}:  ");
                estudiantes[i].nombre = Console.ReadLine();
                Console.WriteLine();

                Console.Write($"Ingrese la nota 1: ");
                estudiantes[i].n1 = double.Parse(Console.ReadLine());
                Console.Write($"Ingrese la nota 2: ");
                estudiantes[i].n2 = double.Parse(Console.ReadLine());
                Console.Write($"Ingrese la nota 3: ");
                estudiantes[i].n3 = double.Parse(Console.ReadLine());
                Console.Write($"Ingrese la nota 4: ");
                estudiantes[i].n4 = double.Parse(Console.ReadLine());
                Console.WriteLine(); 
                var prom = promedio(estudiantes[i].n1, estudiantes[i].n2, estudiantes[i].n3, estudiantes[i].n4);
                estudiantes[i].promedio = prom;
                if (estudiantes[i].promedio >= 70)
                {
                    estudiantes[i].estado = "Aprobado";
                }
                else
                {
                    estudiantes[i].estado = "Reprobado";
                }
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Estudiante \tNota1 \tNota2 \tNota3 \tNota4 \tPromedio \tEstado");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine(estudiantes[i].nombre + "\t\t" + estudiantes[i].n1
                    + "\t" + estudiantes[i].n2 + "\t" + estudiantes[i].n3 + "\t" + estudiantes[i].n4 + "\t" + estudiantes[i].promedio +
                    "\t\t" + estudiantes[i].estado);
            }

        }

        static double promedio(double n1, double n2, double n3, double n4)
        {
            double prom = (n1 + n2 + n3 + n4) / 4.0;
            return prom;

        }
    }

    public class Estudiantes
    {
        public string nombre { get; set; }
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double n3 { get; set; }
        public double n4 { get; set; }
        public double promedio { get; set; }
        public string estado { get; set; }   
    }
}