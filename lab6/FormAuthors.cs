using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class FormAuthors : Form
    {
        public FormAuthors()
        {
            InitializeComponent();
        }

        private void FormAuthors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_booksDataSet2.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.db_booksDataSet2.Authors);

        }
    }
}
