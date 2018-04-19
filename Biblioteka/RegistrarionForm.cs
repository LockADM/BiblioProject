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
            Form1 main = this.Owner as Form1;
            if (comboBox1.SelectedIndex == 2)
            {
                if (main.TypeOfAccount == 2)
                {
                    int lastId = (int)this.bibliotekarTableAdapter.ScalarQuery();
                    int hashPass = passwordTextBox.Text.GetHashCode();
                    this.bibliotekarTableAdapter.Insert(lastId + 1, fIOTextBox.Text, data_RojdeniyaDateTimePicker.Value.Date, loginTextBox.Text, hashPass, comboBox1.SelectedIndex.ToString());
                    this.tableAdapterManager.UpdateAll(biblioBDDataSet);
                    MessageBox.Show("Новый пользователь добавлен!");
                }
                else { MessageBox.Show("Недостаточно прав для добавления администратора! Выберете другой тип учетной записи!"); }
            }
        }

        private void CloseBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
