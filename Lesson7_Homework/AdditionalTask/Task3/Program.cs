using System;

namespace Task3
{
    /*Задание 3
Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
В классе Program создайте два метода:
- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра
myClass значение «изменено».
- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра
myStruct значение «изменено».
Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры
структуры и класса. Измените, значения полей экземпляров на «не изменено», а затем вызовите методы
ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. Проанализируйте
полученные результаты.*/
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void StructTakerTwo(ref MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "не изменено";
            myStruct.change = "не изменено";

            //В классах происходит передача параметров по ссылке, а в структурах по значению (создается отдельная копия аргумента), которая не изменяет первоначальную входящую переменную
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine("Вызов значения поля на экземпляре класса: " + myClass.change);
            Console.WriteLine("Вызов значения поля на экземпляре структуры: " + myStruct.change);
            Console.WriteLine(new string('-', 50));
            // Для того, чтобы изменить в структуре значение поля "change" нужно при вызове метода StructTaker() ко входящему параметру добавить ключевое слово ref (для передачи аргумента по ссылке) либо out(для передачи аргумента по ссылке и его выводе из метода) 
            ClassTaker(myClass);
            StructTakerTwo(ref myStruct);
            Console.WriteLine("Вызов значения поля на экземпляре класса: " + myClass.change);
            Console.WriteLine("Вызов значения поля на экземпляре структуры с параметром ref: " + myStruct.change);

            Console.ReadKey();


        }
    }
}
