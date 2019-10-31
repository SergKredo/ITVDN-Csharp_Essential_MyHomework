using System;

namespace AdditionalTask
{
    struct Notebook
    {
        string model;
        string developer;
        double cost;
        public string Model
        {
            get
            {
                if (string.IsNullOrEmpty(model))
                {
                    return "Вы не ввели название модели!";
                }
                else
                {
                    return model;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(model))
                {
                    Console.WriteLine("Вы не ввели название модели!");
                }
                else
                {
                    model = value;
                }
            }
        }
        public string Developer
        {
            get
            {
                if (string.IsNullOrEmpty(developer))
                {
                    return "Вы не ввели название разработчика!";
                }
                else
                {
                    return developer;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(developer))
                {
                    Console.WriteLine("Вы не ввели название разработчика!");
                }
                else
                {
                    developer = value;
                }
            }
        }
        public double Cost
        {
            get
            {
                if (cost <= 0 || string.IsNullOrEmpty(Convert.ToString(cost)))
                {
                    Console.WriteLine("Стоимость товара не может быть меньше либо равна нулю!");
                    return 0;
                }
                else
                {
                    return cost;
                }
            }
            set
            {
                if (cost <= 0 || string.IsNullOrEmpty(Convert.ToString(cost)))
                {
                    Console.WriteLine("Вы не ввели стоимость товара!");
                }
                else
                {
                    cost = value;
                }
            }
        }
        public Notebook(string model, string developer, double cost)
        {
            this.model = model;
            this.developer = developer;
            this.cost = cost;
        }

        public void Show()
        {
            Console.WriteLine("model: " + Model);
            Console.WriteLine("developer: " + Developer);
            Console.WriteLine("cost: " + Cost);
        }

    }
}
