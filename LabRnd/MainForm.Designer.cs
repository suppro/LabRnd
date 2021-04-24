
namespace LabRnd
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbResource = new System.Windows.Forms.ComboBox();
            this.dataResouceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataResouce = new LabRnd.DataResouce();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valMin = new System.Windows.Forms.TextBox();
            this.valMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultRnd = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberrndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangemaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataHistory = new LabRnd.DataHistory();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTable1TableAdapter = new LabRnd.DataHistoryTableAdapters.DataTable1TableAdapter();
            this.resourceTableAdapter = new LabRnd.DataResouceTableAdapters.ResourceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataResouceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataResouce)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбрать ресурс";
            // 
            // cbResource
            // 
            this.cbResource.DataSource = this.dataResouceBindingSource;
            this.cbResource.DisplayMember = "name";
            this.cbResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbResource.FormattingEnabled = true;
            this.cbResource.Location = new System.Drawing.Point(15, 46);
            this.cbResource.Name = "cbResource";
            this.cbResource.Size = new System.Drawing.Size(296, 37);
            this.cbResource.TabIndex = 1;
            this.cbResource.ValueMember = "id";
            // 
            // dataResouceBindingSource
            // 
            this.dataResouceBindingSource.DataMember = "Resource";
            this.dataResouceBindingSource.DataSource = this.dataResouce;
            // 
            // dataResouce
            // 
            this.dataResouce.DataSetName = "DataResouce";
            this.dataResouce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Задать диапазон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "от";
            // 
            // valMin
            // 
            this.valMin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.valMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valMin.Location = new System.Drawing.Point(56, 118);
            this.valMin.Name = "valMin";
            this.valMin.Size = new System.Drawing.Size(100, 34);
            this.valMin.TabIndex = 4;
            // 
            // valMax
            // 
            this.valMax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.valMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valMax.Location = new System.Drawing.Point(212, 118);
            this.valMax.Name = "valMax";
            this.valMax.Size = new System.Drawing.Size(100, 34);
            this.valMax.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(165, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "до";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.resultRnd);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.valMax);
            this.panel1.Controls.Add(this.cbResource);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.valMin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 491);
            this.panel1.TabIndex = 7;
            // 
            // resultRnd
            // 
            this.resultRnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultRnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultRnd.Location = new System.Drawing.Point(15, 195);
            this.resultRnd.Name = "resultRnd";
            this.resultRnd.Size = new System.Drawing.Size(297, 81);
            this.resultRnd.TabIndex = 8;
            this.resultRnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(16, 158);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(296, 34);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Генерировать число";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.getRndNumber);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.dgvHistory);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(351, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 491);
            this.panel2.TabIndex = 8;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AutoGenerateColumns = false;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.numberrndDataGridViewTextBoxColumn,
            this.rangeminDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rangemaxDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dgvHistory.DataSource = this.dataHistoryBindingSource;
            this.dgvHistory.Location = new System.Drawing.Point(15, 46);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(753, 432);
            this.dgvHistory.TabIndex = 1;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberrndDataGridViewTextBoxColumn
            // 
            this.numberrndDataGridViewTextBoxColumn.DataPropertyName = "number_rnd";
            this.numberrndDataGridViewTextBoxColumn.HeaderText = "number_rnd";
            this.numberrndDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberrndDataGridViewTextBoxColumn.Name = "numberrndDataGridViewTextBoxColumn";
            this.numberrndDataGridViewTextBoxColumn.Width = 125;
            // 
            // rangeminDataGridViewTextBoxColumn
            // 
            this.rangeminDataGridViewTextBoxColumn.DataPropertyName = "range_min";
            this.rangeminDataGridViewTextBoxColumn.HeaderText = "range_min";
            this.rangeminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rangeminDataGridViewTextBoxColumn.Name = "rangeminDataGridViewTextBoxColumn";
            this.rangeminDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // rangemaxDataGridViewTextBoxColumn
            // 
            this.rangemaxDataGridViewTextBoxColumn.DataPropertyName = "range_max";
            this.rangemaxDataGridViewTextBoxColumn.HeaderText = "range_max";
            this.rangemaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rangemaxDataGridViewTextBoxColumn.Name = "rangemaxDataGridViewTextBoxColumn";
            this.rangemaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "result";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataHistoryBindingSource
            // 
            this.dataHistoryBindingSource.DataMember = "DataTable1";
            this.dataHistoryBindingSource.DataSource = this.dataHistory;
            // 
            // dataHistory
            // 
            this.dataHistory.DataSetName = "DataHistory";
            this.dataHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "История генераций";
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // resourceTableAdapter
            // 
            this.resourceTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "LabRnd";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResouceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataResouce)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbResource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valMin;
        private System.Windows.Forms.TextBox valMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resultRnd;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberrndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangemaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataHistoryBindingSource;
        private DataHistory dataHistory;
        private DataHistoryTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataResouceBindingSource;
        private DataResouce dataResouce;
        private DataResouceTableAdapters.ResourceTableAdapter resourceTableAdapter;
    }
}

