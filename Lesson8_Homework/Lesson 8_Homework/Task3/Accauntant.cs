using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Accauntant
    {
        Random random  = new Random();  // Генератор псевдослучайных чисел
        int randonHours;
        public enum Post   // Перечисление именованых констант должностей в компании
        {
            Trainee,
            JuniorEmployee,
            MiddleEmployee,
            SeniorEmployee
        }
        string[,] nameEmployee = new string[10,3];
        private void DefinitionMassive()   // Метод для инициализации переменных двумерного массива
        {
            nameEmployee[0, 0] = "Sergey";                                     nameEmployee[5, 0] = "Hleb";
            nameEmployee[0, 1] = (Post.Trainee).ToString();                    nameEmployee[5, 1] = (Post.MiddleEmployee).ToString();
            nameEmployee[0, 2] = "50";                                         nameEmployee[5, 2] = "140";
            nameEmployee[1, 0] = "Ivan";                                       nameEmployee[6, 0] = "Tomara";
            nameEmployee[1, 1] = (Post.SeniorEmployee).ToString();             nameEmployee[6, 1] = (Post.Trainee).ToString();
            nameEmployee[1, 2] = "140";                                        nameEmployee[6, 2] = "30";
            nameEmployee[2, 0] = "Dmitrii";                                    nameEmployee[7, 0] = "Yulia";
            nameEmployee[2, 1] = (Post.MiddleEmployee).ToString();             nameEmployee[7, 1] = (Post.SeniorEmployee).ToString();
            nameEmployee[2, 2] = "150";                                        nameEmployee[7, 2] = "150";
            nameEmployee[3, 0] = "Roman";                                      nameEmployee[8, 0] = "Sveta";
            nameEmployee[3, 1] = (Post.Trainee).ToString();                    nameEmployee[8, 1] = (Post.MiddleEmployee).ToString();
            nameEmployee[3, 2] = "70";                                         nameEmployee[8, 2] = "100";
            nameEmployee[4, 0] = "Denis";                                      nameEmployee[9, 0] = "Konstantin";
            nameEmployee[4, 1] = (Post.JuniorEmployee).ToString();             nameEmployee[9, 1] = (Post.MiddleEmployee).ToString();
            nameEmployee[4, 2] = "100";                                        nameEmployee[9, 2] = "135";
        }

        public bool AskForBonus(Post worker, int hours)   // Метод, который позволяет рассчитать положено ли сотруднику премия или нет
        {
            bool overCoustMoney = false;
            DefinitionMassive();
            for (int i = 0; i < nameEmployee.GetLength(0); i++)
            {
                for (int j = 0; j < nameEmployee.GetLength(1); j++)
                {
                        if (nameEmployee[i,j] == worker.ToString())
                        {
                            randonHours = random.Next(hours-30, hours+20);
                            nameEmployee[i, 2] = randonHours.ToString();
                            Console.Write(nameEmployee[i,0].PadLeft(25)+" [{0} hours]: ", nameEmployee[i,2]);
                            overCoustMoney = (Convert.ToInt32(nameEmployee[i,2]) > hours)? true : false;
                            Console.Write(overCoustMoney+"\n");
                        }
                }
            }
            Console.WriteLine(new string('-', 50));
            return overCoustMoney;
        }

        public void Sorting()   // Метод для сортировки и вывода в консоли всех сотрудников компании по должностям и их рабочего времени
        {
            for (Accauntant.Post employee = Accauntant.Post.Trainee; employee <= Accauntant.Post.SeniorEmployee; employee++)
            {
                switch (employee)
                {
                    case Accauntant.Post.Trainee:
                        {
                            Accauntant accauntantOne = new Accauntant();
                            Console.WriteLine(employee+": (normal - 50 hours)\n");
                            accauntantOne.AskForBonus(employee, 50);
                            break;
                        }
                    case Accauntant.Post.JuniorEmployee:
                        {
                            Accauntant accauntantTwo = new Accauntant();
                            Console.WriteLine(employee + ": (normal - 80 hours)\n");
                            accauntantTwo.AskForBonus(employee, 80);
                            break;
                        }
                    case Accauntant.Post.MiddleEmployee:
                        {
                            Accauntant accauntantThree = new Accauntant();
                            Console.WriteLine(employee + ": (normal - 120 hours)\n");
                            accauntantThree.AskForBonus(employee, 120);
                            break;
                        }
                    case Accauntant.Post.SeniorEmployee:
                        {
                            Accauntant accauntantFive = new Accauntant();
                            Console.WriteLine(employee + ": (normal - 120 hours)\n");
                            accauntantFive.AskForBonus(employee, 120);
                            break;
                        }
                }
            }
        }
    }
}
