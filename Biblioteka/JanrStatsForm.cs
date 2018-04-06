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
    public partial class JanrStatsForm : Form
    {
        public JanrStatsForm()
        {
            InitializeComponent();
        }

        private void JanrStatsForm_Load(object sender, EventArgs e)
        {
            BiblioBDDataSetTableAdapters.KnigiTableAdapter KnigiTableAdapter = new BiblioBDDataSetTableAdapters.KnigiTableAdapter();

            DataTable Dt = KnigiTableAdapter.GetJanrSort();
            dataGridView1.DataSource = Dt;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (i != 8)
                {
                    if (i != 4)
                    {
                        dataGridView1.Columns[i].Visible = false;
                    }
                }
            }
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].HeaderText = "Жанр";
            dataGridView1.Columns[8].HeaderText = "Общее количество книг";

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
 
                chart1.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[4].Value.ToString(), Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value));
            }
            
        }

      
        
    }
}
