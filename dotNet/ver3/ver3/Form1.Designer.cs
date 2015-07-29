namespace ver3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allStoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookStoreDataSet = new ver3.BookStoreDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.storesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookStoreDataSet1 = new ver3.BookStoreDataSet1();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookStoreDataSet2 = new ver3.BookStoreDataSet2();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookStoreDataSet3 = new ver3.BookStoreDataSet3();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookStoreDataSet4 = new ver3.BookStoreDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.storesTableAdapter = new ver3.BookStoreDataSetTableAdapters.StoresTableAdapter();
            this.storesTableAdapter1 = new ver3.BookStoreDataSet1TableAdapters.StoresTableAdapter();
            this.booksTableAdapter = new ver3.BookStoreDataSet2TableAdapters.BooksTableAdapter();
            this.authorsTableAdapter = new ver3.BookStoreDataSet3TableAdapters.AuthorsTableAdapter();
            this.genresTableAdapter = new ver3.BookStoreDataSet4TableAdapters.GenresTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allBooksToolStripMenuItem,
            this.allStoresToolStripMenuItem,
            this.genresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allBooksToolStripMenuItem
            // 
            this.allBooksToolStripMenuItem.Name = "allBooksToolStripMenuItem";
            this.allBooksToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.allBooksToolStripMenuItem.Text = "All Books";
            this.allBooksToolStripMenuItem.Click += new System.EventHandler(this.allBooksToolStripMenuItem_Click);
            // 
            // allStoresToolStripMenuItem
            // 
            this.allStoresToolStripMenuItem.Name = "allStoresToolStripMenuItem";
            this.allStoresToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.allStoresToolStripMenuItem.Text = "All Stores";
            this.allStoresToolStripMenuItem.Click += new System.EventHandler(this.allStoresToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.storesBindingSource;
            this.comboBox1.DisplayMember = "City";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(487, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "City";
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "Stores";
            this.storesBindingSource.DataSource = this.bookStoreDataSet;
            // 
            // bookStoreDataSet
            // 
            this.bookStoreDataSet.DataSetName = "BookStoreDataSet";
            this.bookStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.storesBindingSource1;
            this.comboBox2.DisplayMember = "State";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(487, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "State";
            // 
            // storesBindingSource1
            // 
            this.storesBindingSource1.DataMember = "Stores";
            this.storesBindingSource1.DataSource = this.bookStoreDataSet1;
            // 
            // bookStoreDataSet1
            // 
            this.bookStoreDataSet1.DataSetName = "BookStoreDataSet1";
            this.bookStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.booksBindingSource;
            this.comboBox3.DisplayMember = "Title";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(487, 140);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "Title";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bookStoreDataSet2;
            // 
            // bookStoreDataSet2
            // 
            this.bookStoreDataSet2.DataSetName = "BookStoreDataSet2";
            this.bookStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.authorsBindingSource;
            this.comboBox4.DisplayMember = "AuthorName";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(487, 189);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 6;
            this.comboBox4.ValueMember = "AuthorName";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.bookStoreDataSet3;
            // 
            // bookStoreDataSet3
            // 
            this.bookStoreDataSet3.DataSetName = "BookStoreDataSet3";
            this.bookStoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.genresBindingSource;
            this.comboBox5.DisplayMember = "GenreName";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(487, 230);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 7;
            this.comboBox5.ValueMember = "GenreName";
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.bookStoreDataSet4;
            // 
            // bookStoreDataSet4
            // 
            this.bookStoreDataSet4.DataSetName = "BookStoreDataSet4";
            this.bookStoreDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // storesTableAdapter1
            // 
            this.storesTableAdapter1.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "city";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "state";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "genre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(332, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(332, 189);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(331, 230);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Insert new entry";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Update fields";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.genresToolStripMenuItem.Text = "Genres";
            this.genresToolStripMenuItem.Click += new System.EventHandler(this.genresToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 336);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allStoresToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private BookStoreDataSet bookStoreDataSet;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private BookStoreDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private BookStoreDataSet1 bookStoreDataSet1;
        private System.Windows.Forms.BindingSource storesBindingSource1;
        private BookStoreDataSet1TableAdapters.StoresTableAdapter storesTableAdapter1;
        private BookStoreDataSet2 bookStoreDataSet2;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private BookStoreDataSet2TableAdapters.BooksTableAdapter booksTableAdapter;
        private BookStoreDataSet3 bookStoreDataSet3;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private BookStoreDataSet3TableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private BookStoreDataSet4 bookStoreDataSet4;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private BookStoreDataSet4TableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

