namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaracion de variables 

            int number;
            string name;

            // Inicializacion de variables 

            number = 10;
            name = "Pedro JImenez";

            // Tipo de variables implicitos 
            var isActive = true;
            var pi = 3.14;
            var city = "Shibuya";

            Console.WriteLine($"Number: {number}, Name: {name}");
        }
    }
}
