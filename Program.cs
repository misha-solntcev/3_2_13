using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 13
Дана строка.Словом текста считается любая последовательность букв латинского
алфавита; между соседними словами - не менее одного пробела, за последним словом -
точка. Найти и сохранить в строке те слова, которые начинаются с прописной буквы. Все
остальные слова удалить.*/

namespace _3_2_13
{
    /* Решаем с использованием ООП. 
    Создаем класс Text.
    В этом классе создаем публичную переменную text и метод FindUpper().
    В этом методе сперва объявляется массив символов sep, которые будут
    являться разделителями текста на слова. Далее создаем массив слов myWords.
    И в цикле проходим по каждому слову, и если первая буква слова большая,
    добавляем это слово в строку result.
    */
    class Text
    {
        public string Stroka
            { get; set; }        
        
        public string FindUppper()
        {
            char[] sep = { ' ', '.' };
            string[] myWords = Stroka.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            string result = "";
            for (int i = 0; i < myWords.Length; i++)
            {
                if (Char.IsUpper(myWords[i][0]))
                    result += myWords[i] + " ";
            }
            return result;            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // На основе класса Text создаем объект myString.
            Text myString = new Text();
            // Присваиваем полю объекта myString.text - значение.
            myString.Stroka = "Это ПриМер текста Jxtym прОстой.";
            // Выводим на экран результат работы метода FindUppper().         
            Console.WriteLine(myString.FindUppper());
            Console.ReadKey();
        }
    }
}
