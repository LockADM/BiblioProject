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
    public partial class RegistrarionForm : Form
    {
        public RegistrarionForm()
        {
            InitializeComponent();
        }

        private void bibliotekarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bibliotekarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biblioBDDataSet);

        }

        private void RegistrarionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Bibliotekar". При необходимости она может быть перемещена или удалена.
            this.bibliotekarTableAdapter.Fill(this.biblioBDDataSet.Bibliotekar);

        }

        private void AddBttn_Click(object sender, EventArgs e)
        {
            int lastId = (int)this.bibliotekarTableAdapter.ScalarQuery();
            int hashPass = passwordTextBox.Text.GetHashCode();
            this.bibliotekarTableAdapter.Insert(lastId + 1, fIOTextBox.Text, data_RojdeniyaDateTimePicker.Value.Date, loginTextBox.Text, hashPass);
            this.tableAdapterManager.UpdateAll(biblioBDDataSet);
            MessageBox.Show("Новый пользователь добавлен!");
        }

        private void CloseBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
