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
    public partial class Knigi : Form
    {
        public Knigi()
        {
            InitializeComponent();
        }
        Form1 main;
        OrderForm Orders;

        private void Knigi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Bibliotekar". При необходимости она может быть перемещена или удалена.
            this.bibliotekarTableAdapter.Fill(this.biblioBDDataSet.Bibliotekar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.biblioBDDataSet.Zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Knigi". При необходимости она может быть перемещена или удалена.
            this.knigiTableAdapter.Fill(this.biblioBDDataSet.Knigi);


            main = this.Owner as Form1;
            knigiDataGridView.DataError += new DataGridViewDataErrorEventHandler(DataError);
        }
        private void DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {

            }
        }
        private void TotalPrise()
        {
            int totalcost = 0;
            try
            {
                totalcost = Convert.ToInt32(knigiDataGridView.CurrentRow.Cells[6].Value) * Convert.ToInt32(knigiDataGridView.CurrentRow.Cells[7].Value);
            }
            catch (Exception) { }
            TotalBox.Text = totalcost.ToString() + " Рублей";

        }
        private void knigiBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.KnigiBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biblioBDDataSet);

        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.ExportToExcel(knigiDataGridView);
        }

        private void knigiDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            TotalPrise();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lastID = (int)zakazTableAdapter.ScalarQuery();
            int totalCost = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(this.knigiDataGridView.CurrentRow.Cells[7].Value);
            this.zakazTableAdapter.Insert(lastID + 1, (int)this.knigiDataGridView.CurrentRow.Cells[0].Value, DateTime.Now.Date, Convert.ToInt32(textBox2.Text), totalCost, main.tab_nomer);
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders = new OrderForm();
            Orders.ShowDialog();
        }

        private void Knigi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "Возврат к главному окну", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Validate();
                this.tableAdapterManager.UpdateAll(biblioBDDataSet);
            }

        }

        private void DTPTo_ValueChanged(object sender, EventArgs e)
        {
            string _maxDate = Convert.ToDateTime(DTPFrom.Value).ToString("MM.dd.yyyy");
            string _minDate = Convert.ToDateTime(DTPTo.Value).ToString("MM.dd.yyyy");
            KnigiBS.Filter = " DataPublik  >= #" + _maxDate + "# AND DataPublik <= #" + _minDate + "#";
        }

        private void avtorSearchBox_TextChanged(object sender, EventArgs e)
        {
            KnigiBS.Filter = "Avtor = '" + avtorSearchBox.Text + "'";
        }

        private void janrSearchbox_TextChanged(object sender, EventArgs e)
        {
            KnigiBS.Filter = "Janr = '" + janrSearchbox.Text + "'";
        }

        private void izdatelSearchBox_TextChanged(object sender, EventArgs e)
        {
            KnigiBS.Filter = "Izdatel = '" + izdatelSearchBox.Text + "'";
        }

        private void поЖанрамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanrStatsForm JSFRm = new JanrStatsForm();
            JSFRm.ShowDialog();
        }

        private void списокЖанровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewBookForm AddForm = new AddNewBookForm();
            AddForm.ShowDialog();
        }

        private void Knigi_Activated(object sender, EventArgs e)
        {
            knigiTableAdapter.Fill(biblioBDDataSet.Knigi);
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Будет выполнен поиск и удаление дублирующих записей", "Удаление дубликатов", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {

                for (int i = 1; i < knigiDataGridView.Rows.Count; i++)
                {
                    if ((string)knigiDataGridView.Rows[i].Cells[1].Value == (string)knigiDataGridView.Rows[i - 1].Cells[1].Value)
                    {
                        if (knigiDataGridView.Rows[i].Cells[2].Value.ToString() == knigiDataGridView.Rows[i - 1].Cells[2].Value.ToString())
                        {
                            if (knigiDataGridView.Rows[i].Cells[3].Value.ToString() == knigiDataGridView.Rows[i - 1].Cells[3].Value.ToString())
                            {
                                if (knigiDataGridView.Rows[i].Cells[4].Value.ToString() == knigiDataGridView.Rows[i - 1].Cells[4].Value.ToString())
                                {
                                    if (Convert.ToDateTime(knigiDataGridView.Rows[i].Cells[5].Value) == Convert.ToDateTime(knigiDataGridView.Rows[i - 1].Cells[3].Value.ToString()))
                                    {
                                        this.knigiTableAdapter.DeleteQuery((int)knigiDataGridView.Rows[i].Cells[0].Value);
                                    }
                                }
                            }
                        }
                    }
                    this.knigiTableAdapter.Fill(biblioBDDataSet.Knigi);
                }
            }
        }
    }
}
