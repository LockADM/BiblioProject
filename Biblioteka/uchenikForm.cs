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
    public partial class uchenikForm : Form
    {
        public uchenikForm()
        {
            InitializeComponent();
        }

        private void uchenikForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.BiblioKart". При необходимости она может быть перемещена или удалена.
            this.biblioKartTableAdapter.Fill(this.biblioBDDataSet.BiblioKart);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Knigi". При необходимости она может быть перемещена или удалена.
            this.knigiTableAdapter.Fill(this.biblioBDDataSet.Knigi);
            Form1 main = this.Owner as Form1;
            this.biblioKartTableAdapter.FillByUchenikBibliokard(biblioBDDataSet.BiblioKart, main.ID_Uchenika);
            dataGridView1.DataSource = BKBS;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            DateTime DataBegin = DateTime.Now.Date;
            DateTime DataEnd = new DateTime();
            if (comboBox1.SelectedIndex == 0)
            {
                DataEnd = DataBegin.AddDays(7);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                DataEnd = DataBegin.AddDays(14);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                DataEnd = DataBegin.AddDays(30);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                DataEnd = DataBegin.AddDays(170);
            }
            int Nppcount = (int)this.biblioKartTableAdapter.GetIDCount();
            try
            {

                this.biblioKartTableAdapter.Insert(Nppcount + 1, main.ID_Uchenika, (int)comboBox1.SelectedValue, DataBegin, DataEnd, (int)numericUpDown1.Value, false);
                this.knigiTableAdapter.UpdateTrigger(Convert.ToInt32(numericUpDown1.Text), (int)comboBox1.SelectedValue);
            }
            catch (Exception) { MessageBox.Show("Ошибка, не выбрана книга"); }
            this.Validate();
            this.BKBS.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.biblioBDDataSet);
        }

        private void uchenikForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.TypeOfAccount = 4;
        }
    }
}
