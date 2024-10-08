public class Program
{
    private static void Main(string[] args)
    {
        bool continuar = true;
        int estudiantesGanados = 0;
        int estudiantesPerdidos = 0;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Sistema de Evaluación de Notas de Estudiantes");

            int numEstudiantes = 0;
            while (numEstudiantes <= 0)
            {
                Console.WriteLine("Ingrese el número de estudiantes:");
                numEstudiantes = Convert.ToInt32(Console.ReadLine());
                if (numEstudiantes <= 0)
                {
                    Console.WriteLine("Número de estudiantes inválido. Por favor, ingrese un número mayor que 0:");
                }
            }

            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.WriteLine($"Ingrese las notas del estudiante {i + 1} (separadas por espacios):");
                string[] notasStr = Console.ReadLine().Split(' ');
                double[] notas = new double[notasStr.Length];

                for (int j = 0; j < notasStr.Length; j++)
                {
                    notas[j] = Convert.ToDouble(notasStr[j]);
                }

                double promedio = CalcularPromedio(notas);
                string categoria = ObtenerCategoria(promedio);

                Console.WriteLine($"Estudiante {i + 1}: Promedio = {promedio:F2}, Categoría = {categoria}");

                if (promedio >= 4.0)
                {
                    estudiantesGanados++;
                }
                else
                {
                    estudiantesPerdidos++;
                }
            }

            Console.WriteLine($"Estudiantes ganados: {estudiantesGanados}");
            Console.WriteLine($"Estudiantes perdidos: {estudiantesPerdidos}");

            Console.WriteLine("¿Desea ingresar otro grupo de estudiantes? (s/n):");
            char respuesta = Console.ReadKey().KeyChar;
            continuar = respuesta == 's' || respuesta == 'S';
            Console.WriteLine();

            estudiantesGanados = 0;
            estudiantesPerdidos = 0;
        }
    }
