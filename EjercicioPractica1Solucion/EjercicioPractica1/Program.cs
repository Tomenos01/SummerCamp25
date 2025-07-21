internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Introduce un número del 1 al 7 (0 para salir)");
        
        while (true)
            {
            //int dia = int.Parse(Console.ReadLine());
            var dia = 0;
          
            bool convertido = int.TryParse(Console.ReadLine(), out dia);

                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        break;
                    case 3:
                        Console.WriteLine("Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                    case 0:
                        Console.WriteLine("Hasta luego crak");
                        return;
                    default:
                        Console.WriteLine("Del 1 al 7 dije");
                        break;
                }
            }
        }
    
}