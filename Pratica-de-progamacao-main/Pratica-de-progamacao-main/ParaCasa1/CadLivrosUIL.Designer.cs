namespace ParaCasa1
{
    partial class CadLivrosUIL
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLivroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDLivrosDataSet = new ParaCasa1.BDLivrosDataSet();
            this.tabLivroTableAdapter = new ParaCasa1.BDLivrosDataSetTableAdapters.TabLivroTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLivroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLivrosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(420, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "GERAR XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.editoraDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabLivroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(872, 232);
            this.dataGridView1.TabIndex = 2;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            // 
            // editoraDataGridViewTextBoxColumn
            // 
            this.editoraDataGridViewTextBoxColumn.DataPropertyName = "editora";
            this.editoraDataGridViewTextBoxColumn.HeaderText = "editora";
            this.editoraDataGridViewTextBoxColumn.Name = "editoraDataGridViewTextBoxColumn";
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            // 
            // tabLivroBindingSource
            // 
            this.tabLivroBindingSource.DataMember = "TabLivro";
            this.tabLivroBindingSource.DataSource = this.bDLivrosDataSet;
            // 
            // bDLivrosDataSet
            // 
            this.bDLivrosDataSet.DataSetName = "BDLivrosDataSet";
            this.bDLivrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabLivroTableAdapter
            // 
            this.tabLivroTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(480, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(404, 92);
            this.button2.TabIndex = 3;
            this.button2.Text = "Gerar JSON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadLivrosUIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "CadLivrosUIL";
            this.Text = "CADASTRO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadLivrosUIL_FormClosed);
            this.Load += new System.EventHandler(this.CadLivrosUIL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLivroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLivrosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDLivrosDataSet bDLivrosDataSet;
        private System.Windows.Forms.BindingSource tabLivroBindingSource;
        private BDLivrosDataSetTableAdapters.TabLivroTableAdapter tabLivroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}

