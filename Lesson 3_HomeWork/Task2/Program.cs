using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
        /*Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс, представляющий учебный класс ClassRoom.
    Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
    Write(), void Relax().
    Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса
    Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
    Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
    Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
    Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
    писать, отдыхать.*/
    class Program
    {
        static void Main(string[] args)
        {
            string pupilOne = "Mark";
            string pupilTwo = "Piter";
            string pupilThree = "Zoe";
            string pupilFour = "Judit";

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Имена учеников в классе:\n{0},\n{1},\n{2},\n{3}", pupilOne, pupilTwo, pupilThree, pupilFour);

            ClassRoom classRoom = new ClassRoom(new Pupil(pupilOne, pupilTwo, pupilThree, pupilFour), new Pupil(pupilOne, pupilTwo, pupilThree, pupilFour), new Pupil(pupilOne, pupilTwo, pupilThree, pupilFour), new Pupil(pupilOne, pupilTwo, pupilThree, pupilFour));

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Ученики, которые <отлично>:");
            classRoom.ExcelentPupils();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Ученики, которые <хорошо>:");
            classRoom.GoodPupils();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Ученики, которые <плохо>:");
            classRoom.BadPupils();
            Console.WriteLine(new string('-', 30));

            Console.ReadKey();
        }
    }
}
