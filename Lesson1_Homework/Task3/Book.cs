using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Book
    {
        Title titlebook;
        Content contentbook;
        Author authorbook;

        void InitializeDocument()
        {
            this.titlebook = new Title();
            this.contentbook = new Content();
            this.authorbook = new Author();
        }

        public Book(string title)
        {
            InitializeDocument();
            this.titlebook.TitleBook = title;
        }

        public void Show()
        {
            this.titlebook.Show();
            this.contentbook.Show();
            this.authorbook.Show();
        }

        public string ContentBook
        {
            set
            {
                this.contentbook.ContentBook = value;
            }
        }
        public string AuthorBook
        {
            set
            {
                this.authorbook.NameAuthor = value;
            }
        }

    }
}
