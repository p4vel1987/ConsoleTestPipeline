using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Auto a = new Auto($"marca {i}", $"tipo {i}");
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(a));
            }
        }
    }

    public class Auto
    {
        public string Marca { get; set; }
        public string Modello { get; set; }

        public Auto(string marca, string modello)
        {
            Marca = marca;
            Modello = modello;
        }
    }
}
