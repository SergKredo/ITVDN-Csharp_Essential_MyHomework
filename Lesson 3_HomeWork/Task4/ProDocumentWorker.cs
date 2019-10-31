using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ProDocumentWorker: DocumentWorker
    {
        string proNumber = "123456";
        public string ProNumber
        {
            get;
        }
        public ProDocumentWorker()
        {
            ProNumber = proNumber; 
        }

        public void EditDocument()
        {
            Console.WriteLine(" - Документ отредактирован");
        }
        public void SaveDocument()
        {
            Console.WriteLine(" - Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
