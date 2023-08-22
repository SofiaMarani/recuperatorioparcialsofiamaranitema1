namespace recuperatorioparcialsofiamaranitema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            int ancho;
            double area;
            double areaaltura;
            double areaancho;
            double areabase;
            int contador;
            double diagonal;
            int largo;
            double volumen;
            contador = 0;
            do
            {
                Console.Write("Ingrese la Base: ");
                largo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la Altura: ");
                altura = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el Ancho: ");
                ancho = int.Parse(Console.ReadLine());

                areabase = conseguirbase(largo, ancho);
                areaaltura = conseguiraltura(altura, ancho);
                areaancho = conseguirancho(altura, largo);

                Console.WriteLine("La Base es: " + areabase);
                Console.WriteLine("La Altura es: " + areaaltura);
                Console.WriteLine("El Ancho es: " + areaancho);

                area = 2 * (areabase + areaaltura + areaancho);
                volumen = largo * ancho * altura;
                diagonal = Math.Sqrt(Math.Pow(largo, 2) + Math.Pow(ancho, 2) + Math.Pow(altura, 2));

                Console.WriteLine("El Area es: " + area);
                Console.WriteLine("El Volumen es: " + volumen);
                Console.WriteLine("La Diagonal es: " + diagonal);
                contador = contador + 1;
            } while (!(largo == 0 && altura == 0 && ancho == 0));
            Console.WriteLine("Los Primas ingresados fueron: " + contador);
        }

        private static double conseguirancho(int altura, int largo)
        {
            return altura * largo;
        }

        private static double conseguiraltura(int altura, int ancho)
        {
            return altura * ancho;
        }

        private static double conseguirbase(int largo, int ancho)
        {
            return largo * ancho;
        }
    }
    }
