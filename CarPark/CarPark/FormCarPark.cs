using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CarPark
{
    public partial class FormCarPark : Form
    {
        DBEntities db;
        public FormCarPark()
        {
            InitializeComponent();

            db = new DBEntities();
            db.Bus.Load();
            dataGridView1.DataSource = db.Bus.Local.ToBindingList();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        //водители
        private void водителиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormDrivers form = new FormDrivers();
            form.Show();
        }
        //типы автобусов
        private void типыАвтобусовToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormTypesOfBuses form = new FormTypesOfBuses();
            form.Show();
        }
        //состояние
        private void состояниеАвтобусовToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormConditions form = new FormConditions();
            form.Show();
        }
        //добавление автобуса
        private void добавитьАвтобусToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormEditBus form_edit = new FormEditBus();

            List<TypeBus> types = db.TypeBus.ToList();
            form_edit.comboBox1.DataSource = types;
            form_edit.comboBox1.ValueMember = "Id";
            form_edit.comboBox1.DisplayMember = "Name";

            List<Condition> conditions = db.Condition.ToList();
            form_edit.comboBox2.DataSource = conditions;
            form_edit.comboBox2.ValueMember = "Id";
            form_edit.comboBox2.DisplayMember = "Name";

            List<Driver> drivers = db.Driver.ToList();
            form_edit.comboBox3.DataSource = drivers;
            form_edit.comboBox3.ValueMember = "Id";
            form_edit.comboBox3.DisplayMember = "LastName";

            DialogResult result = form_edit.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            Bus bus = new Bus();
            bus.Brand = form_edit.textBox1.Text;
            bus.TypeBus = (TypeBus)form_edit.comboBox1.SelectedItem;
            bus.Condition = (Condition)form_edit.comboBox2.SelectedItem;
            bus.NumberOfSeats = Convert.ToInt32(form_edit.textBox2.Text);
            bus.GovernmentNumber = form_edit.textBox3.Text;
            bus.Driver = (Driver)form_edit.comboBox3.SelectedItem;

            db.Bus.Add(bus);
            db.SaveChanges();

            MessageBox.Show("Новый автобус добавлен.", "Автобусы", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //редакирование записи автобуса
        private void изменитьАвтобусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool item = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (item == false)
                    return;

                Bus bus = db.Bus.Find(id);
                FormEditBus form_edit = new FormEditBus();

                form_edit.textBox1.Text = bus.Brand;
                form_edit.textBox2.Text = Convert.ToString(bus.NumberOfSeats);
                form_edit.textBox3.Text = bus.GovernmentNumber;

                List<TypeBus> types = db.TypeBus.ToList();
                form_edit.comboBox1.DataSource = types;
                form_edit.comboBox1.ValueMember = "Id";
                form_edit.comboBox1.DisplayMember = "Name";
                if (bus.TypeBus!= null)
                    form_edit.comboBox1.SelectedValue = bus.TypeBus.Id;

                List<Condition> conditions = db.Condition.ToList();
                form_edit.comboBox2.DataSource = conditions;
                form_edit.comboBox2.ValueMember = "Id";
                form_edit.comboBox2.DisplayMember = "Name";
                if (bus.Condition != null)
                    form_edit.comboBox2.SelectedValue = bus.Condition.Id;

                List<Driver> drivers = db.Driver.ToList();
                form_edit.comboBox3.DataSource = drivers;
                form_edit.comboBox3.ValueMember = "Id";
                form_edit.comboBox3.DisplayMember = "LastName";
                if (bus.Driver != null)
                    form_edit.comboBox3.SelectedValue = bus.Driver.Id;

                DialogResult result = form_edit.ShowDialog();

                if (result == DialogResult.Cancel)
                    return;

                bus.Brand = form_edit.textBox1.Text;
                bus.TypeBus = (TypeBus)form_edit.comboBox1.SelectedItem;
                bus.Condition = (Condition)form_edit.comboBox2.SelectedItem;
                bus.NumberOfSeats = Convert.ToInt32(form_edit.textBox2.Text);
                bus.GovernmentNumber = form_edit.textBox3.Text;
                bus.Driver = (Driver)form_edit.comboBox3.SelectedItem;

                db.Entry(bus).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Информация об автобусе изменена.", "Автобусы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Выберите данные для редактирования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //удаление автобуса
        private void удалитьАвтобусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool item = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (item == false)
                    return;
                if (MessageBox.Show("Вы действительно желаете удалить выбранный автобус?", "Операция удаления автобуса", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Bus bus = db.Bus.Find(id);
                    db.Bus.Remove(bus);
                    MessageBox.Show("Информация о автобусе удалена.", "Автобусы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Выберите данные для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //поиск по таблице
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            var search = db.Bus.Where(bus => bus.Brand.StartsWith(item)| bus.Driver.LastName.StartsWith(item)|bus.GovernmentNumber.StartsWith(item)|bus.TypeBus.Name.StartsWith(item));

            dataGridView1.DataSource = search.ToList();
        }

        private void свободныеАвтобусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryEmptyBus = db.Bus.Where(bus => bus.Condition.Name == "На базе");
            dataGridView1.DataSource = queryEmptyBus.ToList();
        }

        private void автобусыВРейсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryInFlightBus = db.Bus.Where(bus => bus.Condition.Name == "В рейсе");
            dataGridView1.DataSource = queryInFlightBus.ToList();
        }

        private void автобусыВРемонтеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryUnderRepair = db.Bus.Where(bus => bus.Condition.Name == "В ремонте");
            dataGridView1.DataSource = queryUnderRepair.ToList();
        }

        private void списанныеАвтобусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryDecommissioned = db.Bus.Where(bus => bus.Condition.Name == "Списан");
            dataGridView1.DataSource = queryDecommissioned.ToList();
        }

        private void всеАвтобусыАвтопаркаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryAllBuses = from bus in db.Bus
                                select bus;
            dataGridView1.DataSource = queryAllBuses.ToList();
        }
    }
}
