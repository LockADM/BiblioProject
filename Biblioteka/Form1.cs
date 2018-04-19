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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AddUchenikForm AddUchForm;
        public bool autorizationFlag = false;
        public int tab_nomer = 0;
        public int TypeOfAccount = 4;
        public int ID_Uchenika = 0;
        public DateTime UchenikDR = new DateTime();



        private void BBL_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Завершите редактирование записи, перед тем как выбрать следующую книгу!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (AutorizationForm AForm = new AutorizationForm())
            {
                AForm.Owner = this;
                AForm.ShowDialog();
            }
            if (StatusLabl.Text == "StatusLable")
            {
                StatusLabl.Text = null;
            }

        }

        private void добавитьУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUchForm = new AddUchenikForm();
            AddUchForm.ShowDialog();
        }
        private void AllFill()
        {
            this.knigiTableAdapter.Fill(this.biblioBDDataSet.Knigi);
            this.biblioKartTableAdapter.Fill(this.biblioBDDataSet.BiblioKart);
            this.uchenikiTableAdapter.Fill(this.biblioBDDataSet.Ucheniki);
            this.biblioKartDataGridView.DataError += new DataGridViewDataErrorEventHandler(BBL_DataError);
            this.uchenikiTableAdapter.Fill(this.biblioBDDataSet.Ucheniki);
            this.knigiTableAdapter.Fill(this.biblioBDDataSet.Knigi);
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (autorizationFlag == true)
            {
                if (TypeOfAccount == 2)
                {
                    AllFill();
                    Savebttn.Enabled = true;
                    button1.Enabled = true;
                    регистрацияToolStripMenuItem.Enabled = true;
                    инструментыToolStripMenuItem.Enabled = true;
                    авторизацияToolStripMenuItem.Enabled = false;
                    отладкаToolStripMenuItem.Enabled = true;
                    очиститьТаблицуToolStripMenuItem.Enabled = true;
                    экспортToolStripMenuItem.Enabled = true;
                    добавитьУченикаToolStripMenuItem.Enabled = true;
                    toolStripStatusLabel5.Text += "Вы авторизовались как :Администратор";
                }
                if(TypeOfAccount == 0)
                {
                    AllFill();
                    Savebttn.Enabled = true;
                    button1.Enabled = true;
                    регистрацияToolStripMenuItem.Enabled = true;
                    инструментыToolStripMenuItem.Enabled = true;
                    авторизацияToolStripMenuItem.Enabled = false;
                    отладкаToolStripMenuItem.Enabled = true;
                    экспортToolStripMenuItem.Enabled = true;
                    добавитьУченикаToolStripMenuItem.Enabled = true;
                    toolStripStatusLabel5.Text = "Вы авторизовались как: Библиотекарь";
                }
                if(TypeOfAccount == 1)
                {
                    try
                    {
                        ID_Uchenika = (int)this.uchenikiTableAdapter.GetID(toolStripStatusLabel3.Text,UchenikDR);
                        uchenikForm UchForm = new uchenikForm();
                        UchForm.Owner = this;
                        UchForm.ShowDialog();
                    }
                    catch (InvalidOperationException) { MessageBox.Show("Данного ученика нет в общей базе данных, обратитесь к сотруднику библиотеки!");
                        using (AutorizationForm AForm = new AutorizationForm())
                        {
                            TypeOfAccount = 4;
                            AForm.Owner = this;
                            AForm.ShowDialog();
                        }
                    }
                   
                }
            }
            if (TypeOfAccount == 4)
            {
                this.Validate();
            }
            cheakSistem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            try
            {
                biblioKartDataGridView.CurrentRow.Cells[3].Value = DataBegin.ToString();
                biblioKartDataGridView.CurrentRow.Cells[4].Value = DataEnd.ToString();
                biblioKartDataGridView.CurrentRow.Cells[5].Value = numericUpDown1.Text;
                biblioKartDataGridView.CurrentRow.Cells[6].Value = false;
            }
            catch (NullReferenceException) { MessageBox.Show("Не выбрана книга!"); }
            this.knigiTableAdapter.UpdateTrigger(Convert.ToInt32(numericUpDown1.Text), Convert.ToInt32(biblioKartDataGridView.CurrentRow.Cells[1].Value));
            this.Validate();
            this.uchenikiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biblioBDDataSet);

        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Knigi KnigiForm = new Knigi())
            {
                KnigiForm.Owner = this;
                KnigiForm.ShowDialog();
                KnigiForm.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void cheakSistem()
        {
            DateTime CheakDT = new DateTime();
            bool cheakStatus = new bool();
            for (int i = 0; i < biblioKartDataGridView.Rows.Count - 1; i++)
            {
                try
                {
                    CheakDT = Convert.ToDateTime(biblioKartDataGridView.Rows[i].Cells[4].Value);
                    cheakStatus = Convert.ToBoolean(biblioKartDataGridView.Rows[i].Cells[6].Value);
                }
                catch (InvalidCastException) { }
                if (CheakDT < DateTime.Now.Date && cheakStatus == false)
                {
                    StatusLabl.Text = "Имеется задолжность";
                    StatusLabl.ForeColor = Color.Red;
                    break;
                }
                else
                {
                    StatusLabl.Text = "Задолжности нет";
                    StatusLabl.ForeColor = Color.Green;
                }
            }
        }
        private void очиститьЛичнуюКарточкуУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить личную карточку: " + "\n" + uchenikiDataGridView.CurrentRow.Cells[1].Value.ToString() + "?" + "\nДанное действие необратимо!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.biblioKartTableAdapter.DeleteQuery(Convert.ToInt32(uchenikiDataGridView.CurrentRow.Cells[0].Value));
                    this.Validate();
                    this.tableAdapterManager.UpdateAll(biblioBDDataSet);
                    this.biblioKartTableAdapter.Fill(biblioBDDataSet.BiblioKart);
                }
            }
            catch (NullReferenceException) { MessageBox.Show("Ошибка! Выберете ученика из списка!", "Ошибка удаления!", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }

        private void uchenikiDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            cheakSistem();
            int totalCountofBooks = 0;
            for (int i = 0; i < biblioKartDataGridView.Rows.Count; i++)
            {
                totalCountofBooks += Convert.ToInt32(biblioKartDataGridView.Rows[i].Cells[5].Value);
            }
            textBox2.Text = totalCountofBooks.ToString();
            if (biblioKartDataGridView.Rows.Count == 0)
            {
                StatusLabl.Text = "Карта пуста!";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите изменить статус на 'Возращено'? Данное действие необратимо", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                bool flag = true;
                try
                {
                    flag = (Convert.ToBoolean(this.biblioKartDataGridView.CurrentRow.Cells[6].Value));
                }
                catch (NullReferenceException) { MessageBox.Show("Не выбрана запись в карте!"); }
                if (flag != true)
                {
                    this.biblioKartDataGridView.CurrentRow.Cells[6].Value = true;
                    this.knigiTableAdapter.AddUpdateTrigger((int)this.biblioKartDataGridView.CurrentRow.Cells[5].Value, Convert.ToInt32(this.biblioKartDataGridView.CurrentRow.Cells[1].Value));
                    this.uchenikiBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.biblioBDDataSet);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            uchenikiBindingSource.Filter = null;
            uchenikiTableAdapter.Fill(biblioBDDataSet.Ucheniki);
        }

        private void удалитьДубликатыУченикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Будет выполнен поиск и удаление дублирующих записей", "Удаление дубликатов", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {

                for (int i = 1; i < uchenikiDataGridView.Rows.Count; i++)
                {
                    if ((string)uchenikiDataGridView.Rows[i].Cells[1].Value == (string)uchenikiDataGridView.Rows[i - 1].Cells[1].Value)
                    {
                        if (Convert.ToDateTime(uchenikiDataGridView.Rows[i].Cells[2].Value) == Convert.ToDateTime(uchenikiDataGridView.Rows[i - 1].Cells[2].Value))
                        {
                            if (uchenikiDataGridView.Rows[i].Cells[3].Value.ToString() == uchenikiDataGridView.Rows[i - 1].Cells[3].Value.ToString())
                            {
                                this.uchenikiTableAdapter.DeleteQuery((int)uchenikiDataGridView.Rows[i].Cells[0].Value);
                            }
                        }
                    }
                }
                this.uchenikiTableAdapter.Fill(biblioBDDataSet.Ucheniki);
            }
        }

        public void ExportToExcel(DataGridView NameDVG)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            for (int k = 0; k < NameDVG.Columns.Count; k++)
            {
                ExcelApp.Cells[1, k + 1] = NameDVG.Columns[k].HeaderText.ToString();
            }

            for (int i = 0; i < NameDVG.Rows.Count; i++)
            {
                for (int j = 0; j < NameDVG.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = NameDVG.Rows[i].Cells[j].Value;

                }
            }

            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel(uchenikiDataGridView);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.DialogResult local = MessageBox.Show("Сохранить изменения?", "Завершение работы", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (local == System.Windows.Forms.DialogResult.Yes)
            {
                this.Validate();
                this.tableAdapterManager.UpdateAll(biblioBDDataSet);
            }
            else
            {
                if (local == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void fioserchBox_TextChanged(object sender, EventArgs e)
        {
            uchenikiBindingSource.Filter = "FIO = '" + fioserchBox.Text + "'";
        }

     

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            uchenikiBindingSource.Filter = "Klass = '" + KlassSearchBox.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uchenikiBindingSource.Filter = "Pol = 'М'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uchenikiBindingSource.Filter = "Pol = 'Ж'";
        }

        private void библиотечнаяКартаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel(biblioKartDataGridView);
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarionForm RegFRm = new RegistrarionForm();
            RegFRm.Owner = this;
            RegFRm.ShowDialog();
            RegFRm.StartPosition = FormStartPosition.CenterScreen;
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorizationForm AutoForm = new AutorizationForm();
            AutoForm.Owner = this;
            AutoForm.ShowDialog();
        }

        private void ученикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Полное удаление данных из таблицы! Внимание, данное действие необратимо!", "Полное удаление!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                this.uchenikiTableAdapter.DeletAll();
                this.tableAdapterManager.UpdateAll(biblioBDDataSet);
                this.uchenikiTableAdapter.Fill(biblioBDDataSet.Ucheniki);
            }
        }

        private void книгиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Полное удаление данных из таблицы! Внимание, данное действие необратимо!", "Полное удаление!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                this.knigiTableAdapter.DeletALl();
                this.tableAdapterManager.UpdateAll(biblioBDDataSet);
            }
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Полное удаление данных из таблицы! Внимание, данное действие необратимо!", "Полное удаление!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                this.zakazTableAdapter1.DeletALL();
                this.tableAdapterManager.UpdateAll(biblioBDDataSet);
            }
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this,@"biblio.chm");
        }

        private void toDTP2_CloseUp(object sender, EventArgs e)
        {
            string _maxDate = Convert.ToDateTime(toDTP2.Value).ToString("MM.dd.yyyy"); // Перевод местной даты в интернациональный формат
            string _minDate = Convert.ToDateTime(fromDTP1.Value).ToString("MM.dd.yyyy"); //
            uchenikiBindingSource.Filter = "Vozrast >= #" + _minDate + "# AND Vozrast <= #" + _maxDate + "#";
        }
    }
}
