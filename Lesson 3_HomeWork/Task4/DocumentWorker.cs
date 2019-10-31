using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine(" - Документ открыт");
        }
        public void EditDocument()
        {
            Console.WriteLine(" - Редактирование документа доступно в версии Про");
        }
        public void SaveDocument()
        {
            Console.WriteLine(" - Сохранение документа доступно в версии Про");
        }
    }
}
