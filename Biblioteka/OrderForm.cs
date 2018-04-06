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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void zakazBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zakazBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biblioBDDataSet);

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Bibliotekar". При необходимости она может быть перемещена или удалена.
            this.bibliotekarTableAdapter.Fill(this.biblioBDDataSet.Bibliotekar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Knigi". При необходимости она может быть перемещена или удалена.
            this.knigiTableAdapter.Fill(this.biblioBDDataSet.Knigi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.biblioBDDataSet.Zakaz);

        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            for (int k = 0; k < zakazDataGridView.Columns.Count; k++)
            {
                ExcelApp.Cells[1, k + 1] = zakazDataGridView.Columns[k].HeaderText.ToString();
            }

            for (int i = 0; i < zakazDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < zakazDataGridView.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = zakazDataGridView.Rows[i].Cells[j].Value;

                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
