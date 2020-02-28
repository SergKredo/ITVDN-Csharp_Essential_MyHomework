using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Presenter
    {
        private Model model;
        private Program view;

        public Presenter()
        {
            model = new Model();
            //this.view = view;       // Класс Program (view) уже проинициализирован, поэтотму данное выражение можно опустить
            Program.TextAdd += Program_TextAdd;
        }

        private void Program_TextAdd(string str)
        {
            Console.WriteLine(model.Logic(str));
        }
    }
}