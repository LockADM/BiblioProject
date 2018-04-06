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
    public partial class AddUchenikForm : Form
    {
        public AddUchenikForm()
        {
            InitializeComponent();
        }
    
        private void AddUchenikForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Ucheniki". При необходимости она может быть перемещена или удалена.
            this.uchenikiTableAdapter.Fill(this.biblioBDDataSet.Ucheniki);
            
            
        }

        private void AddBttn_Click(object sender, EventArgs e)
        {
            int UchenikID = 0;
            UchenikID = (int)this.uchenikiTableAdapter.GetLastID();
            try
            {

                this.uchenikiTableAdapter.Insert(UchenikID + 1, fIOTextBox.Text, Convert.ToInt32(vozrastNumeric.Text), klassTextBox.Text, comboBox1.SelectedItem.ToString());
            }
            catch(Exception) { MessageBox.Show("Укажите пол!"); }
            this.tableAdapterManager.UpdateAll(this.biblioBDDataSet);
        }

        private void CloseBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
