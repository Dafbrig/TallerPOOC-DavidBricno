// See https://aka.ms/new-console-template for more information
using Calendar;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

static class Program{
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    public static void Main(string[] args){
        //Nombre del evento
        string name;
        //Fecha inicio del calendario
        DateTime startDate;
        DateTime endDate;
        int daystart;
        int dayend;
        Console.WriteLine("Ingrese dia inicio:");
        startDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese dia final:");
        endDate = DateTime.Parse(Console.ReadLine());
        //Se toma los dias por separado para recorrer un vector
        daystart = startDate.Day;
        dayend = endDate.Day;


    }
}