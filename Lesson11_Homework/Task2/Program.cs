using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность
использования его экземпляра для создания парка машин. Минимально требуемый интерфейс
взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и
года ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство
только для чтения для получения общего количества элементов.
Создайте метод удаления всех машин автопарка.*/
    class CarCollection<T, U>
    {
        List<T> listCarName = new List<T>();
        List<U> listCarDate = new List<U>();
        public void AddCar(T nameCar, U dateProduce)
        {
            listCarName.Add(nameCar);
            listCarDate.Add(dateProduce);
        }

        public string this[int index]
        {
            get
            {
                return listCarName[index].ToString()+"-"+listCarDate[index].ToString();
            }
        }
        public int Count
        {
            get 
            {
                return listCarName.Count;
            }
        }
        public void Removal()
        {
            listCarName.Clear();
            listCarDate.Clear();
        }
 
    }


    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<string, int> carCollection = new CarCollection<string, int>();
            carCollection.AddCar("Honda", 2019);
            carCollection.AddCar("Mazeratti", 2018);
            carCollection.AddCar("Lada", 1985);
            carCollection.AddCar("Mersedes", 2015);
            carCollection.AddCar("Tesla", 2017);
            carCollection.AddCar("Opel", 1987);

            for (int i = 0; i < carCollection.Count; i++)
            { 
            Console.WriteLine("[{0}]: "+carCollection[i], i);          
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Number of cars added to the collection: " + carCollection.Count);
            carCollection.Removal();
            Console.WriteLine("Number of cars after removal: "+ carCollection.Count);

            Console.ReadKey();

            
        }
    }
}
