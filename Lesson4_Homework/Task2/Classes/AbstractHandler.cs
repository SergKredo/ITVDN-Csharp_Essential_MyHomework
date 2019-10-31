using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class AbstractHandler
    {
        abstract public string TypeDocument
            { get; set; }
        abstract public string Functional
        { get; set; }
        abstract public void Open();
        abstract public void Create();
        abstract public void Change();
        abstract public void Save();
    }
}
