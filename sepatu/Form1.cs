using MySql.Data.MySqlClient;
using System.Data;

namespace sepatu
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = Connections.getConnection();
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }
        public DataTable getDataSepatu()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM sepatu", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }
        public void filldataTable()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowTemplate.Height = 150;
            dataGridView1.DataSource = getDataSepatu();

            Column1.DataPropertyName = "id";
            Column2.DataPropertyName = "Merk";
            Column3.DataPropertyName = "Stock";
            Column4.DataPropertyName = "Harga";
            Column5.DataPropertyName = "gambar";

        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update sepatu SET id = @id :=(@id+1);" + "ALTER TABLE sepatu AUTO_INCREMENT = 1;");
            script.Execute();
        }

        public void seacrhDate(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM sepatu where concat (id, Merk, Stock, Harga) LIKE '%" + ValueToFind + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                byte[] gambarData;
                using (MemoryStream ms = new MemoryStream())
                {
                    gambar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    gambarData = ms.ToArray();
                }

                resetIncrement();
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "insert into sepatu (Merk, Stock, Harga, gambar) VALUE(@Merk, @Stock, @Harga, @gambar)";
                cmd.Parameters.AddWithValue("@Merk", merk.Text);
                cmd.Parameters.AddWithValue("@Stock", stock.Text);
                cmd.Parameters.AddWithValue("@Harga", harga.Text);
                cmd.Parameters.AddWithValue("@gambar", gambarData);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                MessageBox.Show("Data berhasil ditambah!");
                dataTable.Clear();
                filldataTable();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Data gagal ditambah" + ex.Message.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                gambar.Image = new Bitmap(openfd.FileName);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                byte[] gambarData;
                using (MemoryStream ms = new MemoryStream())
                {
                    gambar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    gambarData = ms.ToArray();
                }

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "update sepatu set Merk=@Merk, Stock=@Stock, Harga=@Harga, gambar=@gambar where id=@id";
                cmd.Parameters.AddWithValue("@id", id_sepatu.Text);
                cmd.Parameters.AddWithValue("@Merk", merk.Text);
                cmd.Parameters.AddWithValue("@Stock", stock.Text);
                cmd.Parameters.AddWithValue("@Harga", harga.Text);
                cmd.Parameters.AddWithValue("@gambar", gambarData);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                MessageBox.Show("Data berhasil diupdate!");
                dataTable.Clear();
                filldataTable();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Data gagal diupdate" + ex.Message.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                byte[] gambarData;
                using (MemoryStream ms = new MemoryStream())
                {
                    gambar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    gambarData = ms.ToArray();
                }

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "delete from sepatu where id=@id";
                cmd.Parameters.AddWithValue("@id", id_sepatu.Text);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                resetIncrement();
                MessageBox.Show("Data berhasil dihapus!");
                dataTable.Clear();
                filldataTable();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Data gagal dihapus" + ex.Message.ToString());
            }
        }

        private void id_sepatu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
            id_sepatu.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            merk.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            harga.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            stock.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img);
            gambar.Image = Image.FromStream(ms);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            seacrhDate(search.Text);
        }
    }
}