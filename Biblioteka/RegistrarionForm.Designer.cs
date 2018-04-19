namespace Biblioteka
{
    partial class RegistrarionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label data_RojdeniyaLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label1;
            this.biblioBDDataSet = new Biblioteka.BiblioBDDataSet();
            this.bibliotekarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekarTableAdapter = new Biblioteka.BiblioBDDataSetTableAdapters.BibliotekarTableAdapter();
            this.tableAdapterManager = new Biblioteka.BiblioBDDataSetTableAdapters.TableAdapterManager();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.data_RojdeniyaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseBttn = new System.Windows.Forms.Button();
            this.AddBttn = new System.Windows.Forms.Button();
            fIOLabel = new System.Windows.Forms.Label();
            data_RojdeniyaLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.biblioBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekarBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(20, 6);
            fIOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(41, 17);
            fIOLabel.TabIndex = 3;
            fIOLabel.Text = "Фио:";
            // 
            // data_RojdeniyaLabel
            // 
            data_RojdeniyaLabel.AutoSize = true;
            data_RojdeniyaLabel.Location = new System.Drawing.Point(20, 54);
            data_RojdeniyaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_RojdeniyaLabel.Name = "data_RojdeniyaLabel";
            data_RojdeniyaLabel.Size = new System.Drawing.Size(111, 17);
            data_RojdeniyaLabel.TabIndex = 5;
            data_RojdeniyaLabel.Text = "Дата рождения";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(20, 102);
            loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(118, 17);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "Идентификатор:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(20, 146);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(61, 17);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 194);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 17);
            label1.TabIndex = 12;
            label1.Text = "Тип учетной записи";
            // 
            // biblioBDDataSet
            // 
            this.biblioBDDataSet.DataSetName = "BiblioBDDataSet";
            this.biblioBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotekarBindingSource
            // 
            this.bibliotekarBindingSource.DataMember = "Bibliotekar";
            this.bibliotekarBindingSource.DataSource = this.biblioBDDataSet;
            // 
            // bibliotekarTableAdapter
            // 
            this.bibliotekarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BiblioKartTableAdapter = null;
            this.tableAdapterManager.BibliotekarTableAdapter = this.bibliotekarTableAdapter;
            this.tableAdapterManager.KnigiTableAdapter = null;
            this.tableAdapterManager.UchenikiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Biblioteka.BiblioBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZakazTableAdapter = null;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bibliotekarBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(23, 27);
            this.fIOTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(265, 23);
            this.fIOTextBox.TabIndex = 4;
            // 
            // data_RojdeniyaDateTimePicker
            // 
            this.data_RojdeniyaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bibliotekarBindingSource, "Data_Rojdeniya", true));
            this.data_RojdeniyaDateTimePicker.Location = new System.Drawing.Point(23, 75);
            this.data_RojdeniyaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.data_RojdeniyaDateTimePicker.Name = "data_RojdeniyaDateTimePicker";
            this.data_RojdeniyaDateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.data_RojdeniyaDateTimePicker.TabIndex = 6;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bibliotekarBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(23, 119);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(265, 23);
            this.loginTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bibliotekarBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(23, 167);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(265, 23);
            this.passwordTextBox.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(fIOLabel);
            this.panel1.Controls.Add(loginLabel);
            this.panel1.Controls.Add(data_RojdeniyaLabel);
            this.panel1.Controls.Add(this.loginTextBox);
            this.panel1.Controls.Add(passwordLabel);
            this.panel1.Controls.Add(this.fIOTextBox);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.data_RojdeniyaDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 249);
            this.panel1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Библиотекарь",
            "Ученик",
            "Администратор"});
            this.comboBox1.Location = new System.Drawing.Point(23, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 25);
            this.comboBox1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CloseBttn);
            this.panel2.Controls.Add(this.AddBttn);
            this.panel2.Location = new System.Drawing.Point(12, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 53);
            this.panel2.TabIndex = 12;
            // 
            // CloseBttn
            // 
            this.CloseBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBttn.Location = new System.Drawing.Point(23, 3);
            this.CloseBttn.Name = "CloseBttn";
            this.CloseBttn.Size = new System.Drawing.Size(99, 44);
            this.CloseBttn.TabIndex = 1;
            this.CloseBttn.Text = "Закрыть";
            this.CloseBttn.UseVisualStyleBackColor = true;
            this.CloseBttn.Click += new System.EventHandler(this.CloseBttn_Click);
            // 
            // AddBttn
            // 
            this.AddBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBttn.Location = new System.Drawing.Point(189, 3);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(99, 44);
            this.AddBttn.TabIndex = 0;
            this.AddBttn.Text = "Добавить";
            this.AddBttn.UseVisualStyleBackColor = true;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // RegistrarionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 327);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarionForm";
            this.Text = "Добавление нового пользователя";
            this.Load += new System.EventHandler(this.RegistrarionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biblioBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekarBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BiblioBDDataSet biblioBDDataSet;
        private System.Windows.Forms.BindingSource bibliotekarBindingSource;
        private BiblioBDDataSetTableAdapters.BibliotekarTableAdapter bibliotekarTableAdapter;
        private BiblioBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.DateTimePicker data_RojdeniyaDateTimePicker;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CloseBttn;
        private System.Windows.Forms.Button AddBttn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}