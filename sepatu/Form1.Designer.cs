namespace sepatu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            merk = new TextBox();
            stock = new TextBox();
            harga = new TextBox();
            id_sepatu = new TextBox();
            gambar = new PictureBox();
            btn_tambah = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            search = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gambar).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(32, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(737, 343);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 42;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Merk";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Stock";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 61;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Harga";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 64;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "gambar";
            Column5.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // merk
            // 
            merk.Location = new Point(458, 80);
            merk.Name = "merk";
            merk.Size = new Size(224, 23);
            merk.TabIndex = 1;
            // 
            // stock
            // 
            stock.Location = new Point(458, 131);
            stock.Name = "stock";
            stock.Size = new Size(224, 23);
            stock.TabIndex = 3;
            // 
            // harga
            // 
            harga.Location = new Point(458, 182);
            harga.Name = "harga";
            harga.Size = new Size(224, 23);
            harga.TabIndex = 4;
            // 
            // id_sepatu
            // 
            id_sepatu.Location = new Point(458, 33);
            id_sepatu.Name = "id_sepatu";
            id_sepatu.Size = new Size(224, 23);
            id_sepatu.TabIndex = 5;
            id_sepatu.TextChanged += id_sepatu_TextChanged;
            // 
            // gambar
            // 
            gambar.BorderStyle = BorderStyle.FixedSingle;
            gambar.Location = new Point(32, 33);
            gambar.Name = "gambar";
            gambar.Size = new Size(166, 172);
            gambar.SizeMode = PictureBoxSizeMode.StretchImage;
            gambar.TabIndex = 6;
            gambar.TabStop = false;
            gambar.Click += gambar_Click;
            // 
            // btn_tambah
            // 
            btn_tambah.Location = new Point(165, 239);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(197, 23);
            btn_tambah.TabIndex = 7;
            btn_tambah.Text = "tambah";
            btn_tambah.UseVisualStyleBackColor = true;
            btn_tambah.Click += button1_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(572, 239);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(197, 23);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(369, 239);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(197, 23);
            btn_update.TabIndex = 9;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // search
            // 
            search.Location = new Point(110, 290);
            search.Name = "search";
            search.Size = new Size(659, 23);
            search.TabIndex = 10;
            search.TextChanged += search_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(458, 15);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 11;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 62);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Merek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 164);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 13;
            label3.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 113);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 14;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 15);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 15;
            label5.Text = "Gambar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 290);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 16;
            label6.Text = "Seacrh";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 674);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(search);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_tambah);
            Controls.Add(gambar);
            Controls.Add(id_sepatu);
            Controls.Add(harga);
            Controls.Add(stock);
            Controls.Add(merk);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox merk;
        private TextBox stock;
        private TextBox harga;
        private TextBox id_sepatu;
        private PictureBox gambar;
        private Button btn_tambah;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Column5;
        private Button btn_delete;
        private Button btn_update;
        private TextBox search;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}