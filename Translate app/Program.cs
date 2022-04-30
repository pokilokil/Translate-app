using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Xml;
namespace Lesson2

{

    internal class Program

    {
        static Dictionary<string,string> data = new Dictionary<string,string>();   

        static string WordTranslate(string Translated, string ToTranslate, int balls)
        {
            Console.WriteLine("Напишите перевод " + ToTranslate);
            string word0;
            word0 = Console.ReadLine();



            while (word0 != Translated)
            {


                Console.WriteLine("Это не правильный ответ. Попробуйте снова");
                word0 = Console.ReadLine();

            }
            //Создать генератор цикла начисления баллов. 
            Console.WriteLine("Это правильный ответ, вы получаете 5 баллов");
            Console.WriteLine("Ваше количество баллов "+ balls);
            return word0;
        }

        static int ballsTotal = 0;
        static string WordTranslate(string Translated, string ToTranslate)
        {
            Console.WriteLine("Напишите перевод за 2 попытки " + ToTranslate);
            string word0;
            word0 = Console.ReadLine();
            
            int trycounter = 0;
            string trTl = Translated.ToLower();
            string wtl = word0.ToLower();

            while (wtl != trTl && trycounter < 2)
            {


                Console.WriteLine("Это не правильный ответ. Попробуйте снова");
                word0 = Console.ReadLine();
                wtl = word0.ToLower();
                trycounter++;

            }
            if (word0 == Translated)
            { 
                //Создать генератор цикла начисления баллов. 
                Console.WriteLine("Это правильный ответ, вы получаете 5 баллов");
                ballsTotal = ballsTotal + 5;
            }
            else
            {
                Console.WriteLine("2 попытки истекло, вы НЕ получаете 5 баллов");
            }
            Console.WriteLine("Ваше количество баллов " + ballsTotal);
            return word0;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Добро подаловать в игру ПЕРЕВОДЧИК. Ваша задача угадать все слова и набрать 100 баллов");
            data.Add("привет", "Hello");
            data.Add("собака", "Dog");
            data.Add("кот", "Cat");

            foreach (var keyValuePair in data)
            {
                WordTranslate(keyValuePair.Key, keyValuePair.Value);
                if (ballsTotal == 100) break;
            }
            WordTranslate("привет", "Hello", 5);
            WordTranslate("собака", "Dog", 10);
            WordTranslate("кот", "Cat", 15);
            WordTranslate("дверь", "Door", 20);
            WordTranslate("книга", "Book", 25);
            WordTranslate("улица", "Street", 30);
            WordTranslate("рука", "Hand", 35);
            WordTranslate("рыба", "Fish", 40);
            WordTranslate("волосы", "Hair", 45);
            WordTranslate("лошадь", "Horse", 50);
            WordTranslate("чай", "Tea", 55);
            WordTranslate("молоко", "Milk", 60);
            WordTranslate("яблоко", "Apple", 65);
            WordTranslate("сыр", "Cheese", 70);
            WordTranslate("ананас", "Pineapple", 75);
            WordTranslate("кухня", "Kitchen", 80);
            WordTranslate("зеркало", "Mirror", 85);
            WordTranslate("январь", "January", 90);
            WordTranslate("дождь", "Rain", 95);
            WordTranslate("лето", "Summer", 100);

            Console.WriteLine("Поздравляем, вы прошли игру!!!!!!!!!!!!!!!!!!");
            Console.ReadKey();


        }
    }
}