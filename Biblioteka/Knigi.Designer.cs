namespace Biblioteka
{
    partial class Knigi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Knigi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.izdatelSearchBox = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.janrSearchbox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.avtorSearchBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPTo = new System.Windows.Forms.DateTimePicker();
            this.DTPFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.knigiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.knigiDataGridView = new System.Windows.Forms.DataGridView();
            this.iDKnigiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdatelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.janrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPublikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaShtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KnigiBS = new System.Windows.Forms.BindingSource(this.components);
            this.biblioBDDataSet = new Biblioteka.BiblioBDDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЖанрамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЖанровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BiblioBS = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Biblioteka.BiblioBDDataSetTableAdapters.TableAdapterManager();
            this.bibliotekarTableAdapter = new Biblioteka.BiblioBDDataSetTableAdapters.BibliotekarTableAdapter();
            this.knigiTableAdapter = new Biblioteka.BiblioBDDataSetTableAdapters.KnigiTableAdapter();
            this.zakazTableAdapter = new Biblioteka.BiblioBDDataSetTableAdapters.ZakazTableAdapter();
            this.zakazBS = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingNavigator)).BeginInit();
            this.knigiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knigiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KnigiBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioBDDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BiblioBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.knigiBindingNavigator);
            this.groupBox1.Controls.Add(this.knigiDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список книг";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(520, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 92);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Добавление заказа";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(206, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 23);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(6, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 160);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтры:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.izdatelSearchBox);
            this.groupBox8.Location = new System.Drawing.Point(230, 115);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(272, 40);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Издатель:";
            // 
            // izdatelSearchBox
            // 
            this.izdatelSearchBox.Location = new System.Drawing.Point(82, 12);
            this.izdatelSearchBox.Name = "izdatelSearchBox";
            this.izdatelSearchBox.Size = new System.Drawing.Size(130, 23);
            this.izdatelSearchBox.TabIndex = 4;
            this.izdatelSearchBox.TextChanged += new System.EventHandler(this.izdatelSearchBox_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.janrSearchbox);
            this.groupBox7.Location = new System.Drawing.Point(230, 69);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(272, 40);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Жанр:";
            // 
            // janrSearchbox
            // 
            this.janrSearchbox.Location = new System.Drawing.Point(82, 11);
            this.janrSearchbox.Name = "janrSearchbox";
            this.janrSearchbox.Size = new System.Drawing.Size(130, 23);
            this.janrSearchbox.TabIndex = 3;
            this.janrSearchbox.TextChanged += new System.EventHandler(this.janrSearchbox_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.avtorSearchBox);
            this.groupBox6.Location = new System.Drawing.Point(230, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(272, 44);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Автор:";
            // 
            // avtorSearchBox
            // 
            this.avtorSearchBox.Location = new System.Drawing.Point(82, 15);
            this.avtorSearchBox.Name = "avtorSearchBox";
            this.avtorSearchBox.Size = new System.Drawing.Size(130, 23);
            this.avtorSearchBox.TabIndex = 2;
            this.avtorSearchBox.TextChanged += new System.EventHandler(this.avtorSearchBox_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.DTPTo);
            this.groupBox5.Controls.Add(this.DTPFrom);
            this.groupBox5.Location = new System.Drawing.Point(6, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 132);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Дата публикации:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "По:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "С:";
            // 
            // DTPTo
            // 
            this.DTPTo.Location = new System.Drawing.Point(6, 92);
            this.DTPTo.Name = "DTPTo";
            this.DTPTo.Size = new System.Drawing.Size(200, 23);
            this.DTPTo.TabIndex = 1;
            this.DTPTo.ValueChanged += new System.EventHandler(this.DTPTo_ValueChanged);
            // 
            // DTPFrom
            // 
            this.DTPFrom.Location = new System.Drawing.Point(6, 46);
            this.DTPFrom.Name = "DTPFrom";
            this.DTPFrom.Size = new System.Drawing.Size(200, 23);
            this.DTPFrom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalBox);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(520, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 62);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Общая цена:";
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(97, 22);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(130, 23);
            this.TotalBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 0;
            // 
            // knigiBindingNavigator
            // 
            this.knigiBindingNavigator.AddNewItem = null;
            this.knigiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.knigiBindingNavigator.DeleteItem = null;
            this.knigiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.knigiBindingNavigator.Location = new System.Drawing.Point(3, 19);
            this.knigiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.knigiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.knigiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.knigiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.knigiBindingNavigator.Name = "knigiBindingNavigator";
            this.knigiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.knigiBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.knigiBindingNavigator.Size = new System.Drawing.Size(826, 25);
            this.knigiBindingNavigator.TabIndex = 1;
            this.knigiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // knigiDataGridView
            // 
            this.knigiDataGridView.AutoGenerateColumns = false;
            this.knigiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knigiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKnigiDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.avtorDataGridViewTextBoxColumn,
            this.izdatelDataGridViewTextBoxColumn,
            this.janrDataGridViewTextBoxColumn,
            this.dataPublikDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn,
            this.cenaShtDataGridViewTextBoxColumn});
            this.knigiDataGridView.DataSource = this.KnigiBS;
            this.knigiDataGridView.Location = new System.Drawing.Point(6, 52);
            this.knigiDataGridView.Name = "knigiDataGridView";
            this.knigiDataGridView.Size = new System.Drawing.Size(820, 220);
            this.knigiDataGridView.TabIndex = 0;
            this.knigiDataGridView.SelectionChanged += new System.EventHandler(this.knigiDataGridView_SelectionChanged);
            // 
            // iDKnigiDataGridViewTextBoxColumn
            // 
            this.iDKnigiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDKnigiDataGridViewTextBoxColumn.DataPropertyName = "ID_Knigi";
            this.iDKnigiDataGridViewTextBoxColumn.HeaderText = "№ п/п";
            this.iDKnigiDataGridViewTextBoxColumn.Name = "iDKnigiDataGridViewTextBoxColumn";
            this.iDKnigiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avtorDataGridViewTextBoxColumn
            // 
            this.avtorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.avtorDataGridViewTextBoxColumn.DataPropertyName = "Avtor";
            this.avtorDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.avtorDataGridViewTextBoxColumn.Name = "avtorDataGridViewTextBoxColumn";
            this.avtorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izdatelDataGridViewTextBoxColumn
            // 
            this.izdatelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.izdatelDataGridViewTextBoxColumn.DataPropertyName = "Izdatel";
            this.izdatelDataGridViewTextBoxColumn.HeaderText = "Издатель";
            this.izdatelDataGridViewTextBoxColumn.Name = "izdatelDataGridViewTextBoxColumn";
            this.izdatelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // janrDataGridViewTextBoxColumn
            // 
            this.janrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.janrDataGridViewTextBoxColumn.DataPropertyName = "Janr";
            this.janrDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.janrDataGridViewTextBoxColumn.Name = "janrDataGridViewTextBoxColumn";
            this.janrDataGridViewTextBoxColumn.ReadOnly = true;
            this.janrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataPublikDataGridViewTextBoxColumn
            // 
            this.dataPublikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataPublikDataGridViewTextBoxColumn.DataPropertyName = "DataPublik";
            this.dataPublikDataGridViewTextBoxColumn.HeaderText = "Дата публикации";
            this.dataPublikDataGridViewTextBoxColumn.Name = "dataPublikDataGridViewTextBoxColumn";
            this.dataPublikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolvoDataGridViewTextBoxColumn
            // 
            this.kolvoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kolvoDataGridViewTextBoxColumn.DataPropertyName = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.kolvoDataGridViewTextBoxColumn.Name = "kolvoDataGridViewTextBoxColumn";
            // 
            // cenaShtDataGridViewTextBoxColumn
            // 
            this.cenaShtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cenaShtDataGridViewTextBoxColumn.DataPropertyName = "Cena_Sht";
            this.cenaShtDataGridViewTextBoxColumn.HeaderText = "Цена/шт";
            this.cenaShtDataGridViewTextBoxColumn.Name = "cenaShtDataGridViewTextBoxColumn";
            this.cenaShtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // KnigiBS
            // 
            this.KnigiBS.DataMember = "Knigi";
            this.KnigiBS.DataSource = this.biblioBDDataSet;
            // 
            // biblioBDDataSet
            // 
            this.biblioBDDataSet.DataSetName = "BiblioBDDataSet";
            this.biblioBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментыToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.графикиToolStripMenuItem,
            this.настройкаToolStripMenuItem});
            this.инструментыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("инструментыToolStripMenuItem.Image")));
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
            this.экспортToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("экспортToolStripMenuItem.Image")));
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excelToolStripMenuItem.Image")));
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заказыToolStripMenuItem.Image")));
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЖанрамToolStripMenuItem});
            this.графикиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("графикиToolStripMenuItem.Image")));
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.графикиToolStripMenuItem.Text = "Статистика";
            // 
            // поЖанрамToolStripMenuItem
            // 
            this.поЖанрамToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("поЖанрамToolStripMenuItem.Image")));
            this.поЖанрамToolStripMenuItem.Name = "поЖанрамToolStripMenuItem";
            this.поЖанрамToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.поЖанрамToolStripMenuItem.Text = "По жанрам";
            this.поЖанрамToolStripMenuItem.Click += new System.EventHandler(this.поЖанрамToolStripMenuItem_Click);
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокЖанровToolStripMenuItem,
            this.удалитьЗаписьToolStripMenuItem});
            this.настройкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("настройкаToolStripMenuItem.Image")));
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // списокЖанровToolStripMenuItem
            // 
            this.списокЖанровToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("списокЖанровToolStripMenuItem.Image")));
            this.списокЖанровToolStripMenuItem.Name = "списокЖанровToolStripMenuItem";
            this.списокЖанровToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.списокЖанровToolStripMenuItem.Text = "Добавить книгу";
            this.списокЖанровToolStripMenuItem.Click += new System.EventHandler(this.списокЖанровToolStripMenuItem_Click);
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьЗаписьToolStripMenuItem.Image")));
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удаление дубликатов";
            this.удалитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаписьToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("помощьToolStripMenuItem.Image")));
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // BiblioBS
            // 
            this.BiblioBS.DataMember = "Bibliotekar";
            this.BiblioBS.DataSource = this.biblioBDDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BiblioKartTableAdapter = null;
            this.tableAdapterManager.BibliotekarTableAdapter = this.bibliotekarTableAdapter;
            this.tableAdapterManager.KnigiTableAdapter = this.knigiTableAdapter;
            this.tableAdapterManager.UchenikiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Biblioteka.BiblioBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZakazTableAdapter = this.zakazTableAdapter;
            // 
            // bibliotekarTableAdapter
            // 
            this.bibliotekarTableAdapter.ClearBeforeFill = true;
            // 
            // knigiTableAdapter
            // 
            this.knigiTableAdapter.ClearBeforeFill = true;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // zakazBS
            // 
            this.zakazBS.DataMember = "Zakaz";
            this.zakazBS.DataSource = this.biblioBDDataSet;
            // 
            // Knigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Knigi";
            this.Text = "Книги";
            this.Activated += new System.EventHandler(this.Knigi_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Knigi_FormClosing);
            this.Load += new System.EventHandler(this.Knigi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingNavigator)).EndInit();
            this.knigiBindingNavigator.ResumeLayout(false);
            this.knigiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knigiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KnigiBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioBDDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BiblioBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BiblioBDDataSet biblioBDDataSet;
        private System.Windows.Forms.BindingNavigator knigiBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView knigiDataGridView;
        private System.Windows.Forms.BindingSource KnigiBS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TotalBox;
        private BiblioBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BiblioBDDataSetTableAdapters.KnigiTableAdapter knigiTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource zakazBS;
        private BiblioBDDataSetTableAdapters.ZakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.BindingSource BiblioBS;
        private BiblioBDDataSetTableAdapters.BibliotekarTableAdapter bibliotekarTableAdapter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker DTPTo;
        private System.Windows.Forms.DateTimePicker DTPFrom;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox izdatelSearchBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox janrSearchbox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox avtorSearchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЖанровToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKnigiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avtorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdatelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn janrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPublikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaShtDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЖанрамToolStripMenuItem;
    }
}