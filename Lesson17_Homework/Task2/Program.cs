using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application
Представьте, что вы пишите приложение для Автостанции и вам необходимо создать простую
коллекцию автомобилей со следующими данными: Марка автомобиля, модель, год выпуска, цвет. А
также вторую коллекцию с моделью автомобиля, именем покупателя и его номером телефона.
Используя простейший LINQ запрос, выведите на экран информацию о покупателе одного из
автомобилей и полную характеристику приобретенной ними модели.*/

    struct Car   // Объявление структуры типа Car, которая формирует основные данные о машинах
    {
        public string CarModel { get; set; }  // Автосвойство, которое определяет модель машины
        public string CarBrand { get; set; }   // Автосвойство, которое определяет марку машины
        public DateTime YearOfIssue { get; set; }  // Автосвойство, которое определяет год производства машины
        public string ColorCar { get; set; }  // Автосвойство, которое определяет цвет машины

        public Car(string carModel, string carBrand, string yearOfIssue, string colorCar)  // Пользовательский конструктор. Инициализация свойств структуры
        {
            this.CarModel = carModel;
            this.CarBrand = carBrand;
            this.YearOfIssue = DateTime.Parse(yearOfIssue);
            this.ColorCar = colorCar;
        }
    }

    struct Customer  // Объявление структуры типа Customer, которая формирует основные данные о покупателе данных машин
    {
        public string CarModel { get; set; }  // Автосвойство, которое определяет модель машины
        public string NameCustomer { get; set; }  // Автосвойство, которое определяет имя покупателя машины
        public int PhoneNumber { get; set; }  // Автосвойство, которое определяет номер телефона покупателя

        public Customer(string carModel, string nameCustomer, int phoneNumber)  // Пользовательский конструктор
        {
            this.CarModel = carModel;
            this.NameCustomer = nameCustomer;
            this.PhoneNumber = phoneNumber;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var collectionCar = new List<Car>   // Создание неявнотипизированной переменной, которая хранит в себе ссылку на коллекцию машин
                                {
                                                //В блоке инициализатора конструктора коллекции определяем количество экземпляров машин с заданными параметрами свойств машин
                                    new Car("X5","BMW","1/12/2008", "gray"),
                                    new Car("Divo","Bugatti", "20/4/2019","blue"),
                                    new Car("C1","Citroen", "14/2/2005", "red"), 
                                    new Car("456","Ferrari", "1/3/1992", "black"),
                                    new Car("125T","Honda", "28/8/1982", "yellow"),
                                    new Car("H3","Hummer", "14/2/2005", "black"),
                                    new Car("QX30","Infiniti", "30/4/2006", "white")
                                };

            var collectionCustomer = new List<Customer>    // Создание неявнотипизированной переменной, которая хранит в себе ссылку на коллекцию покупателей машин
                                {
                                                           //В блоке инициализатора конструктора коллекции определяем количество экземпляров покупателей с заданными параметрами свойств покупателя
                                    new Customer("X5","Piter", 0687770212),
                                    new Customer("Divo","Garry", 0508051415),
                                    new Customer("C1","Konstantin", 0673251578),
                                    new Customer("456","Emilia", 0689876514),
                                    new Customer("125T","Maria", 0631526352),
                                    new Customer("H3", "Donald", 0989851232),
                                    new Customer("QX30", "Barak", 0951452565)
                                };

            // Язык LINQ. Выражение запроса.
            // Получение списка имен всех покупателей машин с полной характеристикой приобретенной ими моделей машин
            var query = from car in collectionCar   // query - Переменная запроса. from - задает источник данных и объявляет переменную диапазона car.
                        join cust in collectionCustomer  //join – используется для связывания элементов из различных коллекций.
                        on car.CarModel equals cust.CarModel   //join сравнивает указанные ключи напредмет равенства при помощи специального ключевого слова equals.
                        orderby car.YearOfIssue, cust.NameCustomer  //orderby - сортирует результаты в порядке возрастания или убывания
                        select new //Операция проекции для вывода коллекции анонимных типов
                        {
                            CarModel = car.CarModel,
                            CarBrand = car.CarBrand,
                            YearOfIssue = car.YearOfIssue,
                            ColorCar = car.ColorCar,
                            NameCustomer = cust.NameCustomer,
                            PhoneNumber = cust.PhoneNumber
                        };

            foreach (var element in query)  //Перебор всех элементов коллекции с помощью оператора foreach. Элементы коллекции извлекаются поочередно из коллекции и присваиваются переменной итерации element
            {
                Console.WriteLine("- Brand: {0},   \t Model: {1},     \t Year: {2},   \t Color: {3},     \t Name: {4},   \t Phone: {5};", element.CarBrand, element.CarModel, element.YearOfIssue.Year, element.ColorCar, element.NameCustomer, element.PhoneNumber);

            }
            Console.ReadKey();
        }
    }
}
