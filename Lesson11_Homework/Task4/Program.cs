using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Задание 4
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его
экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.*/
    class MyArrayList<T>
    {
        ArrayList arrayList = new ArrayList();   // Экземпляр класса ArrayList для создания коллекции
        public T Add(T addElement)  // Метод для добавления нового элемента в коллекцию
        {
            object addelement= arrayList.Add(addElement);
            T element = (T)addelement;
            return element;
        }

        public T this[int index]      // Метод-индексатор для вывода в консоли заданного элемента коллекции
        {
            get
            {
                return (T)arrayList[index];
            }
        }

        public void ShowAllElementCollection()   // Метод для вывода в консоли всех элементов коллекции
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
                
            }
            if (arrayList.Count == 0)
            {
                Console.WriteLine("Collection is empty!");
            }
        }

        public void ClearAllElement()   // Метод для удаления всех элементов коллекции
        {
            arrayList.Clear();
            ShowAllElementCollection();
        }
        public void ClearAllElement(int index)   // Метод для удаления элементов коллекции начиная с заданного индекса коллекции
        {
            if (!(index < 0 || index > arrayList.Count))
            {
                arrayList.RemoveRange(index, arrayList.Count - index);
                ShowAllElementCollection();
            }
            else
            {
                Console.WriteLine("You entered an invalid collection index!");
            }
        }

        public void ShowCapacityCollection()   // Метод для проверки емкости коллекции
        {
            Console.WriteLine("Collection capacity is equal: "+ arrayList.Capacity); 
        }


        public void ShowCapacityCollectionAfterTrim()   // Метод для проверки емкости коллекции
        {
            Console.WriteLine("Collection capacity up: " + arrayList.Capacity);
            arrayList.TrimToSize();
            Console.WriteLine("Collection capacity after: " + arrayList.Capacity);

        }
        public int MyCapacity
        {
            get
            {
                return arrayList.Capacity;
            }
            set
            {
                arrayList.Capacity = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList<int> myArrayList = new MyArrayList<int>();
            myArrayList.Add(12);
            myArrayList.Add(10);
            myArrayList.Add(2);
            myArrayList.Add(12);
            myArrayList.Add(10);
            myArrayList.Add(2);

            myArrayList.ShowAllElementCollection();
            myArrayList.ClearAllElement();
            myArrayList.ClearAllElement(2);
            myArrayList.ShowCapacityCollection();
            myArrayList.ShowCapacityCollectionAfterTrim();
            myArrayList.Add(5);
            myArrayList.ShowCapacityCollection();
            Console.ReadKey();
        }
    }
}
