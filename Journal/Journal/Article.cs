using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    internal class Article : Book
    {
        public int doi;
        string date;
        public string c_j;

        public Article(int id, string title, string author, string publisher, int quantity, int doi, string date, string c_j)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.quantity = quantity;
            this.doi = doi;
            this.date = date;
            this.c_j = c_j;
        }
        public string getinfo()
        {
            string articleoutput = id.ToString() + "\t" + title + "\t" + author + "\t" + doi.ToString() + "\t" + quantity.ToString() + "\t" + c_j;
            return articleoutput;
        }
    }

}
