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

namespace lab6
{
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_booksDataSet6.Publishing_house". При необходимости она может быть перемещена или удалена.
            this.publishing_houseTableAdapter.Fill(this.db_booksDataSet6.Publishing_house);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_booksDataSet5.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.db_booksDataSet5.Authors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_booksDataSet3.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.db_booksDataSet3.Books);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Code_Publish = " +
            dataGridView1[4, bb].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Code_Author = " +
            dataGridView1[0, bb].Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Pages = " +
            dataGridView1[3, bb].Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "";
        }
    }
}
