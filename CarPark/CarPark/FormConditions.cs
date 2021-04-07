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
    public partial class FormConditions : Form
    {
        DBEntities db;
        public FormConditions()
        {
            InitializeComponent();

            db = new DBEntities();
            db.Condition.Load();
            dataGridView1.DataSource = db.Condition.Local.ToBindingList();
        }
        //редактирование состояния автобуса
        private void изменитьСостояниеАвтобусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool item = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (item == false)
                    return;

                Condition condition = db.Condition.Find(id);

                FormEditCondition form_edit = new FormEditCondition();

                form_edit.textBox1.Text = condition.Name;

                DialogResult result = form_edit.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                condition.Name = form_edit.textBox1.Text;

                db.Entry(condition).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Данные обновлены.", "Состояние автобусов", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Выберите данные для редактирования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void добавитьСостояниеАвтобусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditCondition form_edit = new FormEditCondition();

            DialogResult result = form_edit.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Condition condition = new Condition();
            condition.Name = form_edit.textBox1.Text;

            db.Condition.Add(condition);
            db.SaveChanges();

            MessageBox.Show("Новые состояние автобуса добавлено.", "Состояние автобусов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void удалитьСостояниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool item = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (item == false)
                    return;
                if (MessageBox.Show("Вы действительно желаете удалить выбранное состояние автобуса?", "Операция удаления состояния автобуса", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Condition condition = db.Condition.Find(id);
                    db.Condition.Remove(condition);
                    db.SaveChanges();
                    MessageBox.Show("Данные удалены.", "Состояния автобусов", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Выберите данные для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
