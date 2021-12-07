namespace Journal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studybookid = new System.Windows.Forms.TextBox();
            this.studybooktitle = new System.Windows.Forms.TextBox();
            this.studybookauthor = new System.Windows.Forms.TextBox();
            this.studybookpublisher = new System.Windows.Forms.TextBox();
            this.studybookquantity = new System.Windows.Forms.TextBox();
            this.bookborrow = new System.Windows.Forms.Button();
            this.articleborrow = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studybookisbn = new System.Windows.Forms.TextBox();
            this.studybookgenre = new System.Windows.Forms.TextBox();
            this.articledate = new System.Windows.Forms.TextBox();
            this.articledoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.articlequantity = new System.Windows.Forms.TextBox();
            this.articlepublisher = new System.Windows.Forms.TextBox();
            this.articleauthor = new System.Windows.Forms.TextBox();
            this.articletitle = new System.Windows.Forms.TextBox();
            this.articleid = new System.Windows.Forms.TextBox();
            this.articlecj = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.addstudybook = new System.Windows.Forms.Button();
            this.addresearcharticle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.borrowbookid = new System.Windows.Forms.TextBox();
            this.borrowarticleid = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.StudyBookList = new System.Windows.Forms.ListBox();
            this.ArticleList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // studybookid
            // 
            this.studybookid.Location = new System.Drawing.Point(97, 37);
            this.studybookid.Name = "studybookid";
            this.studybookid.Size = new System.Drawing.Size(100, 22);
            this.studybookid.TabIndex = 0;
            // 
            // studybooktitle
            // 
            this.studybooktitle.Location = new System.Drawing.Point(97, 65);
            this.studybooktitle.Name = "studybooktitle";
            this.studybooktitle.Size = new System.Drawing.Size(100, 22);
            this.studybooktitle.TabIndex = 1;
            // 
            // studybookauthor
            // 
            this.studybookauthor.Location = new System.Drawing.Point(97, 111);
            this.studybookauthor.Name = "studybookauthor";
            this.studybookauthor.Size = new System.Drawing.Size(100, 22);
            this.studybookauthor.TabIndex = 2;
            // 
            // studybookpublisher
            // 
            this.studybookpublisher.Location = new System.Drawing.Point(97, 142);
            this.studybookpublisher.Name = "studybookpublisher";
            this.studybookpublisher.Size = new System.Drawing.Size(100, 22);
            this.studybookpublisher.TabIndex = 3;
            // 
            // studybookquantity
            // 
            this.studybookquantity.Location = new System.Drawing.Point(97, 170);
            this.studybookquantity.Name = "studybookquantity";
            this.studybookquantity.Size = new System.Drawing.Size(100, 22);
            this.studybookquantity.TabIndex = 4;
            // 
            // bookborrow
            // 
            this.bookborrow.Location = new System.Drawing.Point(389, 98);
            this.bookborrow.Name = "bookborrow";
            this.bookborrow.Size = new System.Drawing.Size(75, 23);
            this.bookborrow.TabIndex = 5;
            this.bookborrow.Text = "Borrow";
            this.bookborrow.UseVisualStyleBackColor = true;
            this.bookborrow.Click += new System.EventHandler(this.bookborrow_Click);
            // 
            // articleborrow
            // 
            this.articleborrow.Location = new System.Drawing.Point(357, 233);
            this.articleborrow.Name = "articleborrow";
            this.articleborrow.Size = new System.Drawing.Size(75, 23);
            this.articleborrow.TabIndex = 6;
            this.articleborrow.Text = "Borrow";
            this.articleborrow.UseVisualStyleBackColor = true;
            this.articleborrow.Click += new System.EventHandler(this.articleborrow_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(28, 43);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 16);
            this.ID.TabIndex = 7;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Publisher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Genre";
            // 
            // studybookisbn
            // 
            this.studybookisbn.Location = new System.Drawing.Point(97, 205);
            this.studybookisbn.Name = "studybookisbn";
            this.studybookisbn.Size = new System.Drawing.Size(100, 22);
            this.studybookisbn.TabIndex = 14;
            // 
            // studybookgenre
            // 
            this.studybookgenre.Location = new System.Drawing.Point(97, 233);
            this.studybookgenre.Name = "studybookgenre";
            this.studybookgenre.Size = new System.Drawing.Size(100, 22);
            this.studybookgenre.TabIndex = 15;
            // 
            // articledate
            // 
            this.articledate.Location = new System.Drawing.Point(117, 537);
            this.articledate.Name = "articledate";
            this.articledate.Size = new System.Drawing.Size(100, 22);
            this.articledate.TabIndex = 29;
            // 
            // articledoi
            // 
            this.articledoi.Location = new System.Drawing.Point(97, 502);
            this.articledoi.Name = "articledoi";
            this.articledoi.Size = new System.Drawing.Size(100, 22);
            this.articledoi.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Published Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Publisher";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Author";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 505);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "DOI";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Title";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "ID";
            // 
            // articlequantity
            // 
            this.articlequantity.Location = new System.Drawing.Point(97, 470);
            this.articlequantity.Name = "articlequantity";
            this.articlequantity.Size = new System.Drawing.Size(100, 22);
            this.articlequantity.TabIndex = 20;
            // 
            // articlepublisher
            // 
            this.articlepublisher.Location = new System.Drawing.Point(97, 436);
            this.articlepublisher.Name = "articlepublisher";
            this.articlepublisher.Size = new System.Drawing.Size(100, 22);
            this.articlepublisher.TabIndex = 19;
            // 
            // articleauthor
            // 
            this.articleauthor.Location = new System.Drawing.Point(97, 408);
            this.articleauthor.Name = "articleauthor";
            this.articleauthor.Size = new System.Drawing.Size(100, 22);
            this.articleauthor.TabIndex = 18;
            // 
            // articletitle
            // 
            this.articletitle.Location = new System.Drawing.Point(97, 370);
            this.articletitle.Name = "articletitle";
            this.articletitle.Size = new System.Drawing.Size(100, 22);
            this.articletitle.TabIndex = 17;
            // 
            // articleid
            // 
            this.articleid.Location = new System.Drawing.Point(97, 342);
            this.articleid.Name = "articleid";
            this.articleid.Size = new System.Drawing.Size(100, 22);
            this.articleid.TabIndex = 16;
            // 
            // articlecj
            // 
            this.articlecj.Location = new System.Drawing.Point(117, 575);
            this.articlecj.Name = "articlecj";
            this.articlecj.Size = new System.Drawing.Size(100, 22);
            this.articlecj.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 581);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "C_J";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 29);
            this.label15.TabIndex = 32;
            this.label15.Text = "Study Book";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 29);
            this.label16.TabIndex = 33;
            this.label16.Text = "Research Article";
            // 
            // addstudybook
            // 
            this.addstudybook.Location = new System.Drawing.Point(62, 275);
            this.addstudybook.Name = "addstudybook";
            this.addstudybook.Size = new System.Drawing.Size(126, 23);
            this.addstudybook.TabIndex = 34;
            this.addstudybook.Text = "Add Study Book";
            this.addstudybook.UseVisualStyleBackColor = true;
            this.addstudybook.Click += new System.EventHandler(this.addstudybook_Click);
            // 
            // addresearcharticle
            // 
            this.addresearcharticle.Location = new System.Drawing.Point(70, 612);
            this.addresearcharticle.Name = "addresearcharticle";
            this.addresearcharticle.Size = new System.Drawing.Size(147, 23);
            this.addresearcharticle.TabIndex = 35;
            this.addresearcharticle.Text = "Add Research Article";
            this.addresearcharticle.UseVisualStyleBackColor = true;
            this.addresearcharticle.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(235, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(17, 633);
            this.button3.TabIndex = 36;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(278, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "Study Book ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(278, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 16);
            this.label18.TabIndex = 38;
            this.label18.Text = "Article ID";
            // 
            // borrowbookid
            // 
            this.borrowbookid.Location = new System.Drawing.Point(389, 52);
            this.borrowbookid.Name = "borrowbookid";
            this.borrowbookid.Size = new System.Drawing.Size(100, 22);
            this.borrowbookid.TabIndex = 39;
            // 
            // borrowarticleid
            // 
            this.borrowarticleid.Location = new System.Drawing.Point(357, 173);
            this.borrowarticleid.Name = "borrowarticleid";
            this.borrowarticleid.Size = new System.Drawing.Size(100, 22);
            this.borrowarticleid.TabIndex = 40;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(579, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(17, 633);
            this.button4.TabIndex = 41;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(235, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(361, 18);
            this.button5.TabIndex = 42;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(367, 436);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 23);
            this.button6.TabIndex = 43;
            this.button6.Text = "Show Study Books";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(367, 505);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 23);
            this.button7.TabIndex = 44;
            this.button7.Text = "Show Articles";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ShowArticles);
            // 
            // StudyBookList
            // 
            this.StudyBookList.FormattingEnabled = true;
            this.StudyBookList.ItemHeight = 16;
            this.StudyBookList.Location = new System.Drawing.Point(662, 43);
            this.StudyBookList.Name = "StudyBookList";
            this.StudyBookList.Size = new System.Drawing.Size(386, 260);
            this.StudyBookList.TabIndex = 45;
            this.StudyBookList.SelectedIndexChanged += new System.EventHandler(this.StudyBookList_SelectedIndexChanged);
            // 
            // ArticleList
            // 
            this.ArticleList.FormattingEnabled = true;
            this.ArticleList.ItemHeight = 16;
            this.ArticleList.Location = new System.Drawing.Point(662, 347);
            this.ArticleList.Name = "ArticleList";
            this.ArticleList.Size = new System.Drawing.Size(386, 260);
            this.ArticleList.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 647);
            this.Controls.Add(this.ArticleList);
            this.Controls.Add(this.StudyBookList);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.borrowarticleid);
            this.Controls.Add(this.borrowbookid);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addresearcharticle);
            this.Controls.Add(this.addstudybook);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.articlecj);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.articledate);
            this.Controls.Add(this.articledoi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.articlequantity);
            this.Controls.Add(this.articlepublisher);
            this.Controls.Add(this.articleauthor);
            this.Controls.Add(this.articletitle);
            this.Controls.Add(this.articleid);
            this.Controls.Add(this.studybookgenre);
            this.Controls.Add(this.studybookisbn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.articleborrow);
            this.Controls.Add(this.bookborrow);
            this.Controls.Add(this.studybookquantity);
            this.Controls.Add(this.studybookpublisher);
            this.Controls.Add(this.studybookauthor);
            this.Controls.Add(this.studybooktitle);
            this.Controls.Add(this.studybookid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studybookid;
        private System.Windows.Forms.TextBox studybooktitle;
        private System.Windows.Forms.TextBox studybookauthor;
        private System.Windows.Forms.TextBox studybookpublisher;
        private System.Windows.Forms.TextBox studybookquantity;
        private System.Windows.Forms.Button bookborrow;
        private System.Windows.Forms.Button articleborrow;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studybookisbn;
        private System.Windows.Forms.TextBox studybookgenre;
        private System.Windows.Forms.TextBox articledate;
        private System.Windows.Forms.TextBox articledoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox articlequantity;
        private System.Windows.Forms.TextBox articlepublisher;
        private System.Windows.Forms.TextBox articleauthor;
        private System.Windows.Forms.TextBox articletitle;
        private System.Windows.Forms.TextBox articleid;
        private System.Windows.Forms.TextBox articlecj;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button addstudybook;
        private System.Windows.Forms.Button addresearcharticle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox borrowbookid;
        private System.Windows.Forms.TextBox borrowarticleid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox StudyBookList;
        private System.Windows.Forms.ListBox ArticleList;
    }
}

