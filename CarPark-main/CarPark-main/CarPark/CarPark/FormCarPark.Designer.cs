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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarPark));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeBusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.governmentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeBusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьАвтобусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьАвтобусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьАвтобусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TotalCount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CountLable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыАвтобусовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.состояниеАвтобусовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияПоЗапросуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свободныеАвтобусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автобусыВРейсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автобусыВРемонтеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списанныеАвтобусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеАвтобусыАвтопаркаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.idTypeBusDataGridViewTextBoxColumn,
            this.idConditionDataGridViewTextBoxColumn,
            this.numberOfSeatsDataGridViewTextBoxColumn,
            this.governmentNumberDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.typeBusDataGridViewTextBoxColumn,
            this.driverDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.busBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(963, 708);
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
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Марка автобуса";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 200;
            // 
            // idTypeBusDataGridViewTextBoxColumn
            // 
            this.idTypeBusDataGridViewTextBoxColumn.DataPropertyName = "IdTypeBus";
            this.idTypeBusDataGridViewTextBoxColumn.HeaderText = "IdTypeBus";
            this.idTypeBusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTypeBusDataGridViewTextBoxColumn.Name = "idTypeBusDataGridViewTextBoxColumn";
            this.idTypeBusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTypeBusDataGridViewTextBoxColumn.Visible = false;
            this.idTypeBusDataGridViewTextBoxColumn.Width = 125;
            // 
            // idConditionDataGridViewTextBoxColumn
            // 
            this.idConditionDataGridViewTextBoxColumn.DataPropertyName = "IdCondition";
            this.idConditionDataGridViewTextBoxColumn.HeaderText = "IdCondition";
            this.idConditionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idConditionDataGridViewTextBoxColumn.Name = "idConditionDataGridViewTextBoxColumn";
            this.idConditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idConditionDataGridViewTextBoxColumn.Visible = false;
            this.idConditionDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfSeatsDataGridViewTextBoxColumn
            // 
            this.numberOfSeatsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.HeaderText = "Количество мест";
            this.numberOfSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfSeatsDataGridViewTextBoxColumn.Name = "numberOfSeatsDataGridViewTextBoxColumn";
            this.numberOfSeatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfSeatsDataGridViewTextBoxColumn.Width = 120;
            // 
            // governmentNumberDataGridViewTextBoxColumn
            // 
            this.governmentNumberDataGridViewTextBoxColumn.DataPropertyName = "GovernmentNumber";
            this.governmentNumberDataGridViewTextBoxColumn.HeaderText = "Государственный номер";
            this.governmentNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.governmentNumberDataGridViewTextBoxColumn.Name = "governmentNumberDataGridViewTextBoxColumn";
            this.governmentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.governmentNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.conditionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Width = 120;
            // 
            // typeBusDataGridViewTextBoxColumn
            // 
            this.typeBusDataGridViewTextBoxColumn.DataPropertyName = "TypeBus";
            this.typeBusDataGridViewTextBoxColumn.HeaderText = "Тип автобуса";
            this.typeBusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeBusDataGridViewTextBoxColumn.Name = "typeBusDataGridViewTextBoxColumn";
            this.typeBusDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeBusDataGridViewTextBoxColumn.Width = 120;
            // 
            // driverDataGridViewTextBoxColumn
            // 
            this.driverDataGridViewTextBoxColumn.DataPropertyName = "Driver";
            this.driverDataGridViewTextBoxColumn.HeaderText = "Закрепленный водитель";
            this.driverDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverDataGridViewTextBoxColumn.Name = "driverDataGridViewTextBoxColumn";
            this.driverDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverDataGridViewTextBoxColumn.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАвтобусToolStripMenuItem,
            this.изменитьАвтобусToolStripMenuItem,
            this.удалитьАвтобусToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 94);
            // 
            // добавитьАвтобусToolStripMenuItem
            // 
            this.добавитьАвтобусToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.добавитьАвтобусToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_plus_24;
            this.добавитьАвтобусToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.добавитьАвтобусToolStripMenuItem.Name = "добавитьАвтобусToolStripMenuItem";
            this.добавитьАвтобусToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.добавитьАвтобусToolStripMenuItem.Text = "Добавить автобус";
            this.добавитьАвтобусToolStripMenuItem.Click += new System.EventHandler(this.добавитьАвтобусToolStripMenuItem_Click);
            // 
            // изменитьАвтобусToolStripMenuItem
            // 
            this.изменитьАвтобусToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.изменитьАвтобусToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_pencil_drawing_24;
            this.изменитьАвтобусToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.изменитьАвтобусToolStripMenuItem.Name = "изменитьАвтобусToolStripMenuItem";
            this.изменитьАвтобусToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.изменитьАвтобусToolStripMenuItem.Text = "Изменить автобус";
            this.изменитьАвтобусToolStripMenuItem.Click += new System.EventHandler(this.изменитьАвтобусToolStripMenuItem_Click);
            // 
            // удалитьАвтобусToolStripMenuItem
            // 
            this.удалитьАвтобусToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.удалитьАвтобусToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_waste_24;
            this.удалитьАвтобусToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.удалитьАвтобусToolStripMenuItem.Name = "удалитьАвтобусToolStripMenuItem";
            this.удалитьАвтобусToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.удалитьАвтобусToolStripMenuItem.Text = "Удалить автобус";
            this.удалитьАвтобусToolStripMenuItem.Click += new System.EventHandler(this.удалитьАвтобусToolStripMenuItem_Click);
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataSource = typeof(CarPark.Bus);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TotalCount);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.CountLable);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(106)))), ((int)(((byte)(102)))));
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 44);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::CarPark.Properties.Resources.free_icon_back_arrow_1174481;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(447, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отменить действие";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalCount
            // 
            this.TotalCount.AutoSize = true;
            this.TotalCount.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TotalCount.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalCount.Location = new System.Drawing.Point(936, 13);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(16, 18);
            this.TotalCount.TabIndex = 4;
            this.TotalCount.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(51, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CountLable
            // 
            this.CountLable.AutoSize = true;
            this.CountLable.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CountLable.ForeColor = System.Drawing.SystemColors.Control;
            this.CountLable.Location = new System.Drawing.Point(707, 13);
            this.CountLable.Name = "CountLable";
            this.CountLable.Size = new System.Drawing.Size(223, 18);
            this.CountLable.TabIndex = 3;
            this.CountLable.Text = "Общее количество автобусов:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarPark.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.информацияПоЗапросуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseLeave += new System.EventHandler(this.menuStrip1_MouseLeave);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.водителиToolStripMenuItem,
            this.типыАвтобусовToolStripMenuItem,
            this.состояниеАвтобусовToolStripMenuItem});
            this.справочникиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.справочникиToolStripMenuItem.Image = global::CarPark.Properties.Resources.files;
            this.справочникиToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            this.справочникиToolStripMenuItem.DropDownClosed += new System.EventHandler(this.справочникиToolStripMenuItem_DropDownClosed);
            this.справочникиToolStripMenuItem.DropDownOpened += new System.EventHandler(this.справочникиToolStripMenuItem_DropDownOpened);
            // 
            // водителиToolStripMenuItem
            // 
            this.водителиToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.водителиToolStripMenuItem.Image = global::CarPark.Properties.Resources.driver;
            this.водителиToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.водителиToolStripMenuItem.Name = "водителиToolStripMenuItem";
            this.водителиToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.водителиToolStripMenuItem.Text = "Водители автопарка";
            this.водителиToolStripMenuItem.Click += new System.EventHandler(this.водителиToolStripMenuItem_Click);
            // 
            // типыАвтобусовToolStripMenuItem
            // 
            this.типыАвтобусовToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.типыАвтобусовToolStripMenuItem.Image = global::CarPark.Properties.Resources.bus;
            this.типыАвтобусовToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.типыАвтобусовToolStripMenuItem.Name = "типыАвтобусовToolStripMenuItem";
            this.типыАвтобусовToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.типыАвтобусовToolStripMenuItem.Text = "Типы автобусов";
            this.типыАвтобусовToolStripMenuItem.Click += new System.EventHandler(this.типыАвтобусовToolStripMenuItem_Click);
            // 
            // состояниеАвтобусовToolStripMenuItem
            // 
            this.состояниеАвтобусовToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.состояниеАвтобусовToolStripMenuItem.Image = global::CarPark.Properties.Resources.pin;
            this.состояниеАвтобусовToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.состояниеАвтобусовToolStripMenuItem.Name = "состояниеАвтобусовToolStripMenuItem";
            this.состояниеАвтобусовToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.состояниеАвтобусовToolStripMenuItem.Text = "Состояние автобусов";
            this.состояниеАвтобусовToolStripMenuItem.Click += new System.EventHandler(this.состояниеАвтобусовToolStripMenuItem_Click);
            // 
            // информацияПоЗапросуToolStripMenuItem
            // 
            this.информацияПоЗапросуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свободныеАвтобусыToolStripMenuItem,
            this.автобусыВРейсеToolStripMenuItem,
            this.автобусыВРемонтеToolStripMenuItem,
            this.списанныеАвтобусыToolStripMenuItem,
            this.всеАвтобусыАвтопаркаToolStripMenuItem});
            this.информацияПоЗапросуToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.информацияПоЗапросуToolStripMenuItem.Image = global::CarPark.Properties.Resources.search;
            this.информацияПоЗапросуToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.информацияПоЗапросуToolStripMenuItem.Name = "информацияПоЗапросуToolStripMenuItem";
            this.информацияПоЗапросуToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.информацияПоЗапросуToolStripMenuItem.Text = "Информация по запросу";
            this.информацияПоЗапросуToolStripMenuItem.DropDownClosed += new System.EventHandler(this.информацияПоЗапросуToolStripMenuItem_DropDownClosed);
            this.информацияПоЗапросуToolStripMenuItem.DropDownOpened += new System.EventHandler(this.информацияПоЗапросуToolStripMenuItem_DropDownOpened);
            this.информацияПоЗапросуToolStripMenuItem.Click += new System.EventHandler(this.информацияПоЗапросуToolStripMenuItem_Click);
            // 
            // свободныеАвтобусыToolStripMenuItem
            // 
            this.свободныеАвтобусыToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.свободныеАвтобусыToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_delivery_time_24;
            this.свободныеАвтобусыToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.свободныеАвтобусыToolStripMenuItem.Name = "свободныеАвтобусыToolStripMenuItem";
            this.свободныеАвтобусыToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.свободныеАвтобусыToolStripMenuItem.Text = "Свободные автобусы";
            this.свободныеАвтобусыToolStripMenuItem.Click += new System.EventHandler(this.свободныеАвтобусыToolStripMenuItem_Click);
            // 
            // автобусыВРейсеToolStripMenuItem
            // 
            this.автобусыВРейсеToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.автобусыВРейсеToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_three_way_direction_24;
            this.автобусыВРейсеToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.автобусыВРейсеToolStripMenuItem.Name = "автобусыВРейсеToolStripMenuItem";
            this.автобусыВРейсеToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.автобусыВРейсеToolStripMenuItem.Text = "Автобусы в рейсе";
            this.автобусыВРейсеToolStripMenuItem.Click += new System.EventHandler(this.автобусыВРейсеToolStripMenuItem_Click);
            // 
            // автобусыВРемонтеToolStripMenuItem
            // 
            this.автобусыВРемонтеToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.автобусыВРемонтеToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_maintenance_24;
            this.автобусыВРемонтеToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.автобусыВРемонтеToolStripMenuItem.Name = "автобусыВРемонтеToolStripMenuItem";
            this.автобусыВРемонтеToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.автобусыВРемонтеToolStripMenuItem.Text = "Автобусы в ремонте";
            this.автобусыВРемонтеToolStripMenuItem.Click += new System.EventHandler(this.автобусыВРемонтеToolStripMenuItem_Click);
            // 
            // списанныеАвтобусыToolStripMenuItem
            // 
            this.списанныеАвтобусыToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.списанныеАвтобусыToolStripMenuItem.Image = global::CarPark.Properties.Resources.icons8_sync_settings_24;
            this.списанныеАвтобусыToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.списанныеАвтобусыToolStripMenuItem.Name = "списанныеАвтобусыToolStripMenuItem";
            this.списанныеАвтобусыToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.списанныеАвтобусыToolStripMenuItem.Text = "Списанные автобусы";
            this.списанныеАвтобусыToolStripMenuItem.Click += new System.EventHandler(this.списанныеАвтобусыToolStripMenuItem_Click);
            // 
            // всеАвтобусыАвтопаркаToolStripMenuItem
            // 
            this.всеАвтобусыАвтопаркаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(194)))));
            this.всеАвтобусыАвтопаркаToolStripMenuItem.Image = global::CarPark.Properties.Resources.bus__2_;
            this.всеАвтобусыАвтопаркаToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.всеАвтобусыАвтопаркаToolStripMenuItem.Name = "всеАвтобусыАвтопаркаToolStripMenuItem";
            this.всеАвтобусыАвтопаркаToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.всеАвтобусыАвтопаркаToolStripMenuItem.Text = "Все автобусы автопарка";
            this.всеАвтобусыАвтопаркаToolStripMenuItem.Click += new System.EventHandler(this.всеАвтобусыАвтопаркаToolStripMenuItem_Click);
            // 
            // FormCarPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 784);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCarPark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет наличия транспортных средств (автобусы) в автопарке";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьАвтобусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьАвтобусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьАвтобусToolStripMenuItem;
        private System.Windows.Forms.BindingSource busBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeBusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn governmentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeBusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem всеАвтобусыАвтопаркаToolStripMenuItem;
        private System.Windows.Forms.Label CountLable;
        private System.Windows.Forms.Label TotalCount;
        private System.Windows.Forms.Button button1;
    }
}

