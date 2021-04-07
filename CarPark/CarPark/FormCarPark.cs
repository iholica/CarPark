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
            form_edit.comboBox1.DataSource = conditions;
            form_edit.comboBox1.ValueMember = "Id";
            form_edit.comboBox1.DisplayMember = "Name";
        }
    }
}
