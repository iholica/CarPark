namespace CarPark
{
    partial class FormConditions
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьСостояниеАвтобусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСостояниеАвтобусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСостояниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.busDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.conditionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(304, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСостояниеАвтобусаToolStripMenuItem,
            this.изменитьСостояниеАвтобусаToolStripMenuItem,
            this.удалитьСостояниеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 94);
            // 
            // добавитьСостояниеАвтобусаToolStripMenuItem
            // 
            this.добавитьСостояниеАвтобусаToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_plus_24;
            this.добавитьСостояниеАвтобусаToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.добавитьСостояниеАвтобусаToolStripMenuItem.Name = "добавитьСостояниеАвтобусаToolStripMenuItem";
            this.добавитьСостояниеАвтобусаToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.добавитьСостояниеАвтобусаToolStripMenuItem.Text = "Добавить состояние ";
            this.добавитьСостояниеАвтобусаToolStripMenuItem.Click += new System.EventHandler(this.добавитьСостояниеАвтобусаToolStripMenuItem_Click);
            // 
            // изменитьСостояниеАвтобусаToolStripMenuItem
            // 
            this.изменитьСостояниеАвтобусаToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_pencil_drawing_24;
            this.изменитьСостояниеАвтобусаToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.изменитьСостояниеАвтобусаToolStripMenuItem.Name = "изменитьСостояниеАвтобусаToolStripMenuItem";
            this.изменитьСостояниеАвтобусаToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.изменитьСостояниеАвтобусаToolStripMenuItem.Text = "Изменить состояние ";
            this.изменитьСостояниеАвтобусаToolStripMenuItem.Click += new System.EventHandler(this.изменитьСостояниеАвтобусаToolStripMenuItem_Click);
            // 
            // удалитьСостояниеToolStripMenuItem
            // 
            this.удалитьСостояниеToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_waste_24;
            this.удалитьСостояниеToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.удалитьСостояниеToolStripMenuItem.Name = "удалитьСостояниеToolStripMenuItem";
            this.удалитьСостояниеToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.удалитьСостояниеToolStripMenuItem.Text = "Удалить состояние";
            this.удалитьСостояниеToolStripMenuItem.Click += new System.EventHandler(this.удалитьСостояниеToolStripMenuItem_Click);
            // 
            // conditionBindingSource
            // 
            this.conditionBindingSource.DataSource = typeof(CarPark.Condition);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название состояния автобуса";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // busDataGridViewTextBoxColumn
            // 
            this.busDataGridViewTextBoxColumn.DataPropertyName = "Bus";
            this.busDataGridViewTextBoxColumn.HeaderText = "Bus";
            this.busDataGridViewTextBoxColumn.Name = "busDataGridViewTextBoxColumn";
            this.busDataGridViewTextBoxColumn.ReadOnly = true;
            this.busDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 206);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormConditions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Состояние автобусов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource conditionBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСостояниеАвтобусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСостояниеАвтобусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСостояниеToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busDataGridViewTextBoxColumn;
    }
}