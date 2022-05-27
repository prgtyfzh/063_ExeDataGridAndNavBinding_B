using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExePABD_DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            con = new SqlConnection("data source=PRGTYFZH;database=ProdiTI;Integrated Security=TRUE");
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from HRD.UserMhs where NamaUser = '" + textBox1.Text + "' and PassUser = '" + textBox2.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                new Menu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
