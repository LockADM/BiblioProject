using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void bibliotekarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bibliotekarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biblioBDDataSet);

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Bibliotekar". При необходимости она может быть перемещена или удалена.
            this.bibliotekarTableAdapter.Fill(this.biblioBDDataSet.Bibliotekar);

        }
    }
}
