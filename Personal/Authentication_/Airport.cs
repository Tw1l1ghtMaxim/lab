using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication_
{
    class Airport
    {
        public string FlightNumber; //ноиер рейса
        public string Pynkt; //пункт назначения
        public string Vremz; //время вылета
        public int Mesta; //количество свободных мест
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="nomerReica"></param>
        /// <param name="pynkt"></param>
        /// <param name="vremz"></param>
        /// <param name="mesta"></param>
        public Airport(string nomerReica, string pynkt, string vremz, int mesta)
        {
            this.FlightNumber = nomerReica;
            this.Pynkt = pynkt;
            this.Vremz = vremz;
            this.Mesta = mesta;
        }
        /// <summary>
        /// Ввод города и отправка на поиск нужного рейса
        /// </summary>
        /// <param name="tickets"></param>
        public static void Polet(List<Airport> tickets)
        {
            Console.Write("Введите город куда хотите полететь: ");
            string x = Convert.ToString(Console.ReadLine());
            GetTime(x, tickets);
        }
        /// <summary>
        /// Ввод номера рейса и оправка в метод поиска
        /// </summary>
        /// <param name="tickets"></param>
        public static void SvobodMesta(List<Airport> tickets)
        {
            Console.Write("Введите номер рейса на который ищете свободные места: ");
            string y = Convert.ToString(Console.ReadLine());
            GetMesta(tickets, y);
        }
        /// <summary>
        /// Метод для нахождения нужного рейса
        /// </summary>
        /// <param name="city"></param>
        /// <param name="tickets"></param>
        public static void GetTime(string city, List<Airport> tickets)
        {
            List<Airport> airlinesCity = tickets.FindAll(flight => flight.Pynkt == city);
            if (airlinesCity.Count > 0)
            {
                foreach (Airport flight in airlinesCity)
                {
                    Console.WriteLine($"Номер рейса: {flight.FlightNumber}, Время отправления: {flight.Vremz}");
                }
            }
            else
            {
                Console.WriteLine($"Нету рейсов в {city}");
            }
        }
        /// <summary>
        /// метод нахождения свободных мест
        /// </summary>
        /// <param name="tickets"></param>
        /// <param name="flightNumber"></param>
        public static void GetMesta(List<Airport> tickets, string flightNumber)
        {
            List<Airport> airlinesMesta = tickets.FindAll(flight => flight.FlightNumber == flightNumber);
            if (airlinesMesta.Count > 0)
            {
                foreach (Airport flight in airlinesMesta)
                {
                    Console.WriteLine($"На рейс {flight.FlightNumber} свободных мест {flight.Mesta}");
                }
            }
            else
            {
                Console.WriteLine($"Нету свободных мест на рейс {flightNumber}");
            }
        }
    }
}
