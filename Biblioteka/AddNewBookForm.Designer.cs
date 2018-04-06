namespace Biblioteka
{
    partial class AddNewBookForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label avtorLabel;
            System.Windows.Forms.Label izdatelLabel;
            System.Windows.Forms.Label janrLabel;
            System.Windows.Forms.Label kol_voLabel;
            System.Windows.Forms.Label cena_ShtLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.janrCB = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.knigiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioBDDataSet = new Biblioteka.BiblioBDDataSet();
            this.avtorTextBox = new System.Windows.Forms.TextBox();
            this.izdatelTextBox = new System.Windows.Forms.TextBox();
            this.dataPublikLabel = new System.Windows.Forms.Label();
            this.dataPublikDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kol_voTextBox = new System.Windows.Forms.TextBox();
            this.cena_ShtTextBox = new System.Windows.Forms.TextBox();
            this.knigiTableAdapter = new Biblioteka.BiblioBDDataSetTableAdapters.KnigiTableAdapter();
            this.tableAdapterManager = new Biblioteka.BiblioBDDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            avtorLabel = new System.Windows.Forms.Label();
            izdatelLabel = new System.Windows.Forms.Label();
            janrLabel = new System.Windows.Forms.Label();
            kol_voLabel = new System.Windows.Forms.Label();
            cena_ShtLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(7, 34);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(110, 17);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Наименование:";
            // 
            // avtorLabel
            // 
            avtorLabel.AutoSize = true;
            avtorLabel.Location = new System.Drawing.Point(7, 80);
            avtorLabel.Name = "avtorLabel";
            avtorLabel.Size = new System.Drawing.Size(51, 17);
            avtorLabel.TabIndex = 4;
            avtorLabel.Text = "Автор:";
            // 
            // izdatelLabel
            // 
            izdatelLabel.AutoSize = true;
            izdatelLabel.Location = new System.Drawing.Point(7, 126);
            izdatelLabel.Name = "izdatelLabel";
            izdatelLabel.Size = new System.Drawing.Size(75, 17);
            izdatelLabel.TabIndex = 6;
            izdatelLabel.Text = "Издатель:";
            // 
            // janrLabel
            // 
            janrLabel.AutoSize = true;
            janrLabel.Location = new System.Drawing.Point(7, 172);
            janrLabel.Name = "janrLabel";
            janrLabel.Size = new System.Drawing.Size(49, 17);
            janrLabel.TabIndex = 8;
            janrLabel.Text = "Жанр:";
            // 
            // kol_voLabel
            // 
            kol_voLabel.AutoSize = true;
            kol_voLabel.Location = new System.Drawing.Point(7, 275);
            kol_voLabel.Name = "kol_voLabel";
            kol_voLabel.Size = new System.Drawing.Size(172, 17);
            kol_voLabel.TabIndex = 12;
            kol_voLabel.Text = "Заявленное количество:";
            // 
            // cena_ShtLabel
            // 
            cena_ShtLabel.AutoSize = true;
            cena_ShtLabel.Location = new System.Drawing.Point(7, 321);
            cena_ShtLabel.Name = "cena_ShtLabel";
            cena_ShtLabel.Size = new System.Drawing.Size(65, 17);
            cena_ShtLabel.TabIndex = 14;
            cena_ShtLabel.Text = "Цена/шт";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.janrCB);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(avtorLabel);
            this.groupBox1.Controls.Add(this.avtorTextBox);
            this.groupBox1.Controls.Add(izdatelLabel);
            this.groupBox1.Controls.Add(this.izdatelTextBox);
            this.groupBox1.Controls.Add(janrLabel);
            this.groupBox1.Controls.Add(this.dataPublikLabel);
            this.groupBox1.Controls.Add(this.dataPublikDateTimePicker);
            this.groupBox1.Controls.Add(kol_voLabel);
            this.groupBox1.Controls.Add(this.kol_voTextBox);
            this.groupBox1.Controls.Add(cena_ShtLabel);
            this.groupBox1.Controls.Add(this.cena_ShtTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(261, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "№ п/п: ";
            // 
            // janrCB
            // 
            this.janrCB.FormattingEnabled = true;
            this.janrCB.Items.AddRange(new object[] {
            "Комедия",
            "Драма",
            "Ужасы",
            "Утопия",
            "Антиутопия",
            "Отеч.Классика",
            "Зарубеж.Классика",
            "Научная литература",
            "Учебная литература",
            "Детская литература"});
            this.janrCB.Location = new System.Drawing.Point(32, 192);
            this.janrCB.Name = "janrCB";
            this.janrCB.Size = new System.Drawing.Size(200, 25);
            this.janrCB.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knigiBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(32, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // knigiBindingSource
            // 
            this.knigiBindingSource.DataMember = "Knigi";
            this.knigiBindingSource.DataSource = this.biblioBDDataSet;
            // 
            // biblioBDDataSet
            // 
            this.biblioBDDataSet.DataSetName = "BiblioBDDataSet";
            this.biblioBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtorTextBox
            // 
            this.avtorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knigiBindingSource, "Avtor", true));
            this.avtorTextBox.Location = new System.Drawing.Point(32, 100);
            this.avtorTextBox.Name = "avtorTextBox";
            this.avtorTextBox.Size = new System.Drawing.Size(200, 23);
            this.avtorTextBox.TabIndex = 2;
            // 
            // izdatelTextBox
            // 
            this.izdatelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knigiBindingSource, "Izdatel", true));
            this.izdatelTextBox.Location = new System.Drawing.Point(32, 146);
            this.izdatelTextBox.Name = "izdatelTextBox";
            this.izdatelTextBox.Size = new System.Drawing.Size(200, 23);
            this.izdatelTextBox.TabIndex = 3;
            // 
            // dataPublikLabel
            // 
            this.dataPublikLabel.AutoSize = true;
            this.dataPublikLabel.Location = new System.Drawing.Point(7, 229);
            this.dataPublikLabel.Name = "dataPublikLabel";
            this.dataPublikLabel.Size = new System.Drawing.Size(128, 17);
            this.dataPublikLabel.TabIndex = 10;
            this.dataPublikLabel.Text = "Дата публикации:";
            // 
            // dataPublikDateTimePicker
            // 
            this.dataPublikDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.knigiBindingSource, "DataPublik", true));
            this.dataPublikDateTimePicker.Location = new System.Drawing.Point(32, 249);
            this.dataPublikDateTimePicker.Name = "dataPublikDateTimePicker";
            this.dataPublikDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dataPublikDateTimePicker.TabIndex = 5;
            // 
            // kol_voTextBox
            // 
            this.kol_voTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knigiBindingSource, "Kol_vo", true));
            this.kol_voTextBox.Location = new System.Drawing.Point(32, 295);
            this.kol_voTextBox.Name = "kol_voTextBox";
            this.kol_voTextBox.Size = new System.Drawing.Size(200, 23);
            this.kol_voTextBox.TabIndex = 7;
            // 
            // cena_ShtTextBox
            // 
            this.cena_ShtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knigiBindingSource, "Cena_Sht", true));
            this.cena_ShtTextBox.Location = new System.Drawing.Point(32, 341);
            this.cena_ShtTextBox.Name = "cena_ShtTextBox";
            this.cena_ShtTextBox.Size = new System.Drawing.Size(200, 23);
            this.cena_ShtTextBox.TabIndex = 8;
            // 
            // knigiTableAdapter
            // 
            this.knigiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BiblioKartTableAdapter = null;
            this.tableAdapterManager.BibliotekarTableAdapter = null;
            this.tableAdapterManager.KnigiTableAdapter = this.knigiTableAdapter;
            this.tableAdapterManager.UchenikiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Biblioteka.BiblioBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZakazTableAdapter = null;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(170, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddNewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewBookForm";
            this.Text = "Добавить новую книгу";
            this.Load += new System.EventHandler(this.AddNewBookForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioBDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BiblioBDDataSet biblioBDDataSet;
        private System.Windows.Forms.BindingSource knigiBindingSource;
        private BiblioBDDataSetTableAdapters.KnigiTableAdapter knigiTableAdapter;
        private BiblioBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox janrCB;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox avtorTextBox;
        private System.Windows.Forms.TextBox izdatelTextBox;
        private System.Windows.Forms.Label dataPublikLabel;
        private System.Windows.Forms.DateTimePicker dataPublikDateTimePicker;
        private System.Windows.Forms.TextBox kol_voTextBox;
        private System.Windows.Forms.TextBox cena_ShtTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}