namespace Csv_file_read_and_write
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Phone_Box = new System.Windows.Forms.Label();
            this.Phone1_Box = new System.Windows.Forms.Label();
            this.Zip_Box = new System.Windows.Forms.Label();
            this.State_Box = new System.Windows.Forms.Label();
            this.County_Box = new System.Windows.Forms.Label();
            this.City_Box = new System.Windows.Forms.Label();
            this.Address_Box = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 16;
            this.ListBox.Location = new System.Drawing.Point(12, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(490, 564);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(819, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(819, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(819, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(819, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(819, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "County";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(819, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(819, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Zip";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(819, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Phone1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(819, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Phone";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(927, 37);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(278, 22);
            this.searchbox.TabIndex = 11;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1130, 77);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Phone_Box
            // 
            this.Phone_Box.AutoSize = true;
            this.Phone_Box.Location = new System.Drawing.Point(1023, 453);
            this.Phone_Box.Name = "Phone_Box";
            this.Phone_Box.Size = new System.Drawing.Size(0, 16);
            this.Phone_Box.TabIndex = 21;
            // 
            // Phone1_Box
            // 
            this.Phone1_Box.AutoSize = true;
            this.Phone1_Box.Location = new System.Drawing.Point(1023, 409);
            this.Phone1_Box.Name = "Phone1_Box";
            this.Phone1_Box.Size = new System.Drawing.Size(0, 16);
            this.Phone1_Box.TabIndex = 20;
            // 
            // Zip_Box
            // 
            this.Zip_Box.AutoSize = true;
            this.Zip_Box.Location = new System.Drawing.Point(1023, 376);
            this.Zip_Box.Name = "Zip_Box";
            this.Zip_Box.Size = new System.Drawing.Size(0, 16);
            this.Zip_Box.TabIndex = 19;
            // 
            // State_Box
            // 
            this.State_Box.AutoSize = true;
            this.State_Box.Location = new System.Drawing.Point(1023, 340);
            this.State_Box.Name = "State_Box";
            this.State_Box.Size = new System.Drawing.Size(0, 16);
            this.State_Box.TabIndex = 18;
            // 
            // County_Box
            // 
            this.County_Box.AutoSize = true;
            this.County_Box.Location = new System.Drawing.Point(1023, 300);
            this.County_Box.Name = "County_Box";
            this.County_Box.Size = new System.Drawing.Size(0, 16);
            this.County_Box.TabIndex = 17;
            // 
            // City_Box
            // 
            this.City_Box.AutoSize = true;
            this.City_Box.Location = new System.Drawing.Point(1023, 269);
            this.City_Box.Name = "City_Box";
            this.City_Box.Size = new System.Drawing.Size(0, 16);
            this.City_Box.TabIndex = 16;
            // 
            // Address_Box
            // 
            this.Address_Box.AutoSize = true;
            this.Address_Box.Location = new System.Drawing.Point(1023, 233);
            this.Address_Box.Name = "Address_Box";
            this.Address_Box.Size = new System.Drawing.Size(0, 16);
            this.Address_Box.TabIndex = 15;
            // 
            // Name_Box
            // 
            this.Name_Box.AutoSize = true;
            this.Name_Box.Location = new System.Drawing.Point(1023, 151);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(0, 16);
            this.Name_Box.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 649);
            this.Controls.Add(this.Phone_Box);
            this.Controls.Add(this.Phone1_Box);
            this.Controls.Add(this.Zip_Box);
            this.Controls.Add(this.State_Box);
            this.Controls.Add(this.County_Box);
            this.Controls.Add(this.City_Box);
            this.Controls.Add(this.Address_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label Phone_Box;
        private System.Windows.Forms.Label Phone1_Box;
        private System.Windows.Forms.Label Zip_Box;
        private System.Windows.Forms.Label State_Box;
        private System.Windows.Forms.Label County_Box;
        private System.Windows.Forms.Label City_Box;
        private System.Windows.Forms.Label Address_Box;
        private System.Windows.Forms.Label Name_Box;
    }
}

