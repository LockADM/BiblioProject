namespace Biblioteka
{
    partial class AddUchenikForm
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
            System.Windows.Forms.Label vozrastLabel;
            System.Windows.Forms.Label klassLabel;
            System.Windows.Forms.Label polLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CloseBttn = new System.Windows.Forms.Button();
            this.AddBttn = new System.Windows.Forms.Button();
            this.klassTextBox = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.biblioBDDataSet = new Biblioteka.BiblioBDDataSet();
            this.uchenikibindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchenikiTableAdapter = new Biblioteka.BiblioBDDataSetTableAdapters.UchenikiTableAdapter();
            this.tableAdapterManager1 = new Biblioteka.BiblioBDDataSetTableAdapters.TableAdapterManager();
            fIOLabel = new System.Windows.Forms.Label();
            vozrastLabel = new System.Windows.Forms.Label();
            klassLabel = new System.Windows.Forms.Label();
            polLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biblioBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchenikibindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(7, 20);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(41, 17);
            fIOLabel.TabIndex = 2;
            fIOLabel.Text = "Фио:";
            // 
            // vozrastLabel
            // 
            vozrastLabel.AutoSize = true;
            vozrastLabel.Location = new System.Drawing.Point(7, 74);
            vozrastLabel.Name = "vozrastLabel";
            vozrastLabel.Size = new System.Drawing.Size(66, 17);
            vozrastLabel.TabIndex = 4;
            vozrastLabel.Text = "Возраст:";
            // 
            // klassLabel
            // 
            klassLabel.AutoSize = true;
            klassLabel.Location = new System.Drawing.Point(4, 120);
            klassLabel.Name = "klassLabel";
            klassLabel.Size = new System.Drawing.Size(51, 17);
            klassLabel.TabIndex = 6;
            klassLabel.Text = "Класс:";
            // 
            // polLabel
            // 
            polLabel.AutoSize = true;
            polLabel.Location = new System.Drawing.Point(4, 166);
            polLabel.Name = "polLabel";
            polLabel.Size = new System.Drawing.Size(38, 17);
            polLabel.TabIndex = 8;
            polLabel.Text = "Пол:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.CloseBttn);
            this.groupBox1.Controls.Add(this.AddBttn);
            this.groupBox1.Controls.Add(this.klassTextBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(fIOLabel);
            this.groupBox1.Controls.Add(this.fIOTextBox);
            this.groupBox1.Controls.Add(vozrastLabel);
            this.groupBox1.Controls.Add(klassLabel);
            this.groupBox1.Controls.Add(polLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(249, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // CloseBttn
            // 
            this.CloseBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBttn.Location = new System.Drawing.Point(7, 227);
            this.CloseBttn.Name = "CloseBttn";
            this.CloseBttn.Size = new System.Drawing.Size(117, 40);
            this.CloseBttn.TabIndex = 2;
            this.CloseBttn.Text = "Закрыть";
            this.CloseBttn.UseVisualStyleBackColor = true;
            this.CloseBttn.Click += new System.EventHandler(this.CloseBttn_Click);
            // 
            // AddBttn
            // 
            this.AddBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBttn.Location = new System.Drawing.Point(125, 227);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(117, 40);
            this.AddBttn.TabIndex = 1;
            this.AddBttn.Text = "Добавить";
            this.AddBttn.UseVisualStyleBackColor = true;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // klassTextBox
            // 
            this.klassTextBox.Location = new System.Drawing.Point(7, 140);
            this.klassTextBox.Mask = "00a";
            this.klassTextBox.Name = "klassTextBox";
            this.klassTextBox.Size = new System.Drawing.Size(120, 23);
            this.klassTextBox.TabIndex = 10;
            this.klassTextBox.Text = "01А";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.comboBox1.Location = new System.Drawing.Point(7, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 25);
            this.comboBox1.TabIndex = 9;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.Location = new System.Drawing.Point(7, 40);
            this.fIOTextBox.MaxLength = 20;
            this.fIOTextBox.Multiline = true;
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(213, 31);
            this.fIOTextBox.TabIndex = 3;
            // 
            // biblioBDDataSet
            // 
            this.biblioBDDataSet.DataSetName = "BiblioBDDataSet";
            this.biblioBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uchenikibindingSource
            // 
            this.uchenikibindingSource.DataMember = "Ucheniki";
            this.uchenikibindingSource.DataSource = this.biblioBDDataSet;
            // 
            // uchenikiTableAdapter
            // 
            this.uchenikiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BiblioKartTableAdapter = null;
            this.tableAdapterManager1.BibliotekarTableAdapter = null;
            this.tableAdapterManager1.KnigiTableAdapter = null;
            this.tableAdapterManager1.UchenikiTableAdapter = this.uchenikiTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Biblioteka.BiblioBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ZakazTableAdapter = null;
            // 
            // AddUchenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 296);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUchenikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить нового ученика";
            this.Load += new System.EventHandler(this.AddUchenikForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biblioBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchenikibindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BiblioBDDataSet biblioBDDataSet;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddBttn;
        private System.Windows.Forms.Button CloseBttn;
        private System.Windows.Forms.MaskedTextBox klassTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource uchenikibindingSource;
        private BiblioBDDataSetTableAdapters.UchenikiTableAdapter uchenikiTableAdapter;
        private BiblioBDDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}