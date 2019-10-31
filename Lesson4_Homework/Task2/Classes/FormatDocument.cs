using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class FormatDocument
    {
        AbstractHandler dOCHandler = new DOCHandler();
        AbstractHandler tXTHandler = new TXTHandler();
        AbstractHandler xMLHandler = new XMLHandler();
        public FormatDocument(string format, string functional)
        {
            if (this.dOCHandler.TypeDocument == format)
            {
                this.dOCHandler.Functional = functional;
                if (this.dOCHandler.Functional == "OPEN")
                {
                    this.dOCHandler.Open();
                }
                else if (this.dOCHandler.Functional == "CHANGE")
                {
                    this.dOCHandler.Change();
                }
                else if (this.dOCHandler.Functional == "SAVE")
                {
                    this.dOCHandler.Save();
                }
                else if (this.dOCHandler.Functional == "CREATE")
                {
                    this.dOCHandler.Create();
                }
            }
            if (this.tXTHandler.TypeDocument == format)
            {
                this.tXTHandler.Functional = functional;
                if (this.tXTHandler.Functional == "OPEN")
                {
                    this.tXTHandler.Open();
                }
                else if (this.tXTHandler.Functional == "CHANGE")
                {
                    this.tXTHandler.Change();
                }
                else if (this.tXTHandler.Functional == "SAVE")
                {
                    this.tXTHandler.Save();
                }
                else if (this.tXTHandler.Functional == "CREATE")
                {
                    this.tXTHandler.Create();
                }
            }
            if (this.xMLHandler.TypeDocument == format)
            {
                this.xMLHandler.Functional = functional;
                if (this.xMLHandler.Functional == "OPEN")
                {
                    this.xMLHandler.Open();
                }
                else if (this.xMLHandler.Functional == "CHANGE")
                {
                    this.xMLHandler.Change();
                }
                else if (this.xMLHandler.Functional == "SAVE")
                {
                    this.xMLHandler.Save();
                }
                else if (this.xMLHandler.Functional == "CREATE")
                {
                    this.xMLHandler.Create();
                }
            }
            else
            {
                
                if (string.IsNullOrEmpty(format) && string.IsNullOrEmpty(functional))
                {
                    Console.WriteLine("Вы не ввели или выбрали неправильный тип и функционал документа!" + "\nПопробуйте пожалуйста заново выбрать правильный тип документа или ввести нужный функционал!");
                }
                if (string.IsNullOrEmpty(format) && functional != null && functional != "")
                {
                    Console.WriteLine("Вы не ввели или выбрали неправильный тип документа!"+"\nПопробуйте пожалуйста заново выбрать правильный тип документа!");
                }
                if (string.IsNullOrEmpty(functional) && format != null && format != "")
                {
                    Console.WriteLine("Вы не ввели или выбрали неправильный функционал документа!" + "\nПопробуйте пожалуйста заново ввести нужный функционал документа!");
                }
            }
        }
    }

}

