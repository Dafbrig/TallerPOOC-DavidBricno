// See https://aka.ms/new-console-template for more information
using Calendar;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

static class Program{
    private static void Modification() {
        int option;
        string name;
        DateTime startDate;
        DateTime endDate;

        //Creacion o utilizacion de las clases Day y Calendar
        Day day = new Day();
        Calenda calendar = new Calenda();

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
                    Calenda newEvent= new Calenda(name, startDate, endDate);
                    calendar.AddEvent(newEvent);
                    break;
                case 2:
                    //Muestra los eventos por dia
                    ShowEvent(day.showEvents(calendar.ShowEvent()));
                    break;
                case 3:
                    DateTime today = DateTime.Now;
                    ShowDay(calendar.FilterDay(today.Month, today.Year));
                    break;

                default:
                    Console.WriteLine("Dato incorrecto");
                break;

            }

        } while (option > 0 && option < 4);
    }
    public static void ShowDay(List<Event> calendar)
    {
        Console.WriteLine("Eventos: ");
        foreach (Event e in calendar)
        {
            Console.WriteLine("El evento {0} esta agendado para el {1} del mes {2}. ", e.Name, e.StartDate.Day, e.StartDate.Month);
            Console.WriteLine("_____________________________________________________");
        }
    }
    public static void ShowEvent(List<Event> events)
    {
        Console.WriteLine("Eventos del dia: ");

        foreach (Event e in events)
        {
            Console.WriteLine("El evento {0}", e.Name);
            Console.WriteLine("Inicia el {0}", e.StartDate.Date);
            Console.WriteLine("Finaliza el {0}", e.EndDate.Date);
        }
    }

    public static void Main(string[] args){
        try
        {
            Modification();
        }
        catch (Exception e)
        {
            Console.WriteLine("Ingrese datos Validos");
        }
    }
}