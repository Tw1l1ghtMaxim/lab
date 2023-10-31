using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Authentication_
{
    internal class User
    {
        public string Login;
        public string Password;
        public bool StatusAuth;
        /* Описать поля Login, Password, StatusAuth, 
         * реализовать метод Auth для проверки логина и пароля */
        public void Auth1()
        {
            while (StatusAuth == false)
            {
                Console.Write("Введите логин: ");
                Login = Convert.ToString(Console.ReadLine());
                Console.Write("Введите пароль: ");
                Password = Convert.ToString(Console.ReadLine());
                Auth();
            }
        }
        public bool Auth()
        {
            string path = "userpas.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                        try
                        {
                            if (Login == parts[0] && Password == parts[1])
                            {
                                    Console.WriteLine("Авторизация прошла успешно!");
                                    StatusAuth = true;
                                    break;
                            }
                            else
                            {
                                Console.WriteLine("Неправильный логин/пароль!");
                                StatusAuth = false;
                                break;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Вы ввели некоректный формат логина/пароля!");
                            return false;
                        }
                }
                return StatusAuth;
            }
        }
    }
    
}
