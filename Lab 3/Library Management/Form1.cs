using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Library_Management : Form
    {
        public Library_Management()
        {
            InitializeComponent();
        }
        List<User> users = new List<User>();
        List<Book> books = new List<Book>();
        private void Adduserbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UserIDtextbox.Text);
            string name = Usernametextbox.Text;
            string address = Useraddresstextbox.Text;

            User dummy = new User(id, name, address);

            users.Add(dummy);
            MessageBox.Show("Success!User added");
        }

        private void Addbookbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BookIDtextbox.Text);
            string title = Booktitletextbox.Text;
            string author = Bookauthortextbox.Text;
            string publisher = Bookpublishertextbox.Text;
            int quantity = Convert.ToInt32(Bookquantitytextbox.Text);

            Book dummy = new Book(id, title, author, publisher, quantity);

            books.Add(dummy);
            MessageBox.Show("Success!Book added");
        }

        private void Borrowbookbutton_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIDborrowtextbox.Text);
            int bookID = Convert.ToInt32(BookIDborrowtextbox.Text);

                foreach (Book book in books)
                {
                    if (book.id == bookID)
                    {
                        if (book.quantity < 1)
                        {
                            MessageBox.Show("Not in stocks");
                            break;
                        }
                        book.quantity -= 1;
                        foreach (User user in users)
                        {
                            if (user.id == userID)
                            {
                                user.books.Add(bookID);
                                MessageBox.Show("Success!Book given to user");
                            }
                        }
                        break;
                    }
                }
        }

        private void Showbookbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BookIDshowtextbox.Text);
            bool flag = false;
            foreach (Book book in books)
            {
                if (book.id == id)
                {
                    flag = true;
                    BookIDlabel.Text = "Book ID:" + " " + book.id.ToString();
                    Booktitlelabel.Text = "Book Title:" + " " + book.title;
                    Bookauthorlabel.Text = "Author:" + " " + book.author;
                    Bookpublisherlabel.Text = "Publisher:" + " " + book.publisher;
                    Bookquantitylabel.Text = "Quantity:" + " " + book.quantity.ToString();
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Book could not be found!");
            }
        }

        private void Showhistorybutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UserIDshowtextbox.Text);
            User dummy = new User();
            bool flag = false;
            foreach (User user in users)
            {
                if (user.id == id)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("User could not be found!");
            }
            UserListBox.Items.Clear();
            for (int i = 0; i < dummy.books.Count; i++)
            {
                int id_book = dummy.books[i];
                for (int j = 0; j < books.Count; j++)
                {
                    if (books[j].id == id_book)
                    {
                        UserListBox.Items.Add(books[j].history());
                    }
                }
            }
        }
    }
}
