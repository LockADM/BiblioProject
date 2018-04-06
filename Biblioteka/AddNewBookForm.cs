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
    public partial class AddNewBookForm : Form
    {
        public AddNewBookForm()
        {
            InitializeComponent();
        }
        int count;
        private void knigiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.knigiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biblioBDDataSet);

        }

        private void AddNewBookForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Knigi". При необходимости она может быть перемещена или удалена.
            this.knigiTableAdapter.Fill(this.biblioBDDataSet.Knigi);
            count = (int)this.knigiTableAdapter.getlastID();
            label1.Text = count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           try
            {
                count += 1;
                this.knigiTableAdapter.Insert(count, nameTextBox.Text, avtorTextBox.Text, izdatelTextBox.Text, janrCB.SelectedItem.ToString(), dataPublikDateTimePicker.Value.Date, Convert.ToInt32(kol_voTextBox.Text), Convert.ToDecimal(cena_ShtTextBox.Text));
                label1.Text = count.ToString();
            }
            catch (Exception) { MessageBox.Show("Заполните все поля!"); }
            this.tableAdapterManager.UpdateAll(biblioBDDataSet);
        }
    }
}
