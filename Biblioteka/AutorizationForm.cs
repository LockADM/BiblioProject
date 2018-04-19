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
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }
        Form1 main;

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblioBDDataSet.Bibliotekar". При необходимости она может быть перемещена или удалена.
            this.bibliotekarTableAdapter.Fill(this.biblioBDDataSet.Bibliotekar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main = this.Owner as Form1;
            int HashPass = textBox2.Text.GetHashCode();
            int HashPassDB = 0;
            try
            {
                HashPassDB = (int)this.bibliotekarTableAdapter.GetPassword(textBox1.Text);
                if (HashPass == HashPassDB)
                {
                    main.autorizationFlag = true;
                    main.toolStripStatusLabel3.Text = this.bibliotekarTableAdapter.GetFio(textBox1.Text);
                    main.tab_nomer = (int)this.bibliotekarTableAdapter.GetTabNomer(textBox1.Text);
                    main.TypeOfAccount = (int)this.bibliotekarTableAdapter.GetType(textBox1.Text);
                    this.Close();
                }
            }
            catch (Exception) { MessageBox.Show("Неверные идентификатор/пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
