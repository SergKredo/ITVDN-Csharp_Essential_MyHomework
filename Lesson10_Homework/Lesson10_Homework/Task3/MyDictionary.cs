using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyDictionary<TKey, TValue>
    {
        object[] keys = new object[20];    // Объявление одномерного массива указателя места заполнения, в котором хранится список всех ключевых слов
        object[] values = new object[20];  // Объявление одномерного массива указателя места заполнения, в котором хранится список значений всех ключевых слов
        int count = 0;  // Счетчик для подсчета количества заполненных пар в списке

        public void Add(TKey tKey, TValue tValue)  // Метод для добавления пары <ключевое слово-значение> в пользовательский список
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i] == null)
                {
                    keys[i] = tKey;
                    values[i] = tValue;
                    break;
                }
            }
        }
        

        public object this[int index]     // Индексатор для определения ключевого слова и его значения по номеру списка
        {
            get
            {
                if (keys[index] != null)
                {
                    return string.Format("[{0}]: " + keys[index].ToString() + " - " + values[index].ToString() + ";", index);
                }
                else
                {
                    return string.Format("Данный номер списка не имеет значения!");
                }
            }
        }

        public int Count         // Свойство для определения количества заполненных пар <ключевое слово-значение> в списке
        {
            get 
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i] != null)
                    {
                        ++count;
                    }
                    else
                    {
                        break;
                    }
                }
                return count;
            }
        }
}
    }

