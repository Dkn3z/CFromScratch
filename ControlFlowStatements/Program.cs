namespace ControlFlowStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfElseExample();
            SwitchStatementExample();
        }

        private static void IfElseExample()
        {
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("El numero es mayor a 10");
            }
            else if (number == 0)
            {
                Console.WriteLine("el numero es exactamente 10");
            }
            else
            {
                Console.WriteLine("el numero es menor que 10");
            }
        }

        private static void SwitchStatementExample()
        {
            int day = 3;
            string dayname;
            switch (day)
            {
                case 1:
                    dayname = "Lunes";
                    break;

                case 2:
                    dayname = "Martes";
                    break;

                case 3:
                    dayname = "Miercoles";
                    break;
                case 4:
                    dayname = "Jueves";
                    break;
                case 5:
                    dayname = "Viernes";
                    break;
                case 6:
                    dayname = "Sabado";
                    break;
                case 7:
                    dayname = "Domiengo";
                    break;
                default:
                    dayname = "dia invalido";
                    break;
            }
            Console.WriteLine($"Dia {day} is {dayname}");
        }
    }
}