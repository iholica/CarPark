using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarPark
{
    public partial class FormTypesOfBuses : Form
    {
        DBEntities db;
        public FormTypesOfBuses()
        {
            InitializeComponent();
            
            db = new DBEntities();
            db.TypeBus.Load();
            dataGridView1.DataSource = db.TypeBus.Local.ToBindingList();
        }
        //редактирование типа автобуса
        private void изменитьТипАвтобусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool item = Int32.TryParse(dataGridView1[0, index].Value.ToString(),out id);
                if (item == false)
                    return;

                TypeBus type_bus = db.TypeBus.Find(id);

                FormEditTypeOfBuses form_edit = new FormEditTypeOfBuses();

                form_edit.textBox1.Text = type_bus.Name;

                DialogResult result = form_edit.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                type_bus.Name = form_edit.textBox1.Text;

                db.Entry(type_bus).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Данные обновлены.", "Типы автобусов", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Выберите данные для редактирования!.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //добавление типа автобуса
        private void добавитьТипАвтобусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditTypeOfBuses form_edit = new FormEditTypeOfBuses();

            DialogResult result = form_edit.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            TypeBus type_bus = new TypeBus();
            type_bus.Name = form_edit.textBox1.Text;

            db.TypeBus.Add(type_bus);
            db.SaveChanges();

            MessageBox.Show("Новый тип автобуса добавлен.", "Типы автобусов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
