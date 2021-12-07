using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        List<StudyBook> booklist = new List<StudyBook>();
        List<Article> articlelist = new List<Article>();



        private void addstudybook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(studybookid.Text);
            string title = studybooktitle.Text;
            string author = studybookauthor.Text;
            string publisher = studybookpublisher.Text;
            int quantity = Convert.ToInt32(studybookquantity.Text);
            int isbn = Convert.ToInt32(studybookisbn.Text);
            string genre = studybookgenre.Text;
            StudyBook dummy = new StudyBook(id, title, author, publisher, quantity, isbn, genre);
            booklist.Add(dummy);
            MessageBox.Show("Studybook has been added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(articleid.Text);
            string title = articletitle.Text;
            string author = articleauthor.Text;
            string publisher = articlepublisher.Text;
            int quantity = Convert.ToInt32(articlequantity.Text);
            int doi = Convert.ToInt32(articledoi.Text);
            string date = articledate.Text;
            string c_j = articlecj.Text;
            Article dummy = new Article(id, title, author, publisher, quantity, doi, date, c_j);
            articlelist.Add(dummy);
            MessageBox.Show("Article has been added");
        }

        private void bookborrow_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(borrowbookid.Text);
            foreach(StudyBook book in booklist)
                if(book.id == bookid)
                {
                    if(book.quantity <1 )
                    {
                        MessageBox.Show("Not in stock");
                        break;
                    }
                    book.quantity -= 1;
                    MessageBox.Show("Book has been borrowed");
                    break;
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
        }

        private void StudyBookList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void articleborrow_Click(object sender, EventArgs e)
        {
            {
                int articleid = Convert.ToInt32(borrowarticleid.Text);
                foreach(Article article in articlelist)
                    if (article.id == articleid)
                    {
                        if (article.quantity < 1)
                        {
                            MessageBox.Show("Not in stock");
                            break;
                        }
                        article.quantity -= 1;
                        MessageBox.Show("Article has been borrowed");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input");
                    }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudyBookList.Items.Clear();
            foreach(StudyBook book in booklist)
            {
                StudyBookList.Items.Add(book.getinfo());
            }
        }

        private void ShowArticles(object sender, EventArgs e)
        {
            ArticleList.Items.Clear();
            foreach (Article book in articlelist)
            {
                ArticleList.Items.Add(book.getinfo());
            }
        }
    }
}
