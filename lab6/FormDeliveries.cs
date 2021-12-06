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
    public partial class FormDeliveries : Form
    {
        public FormDeliveries()
        {
            InitializeComponent();
        }

        private void FormDeliveries_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_booksDataSet1.Deliveries". При необходимости она может быть перемещена или удалена.
            this.deliveriesTableAdapter.Fill(this.db_booksDataSet1.Deliveries);

        }
    }
}
