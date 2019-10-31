using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ExpertDocumentWorker: ProDocumentWorker
    {
        string expNumber = "654321";
        public string ExpNumber
        {
            get;
        }
        public ExpertDocumentWorker()
        {
            ExpNumber = expNumber;
        }

        public void SaveDocument()
        {
            Console.WriteLine(" - Документ сохранен в новом формате");
        }
    }
}
