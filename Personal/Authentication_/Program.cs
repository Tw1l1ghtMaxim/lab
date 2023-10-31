using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication_
{
    /// <summary>
    /// Укажите автора программы
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Реализовать пользовательский интерфейс 
             * для работы с объектами по заданию вашего варианта. 
             
            Порядок работы программы:
            1. Вывод меню: Авторизация (выдает сообщение: "логин или пароль неверны", "авторизация успешна")
            2. Работа с вариантом после авторизации

            Создавать экземпляры класса может только пользователь со статусом StatusAuth = True
            */

            Console.WriteLine("Автор программы: Левченко Максим");
            Console.WriteLine("Вариант: 20");
            Console.WriteLine("Аэропорт");

            // Пишем код здесь.
            Console.WriteLine("Для демонстрации программы необходимо авторизоваться"); // слабакам можно обойтись без этого
            User user1 = new User();
            user1.Auth1();
            
            List<Airport> tickets = new List<Airport>(); //лист с рейсами
            tickets.Add(new Airport("12", "Москва", "13:00", 56)); //добавление в лист рейса
            tickets.Add(new Airport("16", "Германия", "16:00", 12));
            tickets.Add(new Airport("18", "Германия", "19:00", 24));
            tickets.Add(new Airport("1", "Латвия", "11:00", 17));
            Airport.Polet(tickets);
            Airport.SvobodMesta(tickets);
            Console.ReadKey();
        }
    }
}
