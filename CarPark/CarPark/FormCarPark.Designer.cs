namespace CarPark
{
    partial class FormCarPark
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.информацияПоЗапросуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыАвтобусовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.состояниеАвтобусовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свободныеАвтобусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автобусыВРейсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автобусыВРемонтеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списанныеАвтобусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeBusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.governmentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeBusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.typeBusDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.numberOfSeatsDataGridViewTextBoxColumn,
            this.governmentNumberDataGridViewTextBoxColumn,
            this.driverDataGridViewTextBoxColumn,
            this.idTypeBusDataGridViewTextBoxColumn,
            this.idConditionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.busBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(962, 554);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 50);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.информацияПоЗапросуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // информацияПоЗапросуToolStripMenuItem
            // 
            this.информацияПоЗапросуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свободныеАвтобусыToolStripMenuItem,
            this.автобусыВРейсеToolStripMenuItem,
            this.автобусыВРемонтеToolStripMenuItem,
            this.списанныеАвтобусыToolStripMenuItem});
            this.информацияПоЗапросуToolStripMenuItem.Image = global::CarPark.Properties.Resources.search;
            this.информацияПоЗапросуToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.информацияПоЗапросуToolStripMenuItem.Name = "информацияПоЗапросуToolStripMenuItem";
            this.информацияПоЗапросуToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.информацияПоЗапросуToolStripMenuItem.Text = "Информация по запросу";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.водителиToolStripMenuItem,
            this.типыАвтобусовToolStripMenuItem,
            this.состояниеАвтобусовToolStripMenuItem});
            this.справочникиToolStripMenuItem.Image = global::CarPark.Properties.Resources.files;
            this.справочникиToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(131, 28);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // водителиToolStripMenuItem
            // 
            this.водителиToolStripMenuItem.Image = global::CarPark.Properties.Resources.driver;
            this.водителиToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.водителиToolStripMenuItem.Name = "водителиToolStripMenuItem";
            this.водителиToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.водителиToolStripMenuItem.Text = "Водители";
            this.водителиToolStripMenuItem.Click += new System.EventHandler(this.водителиToolStripMenuItem_Click);
            // 
            // типыАвтобусовToolStripMenuItem
            // 
            this.типыАвтобусовToolStripMenuItem.Image = global::CarPark.Properties.Resources.bus;
            this.типыАвтобусовToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.типыАвтобусовToolStripMenuItem.Name = "типыАвтобусовToolStripMenuItem";
            this.типыАвтобусовToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.типыАвтобусовToolStripMenuItem.Text = "Типы автобусов";
            // 
            // состояниеАвтобусовToolStripMenuItem
            // 
            this.состояниеАвтобусовToolStripMenuItem.Image = global::CarPark.Properties.Resources.pin;
            this.состояниеАвтобусовToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.состояниеАвтобусовToolStripMenuItem.Name = "состояниеАвтобусовToolStripMenuItem";
            this.состояниеАвтобусовToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.состояниеАвтобусовToolStripMenuItem.Text = "Состояние автобусов";
            // 
            // свободныеАвтобусыToolStripMenuItem
            // 
            this.свободныеАвтобусыToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_delivery_time_24;
            this.свободныеАвтобусыToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.свободныеАвтобусыToolStripMenuItem.Name = "свободныеАвтобусыToolStripMenuItem";
            this.свободныеАвтобусыToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.свободныеАвтобусыToolStripMenuItem.Text = "Свободные автобусы";
            // 
            // автобусыВРейсеToolStripMenuItem
            // 
            this.автобусыВРейсеToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_three_way_direction_24;
            this.автобусыВРейсеToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.автобусыВРейсеToolStripMenuItem.Name = "автобусыВРейсеToolStripMenuItem";
            this.автобусыВРейсеToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.автобусыВРейсеToolStripMenuItem.Text = "Автобусы в рейсе";
            // 
            // автобусыВРемонтеToolStripMenuItem
            // 
            this.автобусыВРемонтеToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_maintenance_24;
            this.автобусыВРемонтеToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.автобусыВРемонтеToolStripMenuItem.Name = "автобусыВРемонтеToolStripMenuItem";
            this.автобусыВРемонтеToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.автобусыВРемонтеToolStripMenuItem.Text = "Автобусы в ремонте";
            // 
            // списанныеАвтобусыToolStripMenuItem
            // 
            this.списанныеАвтобусыToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_sync_settings_24;
            this.списанныеАвтобусыToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.списанныеАвтобусыToolStripMenuItem.Name = "списанныеАвтобусыToolStripMenuItem";
            this.списанныеАвтобусыToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.списанныеАвтобусыToolStripMenuItem.Text = "Списанные автобусы";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Марка автобуса";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeBusDataGridViewTextBoxColumn
            // 
            this.typeBusDataGridViewTextBoxColumn.DataPropertyName = "TypeBus";
            this.typeBusDataGridViewTextBoxColumn.HeaderText = "Тип автобуса";
            this.typeBusDataGridViewTextBoxColumn.Name = "typeBusDataGridViewTextBoxColumn";
            this.typeBusDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeBusDataGridViewTextBoxColumn.Width = 130;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Width = 130;
            // 
            // numberOfSeatsDataGridViewTextBoxColumn
            // 
            this.numberOfSeatsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.HeaderText = "Количество мест";
            this.numberOfSeatsDataGridViewTextBoxColumn.Name = "numberOfSeatsDataGridViewTextBoxColumn";
            this.numberOfSeatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfSeatsDataGridViewTextBoxColumn.Width = 150;
            // 
            // governmentNumberDataGridViewTextBoxColumn
            // 
            this.governmentNumberDataGridViewTextBoxColumn.DataPropertyName = "GovernmentNumber";
            this.governmentNumberDataGridViewTextBoxColumn.HeaderText = "Государственный номер";
            this.governmentNumberDataGridViewTextBoxColumn.Name = "governmentNumberDataGridViewTextBoxColumn";
            this.governmentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.governmentNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // driverDataGridViewTextBoxColumn
            // 
            this.driverDataGridViewTextBoxColumn.DataPropertyName = "Driver";
            this.driverDataGridViewTextBoxColumn.HeaderText = "Водители";
            this.driverDataGridViewTextBoxColumn.Name = "driverDataGridViewTextBoxColumn";
            this.driverDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverDataGridViewTextBoxColumn.Width = 200;
            // 
            // idTypeBusDataGridViewTextBoxColumn
            // 
            this.idTypeBusDataGridViewTextBoxColumn.DataPropertyName = "IdTypeBus";
            this.idTypeBusDataGridViewTextBoxColumn.HeaderText = "IdTypeBus";
            this.idTypeBusDataGridViewTextBoxColumn.Name = "idTypeBusDataGridViewTextBoxColumn";
            this.idTypeBusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTypeBusDataGridViewTextBoxColumn.Visible = false;
            // 
            // idConditionDataGridViewTextBoxColumn
            // 
            this.idConditionDataGridViewTextBoxColumn.DataPropertyName = "IdCondition";
            this.idConditionDataGridViewTextBoxColumn.HeaderText = "IdCondition";
            this.idConditionDataGridViewTextBoxColumn.Name = "idConditionDataGridViewTextBoxColumn";
            this.idConditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idConditionDataGridViewTextBoxColumn.Visible = false;
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataSource = typeof(CarPark.Bus);
            // 
            // FormCarPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCarPark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCarPark";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource busBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeBusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn governmentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeBusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыАвтобусовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem состояниеАвтобусовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияПоЗапросуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свободныеАвтобусыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автобусыВРейсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автобусыВРемонтеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списанныеАвтобусыToolStripMenuItem;
    }
}

