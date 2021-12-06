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
    public partial class FormPublish : Form
    {
        public FormPublish()
        {
            InitializeComponent();
        }

        private void FormPublish_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_booksDataSet.Publishing_house". При необходимости она может быть перемещена или удалена.
            this.publishing_houseTableAdapter.Fill(this.db_booksDataSet.Publishing_house);

        }
    }
}
