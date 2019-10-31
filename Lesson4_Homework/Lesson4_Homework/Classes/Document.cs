using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Homework
{
    class Document
    {
        AbstractParts abs_footer = new Footer();
        AbstractParts abs_body = new Body();
        AbstractParts abs_title = new Title();
        public Document(string title, string footer, string body)
        {
            abs_footer.Content = footer;
            abs_body.Content = body;
            abs_title.Content = title;
        }
        public void Show()
        {
            abs_title.Show();
            abs_footer.Show();
            abs_body.Show();
        }
    }
}

