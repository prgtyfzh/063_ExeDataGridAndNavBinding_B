using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExePABD_DataBinding
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.MataKuliah' table. You can move, or remove it, as needed.
            this.mataKuliahTableAdapter.Fill(this.prodiTIDataSet.MataKuliah);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.prodiTIDataSet.Nilai);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
