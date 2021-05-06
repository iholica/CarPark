namespace CarPark
{
    partial class FormDrivers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrivers));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBithDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьВодителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьВодителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВодителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.dateOfBithDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.busDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.driverBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(953, 493);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateOfBithDataGridViewTextBoxColumn
            // 
            this.dateOfBithDataGridViewTextBoxColumn.DataPropertyName = "DateOfBith";
            this.dateOfBithDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dateOfBithDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBithDataGridViewTextBoxColumn.Name = "dateOfBithDataGridViewTextBoxColumn";
            this.dateOfBithDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBithDataGridViewTextBoxColumn.Width = 160;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес проживания";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 220;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Стаж работы";
            this.experienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.ReadOnly = true;
            this.experienceDataGridViewTextBoxColumn.Width = 150;
            // 
            // busDataGridViewTextBoxColumn
            // 
            this.busDataGridViewTextBoxColumn.DataPropertyName = "Bus";
            this.busDataGridViewTextBoxColumn.HeaderText = "Закрепленный автобус";
            this.busDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.busDataGridViewTextBoxColumn.Name = "busDataGridViewTextBoxColumn";
            this.busDataGridViewTextBoxColumn.ReadOnly = true;
            this.busDataGridViewTextBoxColumn.Visible = false;
            this.busDataGridViewTextBoxColumn.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВодителяToolStripMenuItem,
            this.изменитьВодителяToolStripMenuItem,
            this.удалитьВодителяToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 94);
            // 
            // добавитьВодителяToolStripMenuItem
            // 
            this.добавитьВодителяToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.добавитьВодителяToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_plus_24;
            this.добавитьВодителяToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.добавитьВодителяToolStripMenuItem.Name = "добавитьВодителяToolStripMenuItem";
            this.добавитьВодителяToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.добавитьВодителяToolStripMenuItem.Text = "Добавить водителя";
            this.добавитьВодителяToolStripMenuItem.Click += new System.EventHandler(this.добавитьВодителяToolStripMenuItem_Click);
            // 
            // изменитьВодителяToolStripMenuItem
            // 
            this.изменитьВодителяToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.изменитьВодителяToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_pencil_drawing_24;
            this.изменитьВодителяToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.изменитьВодителяToolStripMenuItem.Name = "изменитьВодителяToolStripMenuItem";
            this.изменитьВодителяToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.изменитьВодителяToolStripMenuItem.Text = "Изменить водителя";
            this.изменитьВодителяToolStripMenuItem.Click += new System.EventHandler(this.изменитьВодителяToolStripMenuItem_Click);
            // 
            // удалитьВодителяToolStripMenuItem
            // 
            this.удалитьВодителяToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.удалитьВодителяToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_waste_24;
            this.удалитьВодителяToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.удалитьВодителяToolStripMenuItem.Name = "удалитьВодителяToolStripMenuItem";
            this.удалитьВодителяToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.удалитьВодителяToolStripMenuItem.Text = "Удалить водителя";
            this.удалитьВодителяToolStripMenuItem.Click += new System.EventHandler(this.удалитьВодителяToolStripMenuItem_Click);
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataSource = typeof(CarPark.Driver);
            // 
            // button1
            // 
            this.button1.Image = global::CarPark.Properties.Resources.icons8_plus_24;
            this.button1.Location = new System.Drawing.Point(819, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 26);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Водители автопарка";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьВодителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьВодителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВодителяToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBithDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}