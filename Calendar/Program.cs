// See https://aka.ms/new-console-template for more information
using Calendar;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

static class Program{
    public Program(){
        try{
            Modification();
        }
        catch(Exception e){
            Console.WriteLine("Ingrese datos Validos");
        }
    }

    private void Modification() {
        int option;
        string name;
        DateTime startDate;
        DateTime endDate;

        //Creacion o utilizacion de las clases Day y Calendar
        Day day = new Day();
        Calendar calendar = new Calendar();

        do{
            Console.WriteLine("0. Ninguna ");
            Console.WriteLine("1. Nuevo evento");
            Console.WriteLine("2. Consultar eventos del dia");
            Console.WriteLine("3. Consultar eventos del mes actual");
            option = int.Parse(Console.ReadLine());
            //Case para la toma de datos o opciones para el usuario
            switch (option){

                case 1:
                    Console.WriteLine("Nombre del evento: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha inicio del evento en AAAA/MM/DD: ");
                    startDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la fecha final del evento en AAAA/MM/DD: ");
                    endDate = DateTime.Parse(Console.ReadLine());

                    //Creacion de evento

                    break;

                case 2:


                    break;
                case 3:

                    break;

                default:
                    Console.WriteLine("Dato incorrecto");
                break;

            }

        } while (option > 0 && option < 4);
    }

    public static void Main(string[] args){
        Program Start = new Program();
    }
}