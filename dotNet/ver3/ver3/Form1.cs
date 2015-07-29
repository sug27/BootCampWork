using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ver3 {
    public partial class Form1 : Form {
        BSE db = new BSE();
        public Form1() {

            InitializeComponent();
        }

        

        private void allBooksToolStripMenuItem_Click(object sender, EventArgs e) {
            displayBookAuth();
            
        }

        private void allStoresToolStripMenuItem_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = db.Stores.ToList();
        }

        private void button2_Click(object sender, EventArgs e) {
           
            BSE db = new BSE();

            Store newSTore = new Store();
            Author newAuthor = new Author();
            Book newBook = new Book();
            Genre newGenre = new Genre();
            Author temp = new Author();


            db.SaveChanges();
            //count authors in list
            int countAuth = db.Authors.Count();
            //count genres in list
            int countGen = db.Genres.Count();
            //count books
            int countBook = db.Books.Count();
            int countStores = db.Stores.Count();
            //stores
            if (countStores > 0) {
                var query = (from stre in db.Stores
                             where stre.City == comboBox1.Text
                             select stre);

                if (query.Count() > 0) {
                    newSTore = query.FirstOrDefault();
                }

            }
            //authors
            if (countAuth > 0) {
                var query = (from auth in db.Authors
                             where auth.AuthorName == comboBox4.Text
                             select auth).FirstOrDefault();
            }

            //genres
            if (countGen > 0) {
                var query = (from gen in db.Genres
                             where gen.GenreName == comboBox5.Text
                             select gen);
                if (query.Count() > 0) {
                    newGenre = query.FirstOrDefault();
                }

            }
         
            //books
            if (countBook > 0) {
                var query = (from bk in db.Books
                             where bk.Title == comboBox3.Text
                             select bk);
                if (query.Count() > 0) {
                    newBook = query.FirstOrDefault();
                }

            }
            if ((comboBox1.Text != "" && comboBox2.Text != "") && comboBox1.Text != newSTore.City) {
                newSTore.City = comboBox1.Text;
                newSTore.State = comboBox2.Text;
                db.Stores.Add(newSTore);
            }

            if (comboBox4.Text != "" && comboBox4.Text != temp.AuthorName) {//sets author name

                var doesContains = comboBox4.Text.Contains(',');
                if (doesContains == true) {
                    var names = comboBox4.Text.Split(',');

                    for (int i = 0; i < names.Length; i++) {
                        Author author = new Author();
                        author.AuthorName = names[i];
                        db.Authors.Add(author);
                    }
                }
                else {
                    newAuthor.AuthorName = comboBox4.Text.Trim();
                    db.Authors.Add(newAuthor);
                }
                db.SaveChanges();
            }


            if (comboBox5.Text != "" && newGenre.GenreName != comboBox5.Text) {
                newGenre.GenreName = comboBox5.Text;
                db.Genres.Add(newGenre);
            }


            if (comboBox3.Text != "" && newBook.Title != comboBox3.Text) {
                newBook.Title = comboBox3.Text;
                newBook.GenreID = newGenre.GenreID;

                var len = comboBox4.Text.Split(',');

                if (len.Length > 1) {
                    var auths = db.Authors.OrderBy(x=>x.AuthorID).Skip(Math.Max(0, db.Authors.Count() - len.Length));
                    foreach (Author auth in auths) {
                        db.Books.Add(newBook);
                        newBook.Authors.Add(auth);

                    }
                }

                if(len.Length== 1) {
                    db.Books.Add(newBook);
                    db.Authors.Add(newAuthor);
                    newBook.Authors.Add(newAuthor);
                }
                db.SaveChanges();
                dataGridView1.DataSource = db.Stores.ToList();
            }

            if(comboBox5.Text != "" ) {
                
                newGenre.GenreName = comboBox5.Text;
                db.Genres.Add(newGenre);
                db.SaveChanges();
            }

        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'bookStoreDataSet4.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.bookStoreDataSet4.Genres);
            // TODO: This line of code loads data into the 'bookStoreDataSet3.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.bookStoreDataSet3.Authors);
            // TODO: This line of code loads data into the 'bookStoreDataSet2.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.bookStoreDataSet2.Books);
            // TODO: This line of code loads data into the 'bookStoreDataSet1.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter1.Fill(this.bookStoreDataSet1.Stores);
            // TODO: This line of code loads data into the 'bookStoreDataSet.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this.bookStoreDataSet.Stores);

        }
        //delete button
        private void button1_Click(object sender, EventArgs e) {
            var removeStore = (from stre in db.Stores
                               where stre.City == comboBox1.Text 
                               select stre).ToList();


            //find books where title = "text"
            var temp = (from b in db.Books
                        where b.Title == comboBox3.Text
                        select b).ToList();
           
            //find authors where title = "text"
            var tempau = (from a in db.Authors
                        where a.AuthorName == comboBox4.Text
                        select a).ToList();
           
            //remove store
            if (removeStore.Count() > 0) {
                var gone = removeStore.FirstOrDefault();
                db.Stores.Remove(gone);
            }

            //deleting an author from book
            if (comboBox3.Text != "" && comboBox4.Text != "") {
                if (tempau.Count() > 0) {//authors
                    var bk = temp.FirstOrDefault();
                    var au = tempau.FirstOrDefault();
                    bk.Authors.Remove(au);
                    db.SaveChanges();
                }
            }
            //deletes actual book
            if(comboBox3.Text != "" && comboBox4.Text == "") {
                var au = tempau.FirstOrDefault();
                var bk = temp.FirstOrDefault();
                db.Authors.Remove(au);
                db.Books.Remove(bk);
                db.SaveChanges();
            }

           

            var removeGenre = (from gen in db.Genres
                                   where gen.GenreName == comboBox5.Text
                                   select gen).ToList();

            if(removeGenre.Count() > 0) {
                var poof = removeGenre.FirstOrDefault();
                db.Genres.Remove(poof);
            }
            db.SaveChanges();
        }
      
        
        //update entries using left fields
        private void button4_Click(object sender, EventArgs e) {
            BSE db = new BSE();
            if (textBox1.Text != "" || textBox2.Text != "") {//update store
                var temp = (from stre in db.Stores
                            where stre.City == comboBox1.Text && stre.State == comboBox2.Text
                            select stre).ToList();
                if(temp.Count() > 0) {
                    var update = temp.FirstOrDefault();
                    if (textBox1.Text != "") {
                        //update state
                        update.State = textBox2.Text;
                    }
                    if (textBox2.Text != "") {
                        //update city
                        update.City = textBox1.Text;
                    }
                    else {//update both
                        update.State = textBox2.Text;
                        update.City = textBox1.Text;
                    }
                }
                db.SaveChanges();
            }
            if(textBox3.Text != "") {//update title
                var temp = (from buk in db.Books
                            where buk.Title == comboBox3.Text 
                            select buk).ToList();
                if(temp.Count() > 0) {
                    var update = temp.FirstOrDefault();
                    update.Title = textBox3.Text;
                }

                db.SaveChanges();
            }
            if(textBox4.Text != "") {//update author
                var temp = (from aut in db.Authors
                            where aut.AuthorName == comboBox4.Text
                            select aut).ToList();
                if (temp.Count() > 0) {
                    var update = temp.FirstOrDefault();
                    update.AuthorName = textBox4.Text;
                }

                db.SaveChanges();
            }
            if(textBox5.Text != "") {//update genre
                var temp = (from gen in db.Genres
                            where gen.GenreName == comboBox5.Text
                            select gen).ToList();
                if (temp.Count() > 0) {
                    var update = temp.FirstOrDefault();
                    update.GenreName = textBox5.Text;
                }

                db.SaveChanges();
               
                
            }

        }

        private void displayBookAuth() {
            BSE db = new BSE();
            var bookAuthList = (from b in db.Books.Where(auth => auth.Authors.Any())
                                from a in db.Authors.Where(buk => buk.Books.Contains(b))
                                select new { b.Title, a.AuthorName });

            dataGridView1.DataSource = bookAuthList.ToList();
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = db.Genres.ToList();
        }
    }

    public class Authors {
        public String Name { get; set; }
    }
    public class Books {
        public String Title { get; set; }
        public String genre { get; set; }
    }
    public class Gen {
        public String Name { get; set; }
    }
    public class Stores {
        public String City { get; set; }
        public String State { get; set; }
    }
}

